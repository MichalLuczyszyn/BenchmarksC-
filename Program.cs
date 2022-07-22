using BenchmarkDotNet.Running;
using Dapper.Tests.Performance;

public class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<Dapper_Big_Data_SingleCall>(new Config());
        BenchmarkRunner.Run<EFCore_BigData_SingleCall>(new Config());
    }
}
