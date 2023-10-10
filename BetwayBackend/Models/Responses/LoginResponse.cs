namespace BetwayBackend.Models.Responses
{
	/// <summary>
	///
	/// </summary>
	public class LoginResponse : ILoginResponse
	{
		public string Status { get; set; } // Sucsess / Failed

		public string Message { get; set; } // Welcome or Error Message
	}
}