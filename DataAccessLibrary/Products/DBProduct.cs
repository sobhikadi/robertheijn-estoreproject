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
                string sql = "insert into Product (name, category_id, sub_category_id, unit_id, price, stock, image, last_modified) values (@name, @category, @sub_category, @unit, @price, @stock, @image, @last_modified); select SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@category", product.Category.Id);
                cmd.Parameters.AddWithValue("@sub_Category", product.SubCategory.Id);
                cmd.Parameters.AddWithValue("@unit", product.Unit.Id);
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
                string sql = "select * from ViewProductInfo order by id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                

                while (dr.Read())
                {
                    int productId = Convert.ToInt32(dr["id"]);
                    byte[]? image;
                    DateTime? lastModified;

                    if (dr["image"] != DBNull.Value) image = (byte[])dr["image"];
                    else image = null;
                    if (dr["last_modified"] != DBNull.Value) lastModified = (DateTime)dr["last_modified"];
                    else lastModified = null;


                    List<Suffix> suffixes = new List<Suffix>();
                    foreach (SuffixType type in Enum.GetValues(typeof(SuffixType))) 
                    {
                        using (SqlConnection conns = new SqlConnection(connectionString))
                        {

                            conns.Open();
                            string sqls = "";

                            if (type == SuffixType.category)
                            {
                                sqls = "select * from Category where id = @product_id;";
                            }
                            else if (type == SuffixType.sub_category)
                            {
                                sqls = "select * from SubCategory where id = @product_id;";
                            }
                            else if (type == SuffixType.unit)
                            {
                                sqls = "select * from Unit where id = @product_id;";
                            }
                            SqlCommand cmds = new SqlCommand(sqls, conns);

                            cmds.Parameters.AddWithValue("@product_id", productId);

                            SqlDataReader drs = cmds.ExecuteReader();

                            while (drs.Read())
                            {
                                suffixes.Add(new(Convert.ToInt32(drs["id"]), (string)drs[$"{type}"], type));
                            }
                        }
                    }


                    Product product = new Product(Convert.ToInt32(dr["id"]), (string)dr["name"], suffixes[0], suffixes[1], suffixes[2], Convert.ToDouble(dr["price"]), image, (bool)dr["stock"], lastModified);

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
                    query = "select * from ViewProductInfo WHERE category_id = @term ORDER BY id;";
                }
                else if (type == ProductSearchType.sub_category)
                {
                    query = "select * from ViewProductInfo WHERE sub_category_id = @term ORDER BY id;";
                }
                else
                {
                    query = $"select * from ViewProductInfo WHERE {type} LIKE '%{term}%' ORDER BY id;";
                }

                SqlCommand cmd = new SqlCommand(query, conn);

                if(type == ProductSearchType.category || type ==ProductSearchType.sub_category) cmd.Parameters.AddWithValue("@term", Convert.ToInt16(term) + 1);
                
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int productId = Convert.ToInt32(dr["id"]);
                        byte[]? image;
                        DateTime? lastModified;

                        if (dr["image"] != DBNull.Value) image = (byte[])dr["image"];
                        else image = null;
                        if (dr["last_modified"] != DBNull.Value) lastModified = (DateTime)dr["last_modified"];
                        else lastModified = null;

                        List<Suffix> suffixes = new List<Suffix>();
                        foreach (SuffixType typeS in Enum.GetValues(typeof(SuffixType)))
                        {
                            using (SqlConnection conns = new SqlConnection(connectionString))
                            {

                                conn.Open();
                                string sqls = "";

                                if (typeS == SuffixType.category)
                                {
                                     sqls = "select * from Category where id = @product_id;";
                                }
                                else if (typeS == SuffixType.sub_category)
                                {
                                    sqls = "select * from SubCategory where id = @product_id;";
                                }
                                else if (typeS == SuffixType.unit)
                                {
                                    sqls = "select * from Unit where id = @product_id;";
                                }
                                SqlCommand cmds = new SqlCommand(sqls, conns);

                                cmds.Parameters.AddWithValue("@product_id", productId);

                                SqlDataReader drs = cmd.ExecuteReader();

                                while (drs.Read())
                                {
                                    suffixes.Add(new(Convert.ToInt32(drs["id"]), (string)drs[$"{typeS}"], typeS));
                                }
                            }
                        }


                        Product product = new Product(Convert.ToInt32(dr["id"]), (string)dr["name"], suffixes[0], suffixes[1], suffixes[2], Convert.ToDouble(dr["price"]), image, (bool)dr["stock"], lastModified);
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

        public int InsertSuffix(Suffix suffix) 
        {
            string sql = "";
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                if (suffix.SuffixType == SuffixType.category)
                {
                    sql = "insert into Category (category) values (@cat); select SCOPE_IDENTITY();";
                }
                else if (suffix.SuffixType == SuffixType.sub_category)
                {
                    sql = "insert into SubCategory (sub_category) values (@subCat); select SCOPE_IDENTITY();";
                }
                else if (suffix.SuffixType == SuffixType.unit)
                {
                    sql = "insert into Unit (unit) values (@unit); select SCOPE_IDENTITY();";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", suffix.Name);
                cmd.Parameters.AddWithValue("@type", suffix.SuffixType.ToString());

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) id = Convert.ToInt32(dr[0]);
            }
            return id;
        }

        public List<Suffix> GetAllSuffixes() 
        {
            List<Suffix> suffixes = new List<Suffix>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                conn.Open();
                string sql = "select * from Category order by id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    suffixes.Add(new (Convert.ToInt32(dr["id"]), (string)dr["category"], SuffixType.category));
                }
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                string sql = "select * from SubCategory order by id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    suffixes.Add(new(Convert.ToInt32(dr["id"]), (string)dr["sub_category"], SuffixType.sub_category));
                }
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                string sql = "select * from Unit order by id;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    suffixes.Add(new(Convert.ToInt32(dr["id"]), (string)dr["unit"], SuffixType.unit));
                }
            }
            return suffixes;

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
