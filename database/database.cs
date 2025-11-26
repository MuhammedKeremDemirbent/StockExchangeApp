using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockExchangeApp.database  //Form kodunuz bu adresi kullanarak bu sınıfa ulaşır
{
    internal class database
    {
        private string baglantibilgileri = "server=localhost;port=3306;database=exchange_app;uid=root;pwd=Beyazpano123;"; //MySQL sunucusuna giriş kartı BURASI DEĞİŞECEK!   
        public MySqlConnection GetConnection()  //Bağlantı metodu : Sunucu ile bağlantı kurar
        {
            return new MySqlConnection(baglantibilgileri);
        }
        public bool KayitEkle(string hisseAdi, decimal fiyat, decimal yuzdeDegisim, decimal hacim)
        {
            using (MySqlConnection connection = GetConnection())
            {
                try
                {   
                    connection.Open();

                    // INSERT ON DUPLICATE KEY UPDATE SORGUSU KULLANIYORUZ!
                    // Eğer hisseAdi (hisse_isimleri) zaten varsa, sadece fiyatı günceller. 
                    string insertSorgu = @"
            INSERT INTO hisseler (hisse_isimleri, fiyat, yüzde, hacim) 
            VALUES (@hisseAdi, @fiyat, @yuzdeDegisim, @hacim)
            ON DUPLICATE KEY UPDATE
            fiyat = @fiyat,
            yüzde = @yuzdeDegisim,
            hacim = @hacim;";

                    MySqlCommand insertCommand = new MySqlCommand(insertSorgu, connection); //SQL sorgusunu ve hangi bağlantı üzerinden gönderileceğini tanımlayan komut nesnesi.

                    insertCommand.Parameters.AddWithValue("@hisseAdi", hisseAdi); 
                    insertCommand.Parameters.AddWithValue("@fiyat", fiyat);
                    insertCommand.Parameters.AddWithValue("@yuzdeDegisim", yuzdeDegisim);
                    insertCommand.Parameters.AddWithValue("@hacim", hacim);

                    int satirEtkilendi = insertCommand.ExecuteNonQuery(); 

                    return satirEtkilendi > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Veritabanına kayıt/güncelleme yapılırken hata oluştu: {ex.Message}", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
