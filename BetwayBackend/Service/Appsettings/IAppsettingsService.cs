using BetwayBackend.Models.Appsettings;

namespace BetwayBackend.Service.AppSettings
{
	public interface IAppsettingsService
	{
		public ApplicationSettingsCTALogin GetCTALoginAppsettings();

		public ApplicationSettingsGeneral GetGeneralAppSettings();
	}
}
