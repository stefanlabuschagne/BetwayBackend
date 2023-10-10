using BetwayBackend.Models.Appsettings;
using BetwayBackend.Service.AppSettings;

namespace BetwayBackend.Service.Appsettings
{
	public class AppsettingsService : IAppsettingsService
	{
		public AppsettingsService()
		{
		}

		public ApplicationSettingsCTALogin GetCTALoginAppsettings() => new ApplicationSettingsCTALogin
		{
			HeaderText = new string[] { "Login", "New customer?", "Register here" },

			FormFields = new string[] { "Username", "Password" },

			FooterText = new string[] { "Login", "Forgot Username/Password" },

			WelcomeUser = new string[] { "Success", "Welcome", "Continue" }
		};

		public ApplicationSettingsGeneral GetGeneralAppSettings() => new ApplicationSettingsGeneral()
		{
			BannerOptions = new string[] { "sports", "live & real", "casino", "esports", "vegas" },

			Login = "Login",

			SignUp = "Sign up",

			FooterLines = new string[] { "SPORTS NEW CUSTOMER OFFER", "Get up to $10 in Free Bets", "Join Now" }
		};
	}
}