using craps.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace craps
{
    public partial class UserView : Form
    {
        AzureSqlDatabase azureSqlDatabase = new AzureSqlDatabase();
        List<Game> games;
        public UserView(string usernameStr)
        {
            InitializeComponent();
            username.Text = usernameStr;
            games = azureSqlDatabase.GetGamesByUsername(usernameStr);

            for (var i = 0; i < games.Count; i++)
            {
                AddToHistoryGrid(i + 1, games[i].won);
            }
        }

        private void AddToHistoryGrid(int gameNumer, int won)
        {
            Color backgroundColor = Color.White;

            string resultStr = "Neither";
            if (won == 1) { resultStr = "Won"; backgroundColor = Color.Green; }
            else if (won == 2) { resultStr = "Lost"; backgroundColor = Color.Red; }
            historyGrid.Rows.Add(gameNumer.ToString(), resultStr);
            historyGrid.Rows[historyGrid.Rows.Count - 2].DefaultCellStyle.BackColor = backgroundColor;
        }

        private void historyGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (games.Count > e.RowIndex)
            {
                Game passGame = games[e.RowIndex];
                GameView gameView = new GameView(passGame);
                gameView.Show();
            }
        }
    }
}
