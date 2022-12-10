using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayerEntitiesLibrary.Products;
using LogicLayerEntitiesLibrary.Exceptions;

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

        public bool UpdateProduct(Product newProduct, Product currentProduct)
        {
            bool update = false;
            if (!CheckIfProductModified(currentProduct)) throw new ArgumentException("Product has been modified while you were changing the information");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "Update Product set name = @name, category = @category, sub_category = @sub_category, unit = @unit, price = @price, stock = @stock, Image = @image, last_modified = @lastModified where product.id = @productId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@productId", currentProduct.Id);
                cmd.Parameters.AddWithValue("@name", newProduct.Name);
                cmd.Parameters.AddWithValue("@category", newProduct.Category);
                cmd.Parameters.AddWithValue("@sub_Category", newProduct.SubCategory);
                cmd.Parameters.AddWithValue("@unit", newProduct.Unit);
                cmd.Parameters.AddWithValue("@price", newProduct.Price);
                cmd.Parameters.AddWithValue("@stock", newProduct.InStock);
                cmd.Parameters.AddWithValue("@lastModified", newProduct.LastModified);
                if (newProduct.Image != null) cmd.Parameters.AddWithValue("@image", newProduct.Image);
                else cmd.Parameters.Add("@image", SqlDbType.VarBinary).Value = DBNull.Value;

                cmd.ExecuteNonQuery();
                if (cmd.ExecuteNonQuery() != 0) update = true;
            }
            return update;
        }

        public bool DeleteProduct(Product product)
        {
            if (CheckIfProductExist(product.Name) == false) throw new ArgumentException("Product does not exist in the database");
            bool deleted = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "Delete from Product where id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", product.Id);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0) return deleted;
                deleted = true;
            }
            return deleted;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "select * from product order by id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    byte[]? image;
                    DateTime? lastModified;

                    if (dr["image"] != DBNull.Value) image = (byte[])dr["image"];
                    else image = null;
                    if (dr["last_modified"] != DBNull.Value) lastModified = (DateTime)dr["last_modified"];
                    else lastModified = null;

                    Product product = new Product(Convert.ToInt32(dr["id"]), (string)dr["name"], (string)dr["category"], (string)dr["sub_category"], (string)dr["unit"], Convert.ToDouble(dr["price"]), image, (bool)dr["stock"], lastModified);

                    products.Add(product);
                }
            }
            return products;
        }

        public List<Product> SearchProduct(string term, ProductSearchType type)
        {
            List<Product> products = new List<Product>();
            string query = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (type == ProductSearchType.category)
                {
                    query = "select * from Product WHERE category = @term ORDER BY id;";
                }
                else if (type == ProductSearchType.sub_category)
                {
                    query = "select * from Product WHERE sub_category = @term ORDER BY id;";
                }
                else
                {
                    query = $"select * from Product WHERE {type} LIKE '%{term}%' ORDER BY id;";
                }

                SqlCommand cmd = new SqlCommand(query, conn);

                if(type == ProductSearchType.category || type ==ProductSearchType.sub_category) cmd.Parameters.AddWithValue("@term", term);
                

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        byte[]? image;
                        DateTime? lastModified;

                        if (dr["image"] != DBNull.Value) image = (byte[])dr["image"];
                        else image = null;
                        if (dr["last_modified"] != DBNull.Value) lastModified = (DateTime)dr["last_modified"];
                        else lastModified = null;

                        Product product = new Product(Convert.ToInt32(dr["id"]), (string)dr["name"], (string)dr["category"], (string)dr["sub_category"], (string)dr["unit"], Convert.ToDouble(dr["price"]), image, (bool)dr["stock"], lastModified);
                        products.Add(product);
                    }
                }
                else
                {
                    throw new NoResultException("No results found");
                }
            }
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

        private bool CheckIfProductModified(Product currentProduct)
        {
            bool notModified = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "select id from Product where (product.id = @productId) AND (last_modified is null OR last_modified = @lastModifiedCurrent)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@productId", currentProduct.Id);
                if (currentProduct.LastModified != null) cmd.Parameters.AddWithValue("@lastModifiedCurrent", currentProduct.LastModified);
                else cmd.Parameters.AddWithValue("@lastModifiedCurrent", DBNull.Value);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if ((int)dr["id"] == currentProduct.Id) notModified = true;
                }
            }
            return notModified;
        }
    }
}
