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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            chosenDifficulty.SelectedItem = "Normal";
            descriptionBox.Text = DescriptionBase.NormalDescription;
        }

        private void chosenDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (chosenDifficulty.Text)
            {
                case "Normal":
                    descriptionBox.Text = DescriptionBase.NormalDescription;
                    break;
                case "Hard":
                    descriptionBox.Text = DescriptionBase.HardDescription;
                    break;
                default:
                    break;
            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            string username;

            if (usernameTextbox.Text.Length == 0)
            {
                //set default username
                username = "Guest";
            }
            else
            {
                username = usernameTextbox.Text;
            }

            var gameForm = new GameForm(chosenDifficulty.SelectedItem.ToString(), username);
            gameForm.Location = this.Location;
            gameForm.StartPosition = FormStartPosition.Manual;
            gameForm.FormClosing += delegate { this.Show(); };
            gameForm.Show();
            this.Hide();
        }

        private void highScoresBtn_Click(object sender, EventArgs e)
        {
            var highScoresForm = new HighScoresForm();
            highScoresForm.Location = this.Location;
            highScoresForm.StartPosition = FormStartPosition.Manual;
            highScoresForm.FormClosing += delegate { this.Show(); };
            highScoresForm.Show();
            this.Hide();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosed(EventArgs e)
        {
            PlayerBase.SerializePlayerBase();
            Application.Exit();
        }
    }
}
