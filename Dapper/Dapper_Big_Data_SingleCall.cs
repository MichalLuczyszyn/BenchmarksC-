using System.ComponentModel;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Dapper.Tests.Performance;

[SimpleJob(RuntimeMoniker.Net60)]
[MemoryDiagnoser]
[CsvExporter]
[Description("Dapper")]
public class Dapper_Big_Data_SingleCall
{
    private const string connectionString = "Server=localhost;Database=Studentaza;Trusted_Connection=True;";
    protected SqlConnection _connection;
    
    [Params(10, 100)]
    public int N;

    [GlobalSetup]
    public void Setup()
    {
        _connection = new SqlConnection(connectionString);
        _connection.Open();
    }

    [Benchmark(Description = "QueryFirstOrDefault<T>")]
    public RoomImage QueryFirstOrDefault()
    {
        return _connection.QueryFirstOrDefault<RoomImage>("select * from RoomImages where Id = @Id", new { Id = N });
    }
        
    [Benchmark(Description = "QueryFirstOrDefault<dynamic>")]
    public dynamic QueryFirstOrDefaultDynamic()
    {
        return _connection.QueryFirstOrDefault("select * from RoomImages where Id = @Id", new { Id = N }).First();
    }
        
    [Benchmark(Description = "Contrib Get<T>")]
    public RoomImage ContribGet()
    {
        return _connection.Get<RoomImage>(N);
    }
}