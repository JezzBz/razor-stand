namespace VJeek.Fartsa.Emailing.Host.Models.Generation.User
{
	public class EmailConfirmation : BaseTemplateModel
	{
		public Common.User User { get; set; }
		
		public string ConfirmationUrl { get; set; }
		
		public string Code { get; set; }
		
		public override string BaseKey => "User";
		public override string TemplateKey => nameof(EmailConfirmation);
	}
}