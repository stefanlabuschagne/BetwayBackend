namespace BetwayBackend.Models.Requests
{
	public class LoginRequest : ILoginRequest
	{
		public string Email { get; set; } // Username

		public string Password { get; set; }
	}
}