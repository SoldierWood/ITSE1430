using System.Data;
using System.Data.SqlClient;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : ProductDatabase
    {
        protected override Product GetCore ( int id );

        protected override IEnumerable<Product> GetAllCore ();

        protected override void RemoveCore ( int id )
        {

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