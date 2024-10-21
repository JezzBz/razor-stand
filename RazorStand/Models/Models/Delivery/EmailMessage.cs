using System.Collections.Generic;

namespace VJeek.Fartsa.Emailing.Host.Models.Delivery
{
	public class EmailMessage
	{
		public IEnumerable<MailAddress> Tos { get; set; }
		
		public IEnumerable<MailAddress> CCs { get; set; }
		
		public IEnumerable<MailAddress> BCCs { get; set; }
		
		public MailAddress From { get; set; }
		
		public string Body { get; set; }
		
		public string Subject { get; set; }
	}
}