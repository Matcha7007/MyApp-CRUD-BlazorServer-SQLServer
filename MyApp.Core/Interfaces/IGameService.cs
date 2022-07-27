using MyApp.Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Interfaces
{
    public interface IGameService
    {
        List<Game> Games { get; set; }
        Task LoadGames();
        Task<Game> GetSingleGame(int id);
        Task AddGame(Game game);
        Task RemoveGame(int id);
        Task UpdateGame(Game game, int id);
    }
}
