namespace VJeek.Fartsa.Emailing.Host.Models.Generation
{
	public abstract class BaseTemplateModel : ITemplateModel
	{
		public abstract string BaseKey { get; }

		public abstract string TemplateKey { get; }
	}
}