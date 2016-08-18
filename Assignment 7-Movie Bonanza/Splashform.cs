using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7_Movie_Bonanza
{
    public partial class SplashForm : Form
    {
        public SelectionForm selectionform = Program.selectionscreen;
        public SplashForm splashForm = Program.splashsrceen;
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Splashscreentimer.Enabled = false;
            selectionform.Show();
            this.Hide();
        }
    }
}
