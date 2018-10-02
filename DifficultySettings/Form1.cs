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
      
        public Form1()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            string userName;
            userName = usernameImput.Text;
            outputLabel.Text = " Welcome " + userName + " are you ready to conquer the easy path ";
        
        }
    }
}
