namespace Uygulama.Models;

public interface IStoreRepository {
	IQueryable<DavetiyeCevabi> DavetiyeCevaplari { get; }
}