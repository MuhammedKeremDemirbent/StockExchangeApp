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
                //lblAKSEN.Text = await pull_datas.GetQuoteAsync(txtbxVeri_isteme.Text + ".IS");
                //lblAKSEN.Text = await pull_datas.GetQuoteAsync("AMZN");

                //lblGARAN.Text = await pull_datas.GetQuoteAsync("AAPL");
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
        private async void buttonhisse_goster_Click(object sender, EventArgs e)
        {
            string hisseSembol = txtbxVeri_isteme.Text.Trim(); //Boşluk temizler

            if (string.IsNullOrEmpty(hisseSembol))
            {
                MessageBox.Show("Lütfen hisse adı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tamSembol = hisseSembol + ".IS";
            string fiyatStr = await pull_datas.GetQuoteAsync(tamSembol); //Hisse verisini çekme işlemi
      
            if (string.IsNullOrEmpty(fiyatStr) || fiyatStr.Trim().ToUpper() == "N/A" || fiyatStr.Length < 1) //Veri yoksa hata mesajı gösterir
            {
                MessageBox.Show($"'{hisseSembol}' sembolü için geçerli veri bulunamadı. Lütfen sembolü kontrol edin.", "Veri Yok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fiyati_parse_etme(fiyatStr, out decimal fiyatDecimal))
            {
                hisse_gosterme_gridview.Rows.Add(hisseSembol, fiyatDecimal.ToString("N4"), "0"); //Gride ekleme işlemi
                bool kayitBasarili = db.KayitEkle(hisseSembol, fiyatDecimal); //SQL kayıt metodu çağrısını çağırdık

                if (!kayitBasarili)
                {
                    Console.WriteLine("Veritabanı kaydı başarısız oldu.");
                }
            }
            else
            {
                MessageBox.Show($"Çekilen fiyat verisi ('{fiyatStr}') sayıya dönüştürülemedi. Kayıt yapılmadı.", "Veri Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

