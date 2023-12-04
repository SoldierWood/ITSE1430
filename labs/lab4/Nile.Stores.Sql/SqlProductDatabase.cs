using System.Data;
using System.Data.SqlClient;


namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : ProductDatabase
    {

        public SqlProductDatabase (string connectionString){
            _connectionString = connectionString;
        }
        
        protected override Product GetCore ( int id )
        {
            using var conn = OpenConnection ();

            var cmd = new SqlCommand("GetProduct", conn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader ();
            while (reader.Read ())
            {
                return new Product() {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Description = reader.GetString("description"),
                    IsDiscontinued = reader.GetBoolean("isDiscontinued"),

                };
            };

            return null;
        }

        protected override IEnumerable<Product> GetAllCore ()
        {
            using var conn = OpenConnection();

            var ds = new DataSet();
            var da = new SqlDataAdapter() {
                SelectCommand = new SqlCommand("GetAllProducts", conn) {  CommandType = CommandType.StoredProcedure }
            };

            da.Fill(ds);

            var products = new List<Product>();

            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
            if (table != null)
            {
                foreach ( var row in table.Rows.OfType<DataRow>())
                {
                    products.Add(new Product() {
                        Id = Convert.ToInt32(row["id"]),
                        Name = row.Field<string>("name"),
                        Price = row.Field<decimal>("price"),
                        Description = row.IsNull("description") ? "" : row.Field<string>("description"),
                        IsDiscontinued = row.Field<bool>("isDiscontinued"),
                    }); ; ;
                };
            };

            return products;
        }

        protected override void RemoveCore ( int id )
        {
            using var conn = OpenConnection ();
            var cmd = new SqlCommand("RemoveProduct", conn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
        
        protected override Product UpdateCore ( Product existing, Product newItem )
        {
            using var conn = OpenConnection();

            var cmd = new SqlCommand("UpdateProduct", conn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@id", newItem.Id);
            cmd.Parameters.AddWithValue("@name", newItem.Name);
            cmd.Parameters.AddWithValue("@price", newItem.Price);
            cmd.Parameters.AddWithValue("@description", newItem.Description);
            cmd.Parameters.AddWithValue("@isDiscontinued", newItem.IsDiscontinued);

            cmd.ExecuteScalar();
            
            return newItem;

        }

        protected override Product AddCore ( Product product )
        {
            using var conn = OpenConnection ( );

            var cmd = new SqlCommand("AddProduct", conn) { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@description", product.Description);
            cmd.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);

            product.Id = Convert.ToInt32(cmd.ExecuteScalar());

            return product;
        }

        private SqlConnection OpenConnection()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open ();

            return conn;
        }

        private readonly string _connectionString;
    }
}