using Microsoft.EntityFrameworkCore;

namespace EfCorePowertools.Data;

internal sealed class TestContext : DbContext
{
    public TestContext()
    { }

    public TestContext(DbContextOptions<TestContext> options) : base(options)
    { }

    public DbSet<Blog> Blogs { get; set; } = null!;

    public DbSet<Post> Posts { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=.");
        }
    }
}