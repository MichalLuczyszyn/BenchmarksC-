using Microsoft.EntityFrameworkCore;

namespace Dapper.Tests.Performance.EntityFrameworkCore
{
    public class EFCoreContext : DbContext
    {
        private readonly string _connectionString;

        public EFCoreContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(_connectionString);

        public DbSet<Post> Posts { get; set; }
        public DbSet<StudentHouseImage> StudentHouseImages { get; set; }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomImage> RoomImages { get; set; }
    }
}
