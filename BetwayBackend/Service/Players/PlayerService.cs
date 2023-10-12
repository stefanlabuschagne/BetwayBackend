using BetwayBackend.Models.Players;

namespace BetwayBackend.Service.Players
{
	/// <summary>
	/// Read this as a Table from a database (Another DI Implementation?) or Create a Collection Here In Future.
	/// </summary>
	///
	public class PlayerService : IPlayerService
	// : IPlayerService
	{
		private List<Player> _players;

		// constructor
		public PlayerService()
		{
			_players = new List<Player>()
			{
				new Player()
				{
					Name = "Stefan",
					Email = "larper.lee@gmail.com",
					Password = "Syntax10",
				},
				new Player()
				{
					Name = "Harper",
					Email = "Harper.Lee@gmail.com",
					Password = "Syntax20",
				},
				new Player()
				{
					Name = "Susan",
					Email = "Susan.Lee@gmail.com",
					Password = "Syntax100",
				}
			};
		}

		public Player GetPlayer(string email, string password) => _players.FirstOrDefault(x => x.Email == email && x.Password == password);

		public List<Player> GetAllPlayers() => _players;
	}
}