namespace Uygulama.Models;

using Microsoft.EntityFrameworkCore;

public class StoreDbContext : DbContext {
	public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
	public DbSet<DavetiyeCevabi> DavetiyeCevaplari => Set<DavetiyeCevabi>();
}