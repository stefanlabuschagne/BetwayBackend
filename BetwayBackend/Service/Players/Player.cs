namespace BetwayBackend.Service.Players
{
	/// <summary>
	/// Read this as a Table from a database or Create a Collection Here In Future.
	/// </summary>
  public class Player : IPlayer
  {
    public string Name
    {
			get => "Stefan";
    }

    public string Email
    {
			get => "larper.lee@gmail.com";
    }

    public string Password
    {
			get => "Syntax10";
    }
  }
}