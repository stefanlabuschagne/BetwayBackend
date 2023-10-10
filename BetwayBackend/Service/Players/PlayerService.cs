using BetwayBackend.Models.Players;

namespace BetwayBackend.Service.Players
{
	/// <summary>
	/// Read this as a Table from a database (Another DI Implementation?) or Create a Collection Here In Future.
	/// </summary>
	///
	public class PlayerService : IPlayerService
	{
		private List<Player> _players = new List<Player>()
		{
			new Player()
			{
				Name = "Stefan",
				Email = "larper.lee@gmail.com",
				Password = "Syntax10"
			},
			new Player()
			{
				Name = "Harper",
				Email = "Harper.Lee@gmail.com",
				Password = "Syntax20"
			},
			new Player()
			{
				Name = "Susan",
				Email = "Susan.Lee@gmail.com",
				Password = "Syntax100"
			}
		};

		/// <summary>
		/// Return a Valid User
		/// </summary>
		/// <param name="name"></param>
		/// <param name="email"></param>
		/// <returns></returns>
		public Player GetPlayer(string email, string password)
		{
			return _players.FirstOrDefault(x => x.Email == email && x.Password ==password);
		}

		public List<Player> GetAllPlayers()
		{
			return _players;
		}
  }
}