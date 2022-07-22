namespace Dapper.Tests.Performance;

[LinqToDB.Mapping.Table(Name = "RoomImages")]
public class RoomImage
{
    [LinqToDB.Mapping.PrimaryKey, LinqToDB.Mapping.Identity]
    public int Id { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public string Name { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public byte[] Photo { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public bool IsHighlighted { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public short OrderNumber { get;  set; }
    [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
    public int RoomId { get;  set; }
}
