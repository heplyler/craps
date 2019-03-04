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
    public partial class GameView : Form
    {
        public GameView(Game game)
        {
            InitializeComponent();
            pointLbl.Text += game.points.ToString();
            resultLbl.Text += game.winStr;
            rollSumLbl.Text += string.Join(",", game.sumArray.Select(n => Convert.ToString(n)).ToArray());
        }
    }
}
