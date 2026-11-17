using Microsoft.EntityFrameworkCore;

public class Entities(DbContextOptions<Entities> options) : DbContext(options)
{
    public DbSet<management.Models.Member> Member { get; set; } = default!;
}
