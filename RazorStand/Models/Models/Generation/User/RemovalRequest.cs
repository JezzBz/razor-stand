namespace VJeek.Fartsa.Emailing.Host.Models.Generation.User;

public class RemovalRequest : BaseTemplateModel
{
	public long UserId { get; set; }

	public string Name { get; set; }
	
	public string Surname { get; set; }
	
	public override string BaseKey => "User";
	public override string TemplateKey => nameof(RemovalRequest);
}
