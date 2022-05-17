using System.Data.SqlClient;

namespace Dapper.Operations
{
    public class NoQueryOperation
    {
        private string _connString;
        public NoQueryOperation(string connString)
        {
            _connString = connString;
        }

        public void Execute()
        {
            // You can use this method, to insert, update and delete. You need only to change sql string.
            var sql = "insert into dbo.Students (Id, Name, Surname) values (1, 'Fabio', 'Test')";
            using (var connection = new SqlConnection(_connString))
            {
                var affectedRows = connection.Execute(sql);
            }
        }
    }
}
