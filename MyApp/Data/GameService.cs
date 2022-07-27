using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Data
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;
        private readonly NavigationManager _navigation;

        public GameService(DataContext context, NavigationManager navigation)
        {
            _context = context;
            _navigation = navigation;
        }
        public List<Games> Games { get; set; } = new List<Games>();

        public async Task AddGame(Games game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();
            _navigation.NavigateTo("videogames");
        }

        public async Task<Games> GetSingleGame(int id)
        {
            var game = await _context.Games.FindAsync(id);
            if (game == null)
                throw new Exception("Data Game Tidak Ada");
            return game;
        }

        public async Task LoadGames()
        {
            Games = await _context.Games.ToListAsync();
        }

        public async Task RemoveGame(int id)
        {
            var DbGame = await _context.Games.FindAsync(id);
            if (DbGame == null)
                throw new Exception("Data Game Tidak Ada");

            _context.Games.Remove(DbGame);
            await _context.SaveChangesAsync();
            _navigation.NavigateTo("videogames");
        }

        public async Task UpdateGame(Games game, int id)
        {
            var DbGame = await _context.Games.FindAsync(id);
            if (DbGame == null)
                throw new Exception("Data Game Tidak Ada");

            DbGame.Name = game.Name;
            DbGame.Developer = game.Developer;
            DbGame.Released = game.Released;

            await _context.SaveChangesAsync();
            _navigation.NavigateTo("videogames");
        }
    }
}
