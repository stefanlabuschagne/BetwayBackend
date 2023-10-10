using BetwayBackend.Models.Players;

namespace BetwayBackend.Service.Players
{
	public interface IPlayerService
	{
		public Player GetPlayer(string name, string email);

		public List<Player> GetAllPlayers();
	}
}