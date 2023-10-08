using BetwayBackend.Models;
using BetwayBackend.Models.Players;
using BetwayBackend.Models.Requests;
using BetwayBackend.Models.Responses;
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

		private IPlayer _validPlayer;
		private ILogger _logger;

		// Controller Constructor
		public BetwayController(ILogger<BetwayController> daLogger, IPlayer daPlayer)
		{
			_logger = daLogger;
			_validPlayer = daPlayer;
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

			// Validation against the Injected Details of a valid user.
			if ((currentLoginRequest.Email.ToLower() == _validPlayer.Email.ToLower()) && (currentLoginRequest.Password == _validPlayer.Password))
			{
				return new OkObjectResult(new LoginResponse()
				{
					Status = "Success",
					Message = _validPlayer.Name
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