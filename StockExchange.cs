using MySql.Data.MySqlClient;  // MySQL bağlantısı için gerekli kütüphane
using StockExchangeApp.database;
using StockExchangeApp.yahoo_api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockExchangeApp
{
    public struct HisseVerileri
    {
        public string FiyatStr { get; set; }
        public string YuzdeDegisimStr { get; set; }
        public string HacimStr { get; set; }
    }
    public partial class StockExchange : Form
    {

        public static readonly HttpClient client = new HttpClient(); //Web apileri için nesne oluşturduk. Nugetten çekiyoruz gerek yok şuanlık.
        private database.database db = new database.database();

        public StockExchange()
        {
            InitializeComponent();
        }
        private async void StockExchange_Load(object sender, EventArgs e)
        {
            while (true)
            {
           
                await Task.Delay(3000);
            }
        }
        private bool fiyati_parse_etme(string fiyatStr, out decimal fiyatDecimal) //Fiyattaki harfleri temizleyip decimal e çevirme işlemi
        {
            fiyatDecimal = 0m;

            if (string.IsNullOrEmpty(fiyatStr)) return false;

            string temizFiyat = new string(fiyatStr.Where(c => char.IsDigit(c) || c == '.' || c == ',').ToArray()); // Nokta ve virgülü bırakarak harfleri temizleme işlemi
            temizFiyat = temizFiyat.Replace(',', '.');  //Virgülleri noktaya çevirir

            return decimal.TryParse(
                temizFiyat,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out fiyatDecimal
            );
        }
        private bool yuzde_parse_etme(string yuzdeStr, out decimal yuzdeDecimal)
        {
            yuzdeDecimal = 0m;
            if (string.IsNullOrEmpty(yuzdeStr)) return false;

            // Yüzde işareti ve parantez gibi karakterleri temizle
            string temizYuzde = yuzdeStr.Trim().Replace('%', ' ').Replace('(', ' ').Replace(')', ' ').Trim();
            temizYuzde = temizYuzde.Replace(',', '.'); // Virgülleri noktaya çevirir

            return decimal.TryParse(
                temizYuzde,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out yuzdeDecimal
            );
        }

        // Yeni metot: Hacim verisini parse etme işlemi (Milyon, Bin gibi kısaltmalar olabilir, burada sadece temel temizlik yapıldı)
        private bool hacim_parse_etme(string hacimStr, out decimal hacimDecimal)
        {
            hacimDecimal = 0m;
            if (string.IsNullOrEmpty(hacimStr)) return false;

            // Harf veya diğer sembolleri temizleme (örneğin 'M' Milyon için)
            // Eğer 'M' veya 'K' gibi kısaltmalar varsa, burayı ona göre düzenlemeniz gerekir.
            string temizHacim = new string(hacimStr.Where(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());
            temizHacim = temizHacim.Replace(',', '.'); // Virgülleri noktaya çevirir

            return decimal.TryParse(
                temizHacim,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out hacimDecimal
            );
        }

        // Yeni metot: Tüm hisse verilerini çekmek için (GetQuoteAsync'in detaylı versiyonu)
        // **NOT: Bu metodun içeriği, pull_datas sınıfınızdaki gerçek API çekme mantığına göre uyarlanmalıdır.**
        private async Task<HisseVerileri> GetQuoteAndDetailsAsync(string tamSembol)
        {
            // pull_datas.GetQuoteAsync() metodunuzun sadece fiyat döndürdüğünü varsayıyoruz.
            string fiyatStr = await pull_datas.GetQuoteAsync(tamSembol);

            // Yüzde ve Hacim verilerini API'den çekemediğimiz için şimdilik boş/varsayılan değerler döndürüyoruz...
            return new HisseVerileri
            {
                FiyatStr = fiyatStr,
                YuzdeDegisimStr = "", // API'den çekemediğimiz için boş string
                HacimStr = ""        // API'den çekemediğimiz için boş string
            };
        }
        private async void buttonhisse_goster_Click(object sender, EventArgs e)
        {
            string hisseSembol = txtbxVeri_isteme.Text.Trim(); //Boşluk temizler

            if (string.IsNullOrEmpty(hisseSembol))
            {
                MessageBox.Show("Lütfen hisse adı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tamSembol = hisseSembol + ".IS";

            // Yeni metodu kullanarak tüm veriyi çekme
            HisseVerileri veriler = await GetQuoteAndDetailsAsync(tamSembol);

            if (string.IsNullOrEmpty(veriler.FiyatStr) || veriler.FiyatStr.Trim().ToUpper() == "N/A" || veriler.FiyatStr.Length < 1)
            {
                MessageBox.Show($"'{hisseSembol}' sembolü için geçerli veri bulunamadı. Lütfen sembolü kontrol edin.", "Veri Yok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal fiyatDecimal, yuzdeDecimal = 0m, hacimDecimal = 0m;
            bool fiyatBasarili = fiyati_parse_etme(veriler.FiyatStr, out fiyatDecimal);

            // Yüzde ve Hacim verilerini parse etme (Başarısız olsa bile kayda devam etmek için if'i dışarıda tuttum)
            bool yuzdeBasarili = yuzde_parse_etme(veriler.YuzdeDegisimStr, out yuzdeDecimal);
            bool hacimBasarili = hacim_parse_etme(veriler.HacimStr, out hacimDecimal);


            if (fiyatBasarili)
            {
                // Gride ekleme işlemi (Yüzde ve Hacim de eklendi)
                hisse_gosterme_gridview.Rows.Add(
                    hisseSembol,
                    fiyatDecimal.ToString("N4"),
                    yuzdeDecimal.ToString("N2") + "%", // Grid için string formatlama
                    hacimDecimal.ToString("N0") // Grid için string formatlama
                );

                // SQL kayıt metodu çağrısı 4 parametre ile güncellendi
                bool kayitBasarili = db.KayitEkle(hisseSembol, fiyatDecimal, yuzdeDecimal, hacimDecimal);

                if (!kayitBasarili)
                {
                    Console.WriteLine("Veritabanı kaydı başarısız oldu.");
                }
            }
            else
            {
                MessageBox.Show($"Çekilen fiyat verisi ('{veriler.FiyatStr}') sayıya dönüştürülemedi. Kayıt yapılmadı.", "Veri Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
            
        }
    }
}

