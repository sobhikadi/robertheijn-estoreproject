using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayerEntitiesLibrary.Products;

namespace DataAccessLibrary.Products
{
    public class DBProduct : IDBMediatorProducts
    {
        private string connectionString = "server=mssqlstud.fhict.local;" + "database=dbi376372_robertheij;" + "user id=dbi376372_robertheij;" + "password=robertheijn;" + "connect timeout=30;";


        public int InsertProduct(Product product)
        {
            if (CheckIfProductExist(product.Name)) throw new ArgumentException("Product already exists in the database");
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "insert into Product (name, category, sub_category, unit, price, stock, image, last_modified) values (@name, @category, @sub_category, @unit, @price, @stock, @image, @last_modified); select SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@category", product.Category);
                cmd.Parameters.AddWithValue("@sub_Category", product.SubCategory);
                cmd.Parameters.AddWithValue("@unit", product.Unit);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@stock", product.InStock);
                cmd.Parameters.AddWithValue("@last_modified", DBNull.Value);
                if (product.Image != null) cmd.Parameters.AddWithValue("@image", product.Image);
                else cmd.Parameters.Add("@image", SqlDbType.VarBinary).Value = DBNull.Value;

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) id = Convert.ToInt32(dr[0]);
            }
            return id;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    conn.Open();
            //    string sql = "select id, name, quantity, price, category, subcategory, description, isbn, platform, serialNumber, color, image, lastModified from product order by id;";
            //    SqlCommand cmd = new SqlCommand(sql, conn);

            //    SqlDataReader dr = cmd.ExecuteReader();

            //    while (dr.Read())
            //    {
            //        string? isbn, serialNumber, color, platform;
            //        byte[]? image;
            //        DateTime? lastModified;

            //        if (dr["isbn"] != DBNull.Value) isbn = (string)dr["isbn"];
            //        else isbn = null;
            //        if (dr["serialNumber"] != DBNull.Value) serialNumber = (string)dr["serialNumber"];
            //        else serialNumber = null;
            //        if (dr["color"] != DBNull.Value) color = (string)dr["color"];
            //        else color = null;
            //        if (dr["platform"] != DBNull.Value) platform = (string)dr["platform"];
            //        else platform = null;
            //        if (dr["image"] != DBNull.Value) image = (byte[])dr["image"];
            //        else image = null;
            //        if (dr["lastModified"] != DBNull.Value) lastModified = (DateTime)dr["lastModified"];
            //        else lastModified = null;

            //        SingleProduct product = new SingleProduct(Convert.ToInt32(dr["id"]), (string)dr["name"], (string)dr["description"], Convert.ToInt32(dr["quantity"]), Convert.ToDouble(dr["price"]), (string)dr["category"], (string)dr["subCategory"], isbn, serialNumber, color, platform, image, lastModified);

            //        product.GetSpecsFromDB(GetProductSpecifications(Convert.ToInt32(dr["id"])));

            //        products.Add(product);
            //    }
            //    conn.Close();
            //}
            return products;
        }

        private bool CheckIfProductExist(string name)
        {
            bool exist = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "select id from Product where name=@name";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", name);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read()) exist = true;
            }
            return exist;
        }
    }
}
