using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using Dapper;
public class Connect
{
    private readonly string _connectionString;
    public Connect(IConfiguration configuration)
    {
        if (configuration != null)
        {
            _connectionString = configuration.GetConnectionString("ApplicationSettingDb");
        }
    }
    public IEnumerable<T> Query<T>(string sql, object param = null)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            return connection.Query<T>(sql, param);
        }
    }
    public int Execute(string sql, object param = null)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            return connection.Execute(sql, param);
        }
    }
}