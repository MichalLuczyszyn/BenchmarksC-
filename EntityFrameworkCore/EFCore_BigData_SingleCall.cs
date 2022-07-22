using System.ComponentModel;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using Dapper.Tests.Performance.EntityFrameworkCore;
using Dapper.Tests.Performance.Helpers;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Dapper.Tests.Performance;

[SimpleJob(RuntimeMoniker.Net60)]
[Description("EF Core")]
public class EFCore_BigData_SingleCall
{
    private const string connectionString = "Server=localhost;Database=Studentaza;Trusted_Connection=True;";

    private EFCoreContext Context;

    private static readonly Func<EFCoreContext, int, RoomImage> compiledQuery =
        EF.CompileQuery((EFCoreContext ctx, int id) => ctx.RoomImages.First(p => p.Id == id));

    [Params(10, 100)] public int N;

    [GlobalSetup]
    public void Setup()
    {
        Context = new EFCoreContext(connectionString);
    }

    [Benchmark(Description = "First")]
    public void First()
    {
        Context.RoomImages.First(p => p.Id == N);
    }


    [Benchmark(Description = "First (Compiled)")]
    public void Compiled()
    {
        compiledQuery(Context, N);
    }


    [Benchmark(Description = "SqlQuery")]
    public void SqlQuery()
    {
        Context.RoomImages.FromSqlRaw("select * from RoomImages where Id = {0}", N).First();
    }


    [Benchmark(Description = "First (No Tracking)")]
    public void NoTracking()
    {
        Context.RoomImages.AsNoTracking().First(x => x.Id == N);
    }
}