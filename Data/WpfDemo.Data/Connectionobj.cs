using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Configuration;

namespace WpfDemo.Data
{
    public class Connectionobj
    {
        public static IDbConnection GetOpenConnection()
        {
            IDbConnection connection;

            connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["demo"].ConnectionString);
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLite);

            connection.Open();

            return connection;

        }
    }
}
