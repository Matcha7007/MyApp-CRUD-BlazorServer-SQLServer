namespace MyApp.Data
{
    public interface IGameService
    {
        List<Games> Games { get; set; }
        Task LoadGames();
        Task<Games> GetSingleGame(int id);
        Task AddGame(Games game);
        Task RemoveGame(int id);
        Task UpdateGame(Games game, int id);
    }
}
