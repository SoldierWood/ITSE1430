using System.Data;
using System.Data.SqlClient;


namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : ProductDatabase
    {

        public SqlProductDatabase (string connectionString){
            _connectionString = connectionString;
        }
        
        protected override Product GetCore ( int id );

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
                        id = Convert.ToInt32(row["id"]),
                        row.Field<string>("name"),
                        row.Field<decimal>("price"),
                        description = row.IsNull("description") ? "" : row.Field<string>("description"),
                        isDiscontinued = row.Field<bool>("isDiscontinued"),
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
        
        protected override Product UpdateCore ( Product existing, Product newItem );

        protected override Product AddCore ( Product product );

        private SqlConnection OpenConnection()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open ();

            return conn;
        }

        private readonly string _connectionString;
    }
}