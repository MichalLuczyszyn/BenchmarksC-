using System;

namespace Dapper.Tests.Performance
{
    [LinqToDB.Mapping.Table(Name = "StudentHouseImages")]
    public class StudentHouseImage
    {        
        [LinqToDB.Mapping.PrimaryKey, LinqToDB.Mapping.Identity]
        public int Id { get;  set; }
        [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
        public string Name { get;  set; }
        [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
        public byte[] Image { get;  set; }
        [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
        public bool IsHighlighted { get;  set; }
        [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
        public short OrderNumber { get;  set; }
        [LinqToDB.Mapping.Column, LinqToDB.Mapping.NotNull]
        public int StudentHouseId { get;  set; }
    }
}
