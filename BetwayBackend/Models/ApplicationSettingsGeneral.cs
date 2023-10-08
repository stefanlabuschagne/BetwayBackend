namespace BetwayBackend.Models
{
	public class ApplicationSettingsGeneral
	{
		public string[] BannerOptions { get; set; } = { "sports", "live & real", "casino", "esports", "vegas" };

		public string Login { get; set; } = "Login";

		public string SignUp { get; set; } = "Sign up";

		public string[] FooterLines { get; set; } = { "SPORTS NEW CUSTOMER OFFER", "Get up to $10 in Free Bets", "Join Now" };
	}
}