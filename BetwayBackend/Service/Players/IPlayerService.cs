using BetwayBackend.Models.Players;

namespace BetwayBackend.Service.Players
{
	public interface IPlayerService
	{
		List<Player> GetAllPlayers();

		Player GetPlayer(string email, string password);
	}
}