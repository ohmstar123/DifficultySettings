using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    
    public partial class Form1 : Form
    {
        string userName, difficulty;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        { 
            userName = usernameImput.Text;
            difficulty = "easy";

            easyButton.BackColor = Color.Lime;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            userName = usernameImput.Text;
            difficulty = "medium";

            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Yellow;
            hardButton.BackColor = Color.Black;
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            userName = usernameImput.Text;
            difficulty = "hard";

            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Red;
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = " Welcome " + userName + " \n A true brave hero, ready to conquer the " + difficulty + " path ";

        }
    }
}
