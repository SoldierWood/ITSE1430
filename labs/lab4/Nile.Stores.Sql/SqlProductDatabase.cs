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

                    }); ; ;
                };
            };
        }

        protected override void RemoveCore ( int id );
        
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