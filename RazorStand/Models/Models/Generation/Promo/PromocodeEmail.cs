using VJeek.Fartsa.Emailing.Host.Models.Generation.Common;

namespace VJeek.Fartsa.Emailing.Host.Models.Generation.Promo
{
	public class PromocodeEmail : BaseTemplateModel
	{
		public Common.User User { get; set; }
		
		public Promoaction Promoaction { get; set; }
		
		public string Code { get; set; }
		
		public string Url { get; set; }
		public string Base64Url { get; set; }
		
		public override string BaseKey => "Promo";
		public override string TemplateKey => nameof(PromocodeEmail);
	}
}
