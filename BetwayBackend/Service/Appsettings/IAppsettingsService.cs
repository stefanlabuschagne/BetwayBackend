using BetwayBackend.Models.Appsettings;

namespace BetwayBackend.Service.AppSettings
{
	public interface IAppsettingsService
	{
		ApplicationSettingsCTALogin CTALoginAppsettings { get; }
		ApplicationSettingsGeneral GeneralAppSettings { get; }
	}
}
