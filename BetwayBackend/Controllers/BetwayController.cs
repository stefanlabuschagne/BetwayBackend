using BetwayBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BetwayBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetwayController : ControllerBase
    {

        [HttpPost(Name = "Login")]
        public ActionResult<LoginResponse> Post([FromBody] LoginRequest currentLoginRequest)
        {

            if (currentLoginRequest == null)
            {
                return new LoginResponse()
                {
                    Status = "Fail",
                    Message = "Invalid Payload"
                };
            }

            if ((currentLoginRequest.email == "harper.lee@gmail.com") && (currentLoginRequest.password == "Syntax-10"))
            {
                return new LoginResponse()
                {
                    Status = "Success",
                    Message = "Stefan"
                };
            }
            else 
            {
                return new LoginResponse()
                {
                    Status = "Fail",
                    Message = "Invalid credentials"
                };
            }
        }

        [HttpGet(Name = "AppSettings")]
        public ActionResult<ApplicationSettingsGeneral> Get()
        {
            
            return new OkObjectResult(new ApplicationSettingsGeneral());
        }
    }
}
