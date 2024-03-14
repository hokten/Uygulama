namespace Uygulama.Models;

public static class Repository {
	private static List<DavetiyeCevabi> cevaplar = new();
	public static IEnumerable<DavetiyeCevabi> Cevaplar => cevaplar;
	public static void cevapEkle(DavetiyeCevabi cvp) {
		Console.WriteLine(cvp);
		cevaplar.Add(cvp);
	}
}