namespace VJeek.Fartsa.Emailing.Host.Models.Generation
{
	public interface ITemplateModel
	{
		string BaseKey { get; }
		
		string TemplateKey { get; }
	}
}