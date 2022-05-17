using DapperExample.Model;
using System.Data.SqlClient;
using System.Linq;

namespace Dapper.CRUD
{
    public class SelectOperation
    {
        private string _connString;
        public SelectOperation(string connString)
        {
            _connString = connString;
        }

        public int GetScalar()
        {
            using (var connection = new SqlConnection(_connString))
            {
                var sql = "select count(*) from dbo.Students";
                var count = connection.ExecuteScalar<int>(sql);
                return count;
            }
        }

        public Student GetSingleRow(int id)
        {
            using (var connection = new SqlConnection(_connString))
            {
                var sql = $"select Id, Name, Surname from dbo.Students where Id = {id}";
                return connection.QuerySingle<Student>(sql);
            }
        }

        public Student[] GetMultiRow(int id)
        {
            using (var connection = new SqlConnection(_connString))
            {
                var sql = $"select Id, Name, Surname from dbo.Students";
                var students =  connection.Query<Student>(sql);

                return students.ToArray();
            }
        }

        public Student GetWithParams(int id)
        {
            var parameters = new { Id = id};
            var sql = "select * from dbo.Students where Id = @Id";

            using (var connection = new SqlConnection(_connString))
            {
                return connection.QuerySingle<Student>(sql, parameters);
            }
        }
    }
}
