using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using craps.Database;

namespace craps
{
    public partial class Craps : Form
    {
        // this is an instance of the Azure sql database class that 
        // I've made to abstract out some of the complexity.
        AzureSqlDatabase azureSqlDatabase = new AzureSqlDatabase();
        List<Game> games;
        List<Player> players;
        Game currentGame = new Game();
        Player currentPlayer = new Player(); 

        // here we are initializing. We need a player (or we cannot play
       // so this form requires a player to open.
        public Craps(Player p)
        {
            InitializeComponent();
            currentPlayer = p;
            usernameLbl.Text = p.Username;

            // here we are populating the history.
            games = azureSqlDatabase.GetGamesByUsername(p.Username);
            for (var i = 0; i < games.Count; i++)
            {
                AddToHistoryGrid(i + 1, games[i].won);
            }

            // here we are populating the other users.
            players = azureSqlDatabase.GetPlayers();
            for (var i = 0; i < players.Count; i++)
            {
                AddToPlayerGrid(players[i].Username);
            }
        }

        // here's a helper method to set dice text.
        private void SetDiceText(int diceOne, int diceTwo)
        {
            diceOneTxt.Text = diceOne.ToString();
            diceTwoTxt.Text = diceTwo.ToString();
        }

      
        // this is the function that is fired when users click 'roll'
        private void rollBtn_Click(object sender, EventArgs e)
        {
            // here we are going to use the api requested to get a json object, get the value then play the game.
            currentGame.Play();
            SetDiceText(currentGame.currentRoll.diceOne, 
                currentGame.currentRoll.diceTwo);

            // after currentGame.play() we can decide the result.
            if (currentGame.won == 1)
            {
                NewGame("you WON!");
                currentGame.winStr = "Win";
                
            }
            else if (currentGame.won == 2)
            {
                NewGame("You LOST!");
                currentGame.winStr = "Lose";
               
            }
            else
            {
                if (currentGame.count == 1)
                {
                    pointTxt.Text = currentGame.points.ToString();
                }

                currentGameGrid.Rows.Add(currentGame.count.ToString(),
                   currentGame.currentRoll.diceOne.ToString(),
                   currentGame.currentRoll.diceTwo.ToString(),
                   currentGame.points.ToString());
            }

        }

        // here is the function that resets anything we need to
        // reset at the begining of a new game.
        public void NewGame(string message)
        {
            MessageBox.Show(message + currentGame.message);
            currentPlayer.AddGame(currentGame);
            games.Add(currentGame);
            winRateTxt.Text = (currentPlayer.winRate).ToString() + "%";
            currentGame.GetSums();
            azureSqlDatabase.SaveGame(currentPlayer.Username, currentGame.sumArray, currentGame.points, currentGame.resultMessage);
            AddToHistoryGrid(currentPlayer.totalGames, currentGame.won);
            currentGame = new Game();
            currentGameGrid.Rows.Clear();
            pointTxt.Text = "0";
            diceOneTxt.Text = "0";
            diceTwoTxt.Text = "0";
        }

        // if you want to reset game manually you can reset.
        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            NewGame("NEW GAME!");
        }

        // here you can logout of the game.
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }

        // here is afunction that adds to the history grid.
        private void AddToHistoryGrid(int gameNumer, int won)
        {
            Color backgroundColor = Color.White;
            string resultStr = "Neither";
            if (won == 1) { resultStr = "Won"; backgroundColor = Color.Green; }
            else if (won == 2) { resultStr = "Lost"; backgroundColor = Color.Red; }
            historyGrid.Rows.Add(gameNumer.ToString(), resultStr);
            historyGrid.Rows[historyGrid.Rows.Count - 2].DefaultCellStyle.BackColor = backgroundColor;
        }

        // this one adds to the user datagrid view.
        private void AddToPlayerGrid(string Username)
        {
            userselectGrid.Rows.Add(Username);
        }

       // this is the button that deletes the current user.
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            azureSqlDatabase.DeleteUser(usernameLbl.Text);
            login loginBox = new login();
            loginBox.Show();
            this.Close();
        }

        // this button once clicked clears the history.
        private void deleteHistoryBtn_Click(object sender, EventArgs e)
        {
            historyGrid.Rows.Clear();
            azureSqlDatabase.DeleteUserHistory(currentPlayer.Username);
        }

        // this allows you to look at other users data.
        private void userselectGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string passUsername = userselectGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            UserView userView = new UserView(passUsername);
            userView.Show();
        }

        private void userselectGrid_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void historyGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(games.Count > e.RowIndex)
            {
                Game passGame = games[e.RowIndex];
                GameView gameView = new GameView(passGame);
                gameView.Show();
            } 
        }
    }
}
