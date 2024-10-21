namespace RazorStand;

public class MailConfigOptions
{
	public const string Key = "MailConfig";
	
	public string PartnerMail { get; set; }
	
	public string SupportMail { get; set; }
	public string PublicMail { get; set; }
	
	public string UsersRemovalServiceMail { get; set; }
	
	public string LogoUrl { get; set; }
	
	public string ProjectName { get; set; }
}