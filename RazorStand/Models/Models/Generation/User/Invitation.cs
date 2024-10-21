namespace VJeek.Fartsa.Emailing.Host.Models.Generation.User;

public class Invitation : BaseTemplateModel
{
		
	public string PromoactionTitle { get; set; }
	
	public string Link { get; set; }
	
	public string BusinessName { get; set; }
	
	public override string BaseKey  => "User";
	
	public override string TemplateKey => nameof(Invitation);
}
