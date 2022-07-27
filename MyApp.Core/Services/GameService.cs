using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

using MyApp.Core.Data;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Services
{
    public class GameService : IGameService
    {
        private readonly MyAppDataContext _context;
        private readonly NavigationManager _navigation;

        public GameService(MyAppDataContext context, NavigationManager navigation)
        {
            _context = context;
            _navigation = navigation;
        }
        public List<Game> Games { get; set; } = new List<Game>();

        public async Task AddGame(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();
            _navigation.NavigateTo("videogames");
        }

        public async Task<Game> GetSingleGame(int id)
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

        public async Task UpdateGame(Game game, int id)
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
