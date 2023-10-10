using BetwayBackend.Models;
using BetwayBackend.Models.Requests;
using BetwayBackend.Models.Responses;
using BetwayBackend.Service.Players;
using Microsoft.AspNetCore.Mvc;

namespace BetwayBackend.Controllers
{
  /// <summary>
  ///
  /// </summary>
	[Route("api/[controller]")]
	[ApiController]
	public class BetwayController : ControllerBase
	{

		private IPlayerService _playerService;
		private ILogger _logger;

		// Controller Constructor
		public BetwayController(ILogger<BetwayController> daLogger, IPlayerService daPlayerService)
		{
			_logger = daLogger;
			_playerService = daPlayerService;
		}

		[HttpPost("Login")]
		public ActionResult<LoginResponse> Post([FromBody] LoginRequest currentLoginRequest)
		{
			if (currentLoginRequest == null)
			{
				return new BadRequestObjectResult
					(new LoginResponse()
						{
							Status = "Fail",
							Message = "Invalid Payload"
						}
					);
			}

			var validPlayer = _playerService.GetPlayer(currentLoginRequest.Email, currentLoginRequest.Password);

			// Validation against the Injected Details of a valid user.
			if (validPlayer == null)
			{
				return new OkObjectResult(new LoginResponse()
				{
					Status = "Success",
					Message = validPlayer.Name
				});
			}
			else
			{
				return new BadRequestObjectResult(new LoginResponse()
				{
					Status = "Fail",
					Message = "Invalid Credentials"
				});
			}
		}

		[HttpGet("Settings/App")]
		public ActionResult<ApplicationSettingsGeneral> GetAppSettings()
		{
			return new OkObjectResult(new ApplicationSettingsGeneral());
		}

		[HttpGet("Settings/CTALogin")]
		public ActionResult<ApplicationSettingsCTALogin> GetCTALogin()
		{
			return new OkObjectResult(new ApplicationSettingsCTALogin());
		}
	}
}