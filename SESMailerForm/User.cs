using CsvHelper.Configuration;

namespace SESMailerForm
{
	public class User
	{
		[CsvField(Name = "email")]
		public string Email { get; set; }
	}
}