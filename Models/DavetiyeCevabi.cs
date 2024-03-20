namespace Uygulama.Models;

using System.ComponentModel.DataAnnotations;

public class DavetiyeCevabi
{
	[Required(ErrorMessage="Adı soyadı alanına bir veri girmelisiniz.")]
	public string? AdiSoyadi { get; set; }
	
	[Required(ErrorMessage="E-Posta alanına bir veri girmelisiniz.")]
	[EmailAdress]
	public string? EPosta { get; set; }
	
	[Required(ErrorMessage="Telefon alanına bir veri girmelisiniz.")]
	public string? Telefon { get; set; }
	
	[Required(ErrorMessage="Katılım durumunu belirtmelisiniz.")]
	public bool? KatilimDurumu { get; set; }

}
