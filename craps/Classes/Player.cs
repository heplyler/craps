using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace craps
{
    public class Player
    {
        List<Game> games = new List<Game>();
        public int wins = 0;
        public int loses = 0;
        public int winRate = 0;
        public int totalGames = 0;

        public string Username { get; internal set; }

        public void AddGame(Game game)
        {
            games.Add(game);
            if(game.won == 1)
            {
                wins++;  
            }
            else
            {
                loses++;
            }
            totalGames++;
            GetWinRate();
        }

        public void AddDatabaseGame(Game game)
        {
            games.Add(game);
        }

        internal void GetWinRate()
        {
            winRate = (int)Math.Round((double)(100 * wins) / totalGames);
        }
    }
}
