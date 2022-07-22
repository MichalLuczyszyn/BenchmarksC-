using LinqToDB;
using Microsoft.EntityFrameworkCore;

namespace Dapper.Tests.Performance.Linq2Db
{
    public class Linq2DBContext : LinqToDB.Data.DataConnection
    {
        public ITable<Post> Posts  { get; set; }
        public ITable<StudentHouseImage> StudentHouseImages  { get; set; }
        public ITable<Segment> Segments  { get; set; }
        public ITable<Room> Rooms  { get; set; }
        public ITable<RoomImage> RoomImages { get; set; }
    }
}
