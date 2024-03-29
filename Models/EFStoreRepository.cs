namespace Uygulama.Models;

public class EFStoreRepository : IStoreRepository {
	private StoreDbContext context;
	public EFStoreRepository(StoreDbContext ctx) {
		context = ctx;
	}
	public IQueryable<DavetiyeCevabi> DavetiyeCevaplari => context.DavetiyeCevaplari;
}