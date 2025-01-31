using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("---------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=KADIR13\\SQLEXPRESS02;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Insert into TblCategory (CategoryName) values (@p1)", connection);

            ////Burada @p1 parametresine categoryName değerini veriyoruz.
            //command.Parameters.AddWithValue("@p1", categoryName);

            ////Komutu çalıştırıyoruz.
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Kategori Ekleme İşlemi Başarılı Bir Şekilde Gerçekleşti.");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Eklemek İstediğiniz Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Eklemek İstediğiniz Ürün Fiyatı: ");
            //productPrice = decimal.Parse((Console.ReadLine()));


            //SqlConnection connection = new SqlConnection("Data Source=KADIR13\\SQLEXPRESS02;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Insert into TblProducts (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", connection);

            ////Burada @p1,@p2,@p3 parametresine productName,productPrice,productStatus değerlerini veriyoruz.
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Ekleme İşlemi Başarılı Bir Şekilde Gerçekleşti.");



            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=KADIR13\\SQLEXPRESS02;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * from TblProducts", connection);

            ////Verileri okumak için bir SqlDataReader nesnesi oluşturuyoruz.
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            ////Verileri okuyup DataTable'a dolduruyoruz.
            //DataTable dataTable = new DataTable();
            //dataAdapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Ürün Listeleme İşlemi Başarılı Bir Şekilde Gerçekleşti.");


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silmek İstediğiniz Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=KADIR13\\SQLEXPRESS02;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from TblProducts where ProductId=@p1", connection);

            //command.Parameters.AddWithValue("@p1", productId);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün Silme İşlemi Başarılı Bir Şekilde Gerçekleşti.");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellemek İstediğiniz Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Yeni Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Yeni Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=KADIR13\\SQLEXPRESS02;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProducts set ProductName=@p1,ProductPrice=@p2 where ProductId=@p3", connection);

            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", productId);

            //command.ExecuteNonQuery();

            //Console.WriteLine("Ürün Güncelleme İşlemi Başarılı Bir Şekilde Gerçekleşti.");





            #endregion


            Console.Read();
        }
    }
}
