using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.net
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("---------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------");

            //Veritabanı bağlantı işlemleri
            SqlConnection connection = new SqlConnection("Data Source=KADIR13\\SQLEXPRESS02;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //Bağlantıyı aç
            connection.Open();

            //Sorgu işlemleri
            SqlCommand command = new SqlCommand("SELECT * FROM TblCategory",connection);

            //Burada veritabanından verileri çekmek için bir adapter oluşturuyoruz.
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            //Verileri tutmak için bir DataTable oluşturuyoruz.
            DataTable dataTable = new DataTable();

            //Adapter ile veritabanından verileri çekip DataTable'a dolduruyoruz.
            adapter.Fill(dataTable);

            //Bağlantıyı kapat
            connection.Close();

            //DataTable'daki verileri ekrana yazdırma
            foreach (DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }






            Console.Read();
        }
    }
}
