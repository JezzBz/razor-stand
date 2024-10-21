using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VJeek.Fartsa.Emailing.Host.Models.Generation.User;
public class StatusingResult : BaseTemplateModel
{
	public required Common.User User { get; set; }
	public required bool Success { get; set; }
	
	public string Url { get; set; }
	
	public required string Message { get; set; }

	public override string BaseKey => "User";

	public override string TemplateKey => nameof(StatusingResult);
}
