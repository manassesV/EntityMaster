using EntityMaster.EntityConfigurations;
using Microsoft.EntityFrameworkCore;


namespace EntityMaster
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }

        public DbSet<Blog> Blogs {  get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<Driver> Drivers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlogConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TagsConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DriverConfiguration).Assembly);

        }
    }
}
