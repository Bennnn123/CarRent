using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BCTwo.WFClass
{
    public class CProduct
    {
        public int ProductID { set; get; }
        public string Name { set; get; }
        public string Brand { set; get; }
        public string Category { set; get; }
        public string Modal { set; get; }
        public string Stock { set; get; }
        public int Price { set; get; }
        public string Image1 { set; get; }
        public string Image2 { set; get; }
        public string Image3 { set; get; }
        public string Image4 { set; get; }
        public string Image5 { set; get; }
        public string Description { set; get; }
        public string Passengers { set; get; }
    }


    public class CProductHandler
    {

        
        string path = "data source=(LocalDB)\\MSSQLLocalDB;attachdbfilename=|DataDirectory|\\CarRent.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";



        public void AddCProduct(CProduct p)
        {
            using (SqlConnection cn = new SqlConnection(this.path))
            {
                SqlCommand cmd = new SqlCommand(
                    "insert into CarProduct values(@name , @brand , @category , @modal , @stock , @price , @image1 ," +
                    " @image2 , @image3 , @image4 , @image5 , @description , @passengers)",
                    cn);

                cmd.Parameters.AddWithValue("@name", p.Name);
                cmd.Parameters.AddWithValue("@brand", p.Brand);
                cmd.Parameters.AddWithValue("@category", p.Category);
                cmd.Parameters.AddWithValue("@modal", p.Modal);
                cmd.Parameters.AddWithValue("@stock", p.Stock);
                cmd.Parameters.AddWithValue("@price", p.Price);
                cmd.Parameters.AddWithValue("@image1", p.Image1);
                cmd.Parameters.AddWithValue("@image2", p.Image2);
                cmd.Parameters.AddWithValue("@image3", p.Image3);
                cmd.Parameters.AddWithValue("@image4", p.Image4);
                cmd.Parameters.AddWithValue("@image5", p.Image5);
                cmd.Parameters.AddWithValue("@description", p.Description);
                cmd.Parameters.AddWithValue("@passengers", p.Passengers);
                //cmd.Parameters.AddWithValue("@amount", p.Amount);
                //cmd.Parameters.AddWithValue("@imgUrl", p.ImageFileName);
                //cmd.Parameters.AddWithValue("@imgUrl", DBNull.Value);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}