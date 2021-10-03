namespace ServerARM.Context
{
    using Microsoft.EntityFrameworkCore;
    using ServerARM.Models;
    public class MainContext : DbContext
    {
        public string schema { get; set; } = "arm";
        public DbSet<Group> Groups { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemSemestr> ItemSemestrs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Semestr> Semestrs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>()
                .ToTable("Group", schema);
            modelBuilder.Entity<Item>()
                .ToTable("Item", schema);
            modelBuilder.Entity<ItemSemestr>()
                .ToTable("ItemSemestr", schema);
            modelBuilder.Entity<Role>()
                .ToTable("Role", schema);
            modelBuilder.Entity<Semestr>()
                .ToTable("Semestr", schema);
            modelBuilder.Entity<User>()
                .ToTable("User", schema);
        }
    }
}
