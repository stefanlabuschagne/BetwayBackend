using BetwayBackend.Models.Appsettings;
using BetwayBackend.Service.AppSettings;

namespace BetwayBackend.Service.Appsettings
{
	public class AppsettingsServiceTest : IAppsettingsService
	{
		private ApplicationSettingsCTALogin _cTALoginAppsettings;
		private ApplicationSettingsGeneral _generalAppSettings;

		public AppsettingsServiceTest()
		{
			_cTALoginAppsettings = new ApplicationSettingsCTALogin
			{
				HeaderText = new string[] { "TESTLogin", "TESTNew customer?", "TESTRegister here" },

				FormFields = new string[] { "TESTUsername", "TESTPassword" },

				FooterText = new string[] { "TESTLogin", "TESTForgot Username/Password" },

				WelcomeUser = new string[] { "TESTSuccess", "TESTWelcome", "TESTContinue" },
			};

			_generalAppSettings = new ApplicationSettingsGeneral()
			{
				BannerOptions = new string[] { "TESTsports", "TESTlive & real", "TESTcasino", "TESTesports", "TESTvegas" },

				Login = "Login",

				SignUp = "Sign up",

				FooterLines = new string[] { "TESTSPORTS NEW CUSTOMER OFFER", "TESTGet up to $10 in Free Bets", "TESTJoin Now" },
			};
		}

		public ApplicationSettingsCTALogin CTALoginAppsettings
		{
			get => _cTALoginAppsettings;
		}

		public ApplicationSettingsGeneral GeneralAppSettings
		{
			get => _generalAppSettings;
		}
	}
}