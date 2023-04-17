using BetwayBackend.Models;
using BetwayBackend.Models.Requests;
using BetwayBackend.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BetwayBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetwayController : ControllerBase
    {

        [HttpPost("Login")]
        public ActionResult<LoginResponse> Post([FromBody] LoginRequest currentLoginRequest)
        {

            if (currentLoginRequest == null)
            {
                return new BadRequestObjectResult
                    ( new LoginResponse()
                        {
                            Status = "Fail",
                            Message = "Invalid Payload"
                        }
                    );
            }

            // Hardcoded validation :(
            if ((currentLoginRequest.email.ToLower() == "harper.lee@gmail.com") && (currentLoginRequest.password == "Syntax-10"))
            {
                return new OkObjectResult(new LoginResponse()
                    {
                        Status = "Success",
                        Message = "Stefan"
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
