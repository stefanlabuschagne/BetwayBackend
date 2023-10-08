namespace BetwayBackend.Models.Requests
{
	public interface ILoginRequest
	{
		string Email { get; set; }
		string Password { get; set; }
	}
}