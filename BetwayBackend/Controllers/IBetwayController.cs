using BetwayBackend.Models.Appsettings;
using BetwayBackend.Models.Requests;
using BetwayBackend.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BetwayBackend.Controllers
{
	public interface IBetwayController
	{
		ActionResult<ApplicationSettingsGeneral> GetAppSettings();
		ActionResult<ApplicationSettingsCTALogin> GetCTALogin();
		ActionResult<LoginResponse> Post([FromBody] LoginRequest currentLoginRequest);
	}
}