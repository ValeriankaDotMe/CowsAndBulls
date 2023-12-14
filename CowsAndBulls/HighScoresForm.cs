using CowsAndBulls.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CowsAndBulls
{
    public partial class HighScoresForm : Form
    {
        public HighScoresForm()
        {
            InitializeComponent();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            foreach (var player in PlayerBase.GetPlayerBase().OrderByDescending(p => p.HighScore))
            {
                highScoresLog.AppendText(String.Format("- Player: {0}. Games played: {1}. Highscore: {2}\r\n",
                    player.Username,
                    player.GamesPlayed,
                    player.HighScore));
            }
        }
    }
}
