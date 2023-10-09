namespace BetwayBackend.Service.Players
{
    public interface IPlayer
    {
        string Name { get; }
        string Email { get; }
        string Password { get; }
    }
}
