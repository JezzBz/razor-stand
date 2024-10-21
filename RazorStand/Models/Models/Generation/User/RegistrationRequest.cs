namespace VJeek.Fartsa.Emailing.Host.Models.Generation.User;

public class RegistrationRequest : BaseTemplateModel
{
	public Common.User User { get; set; }
	public override string BaseKey  => "User";
	public override string TemplateKey => nameof(RegistrationRequest);
}
