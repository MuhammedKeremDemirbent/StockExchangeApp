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
        private string baglantibilgileri = "server=localhost;port=3306;database=exchange_app;uid=root;pwd=Beyazpano123;"; //MySQL sunucusuna giriş kartı      
        public MySqlConnection GetConnection()  //Bağlantı metodu : Sunucu ile bağlantı kurar
        {
            return new MySqlConnection(baglantibilgileri);
        }
        public bool KayitEkle(string hisseAdi, decimal fiyat)
        {
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    // INSERT ON DUPLICATE KEY UPDATE SORGUSU KULLANIYORUZ!
                    // Eğer hisseAdi (hisse_isimleri) zaten varsa, sadece fiyatı günceller. BURASI YANLIŞ OLMUŞ!
                    string insertSorgu = @"
                INSERT INTO hisseler (hisse_isimleri, fiyat) 
                VALUES (@hisseAdi, @fiyat)
                ON DUPLICATE KEY UPDATE
                fiyat = @fiyat;"; // Eğer hisse zaten varsa, sadece fiyat sütununu güncelle

                    MySqlCommand insertCommand = new MySqlCommand(insertSorgu, connection);

                    // Parametreler aynı kalır, güvenlik için hala gerekli!
                    insertCommand.Parameters.AddWithValue("@hisseAdi", hisseAdi); 
                    insertCommand.Parameters.AddWithValue("@fiyat", fiyat); 

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
