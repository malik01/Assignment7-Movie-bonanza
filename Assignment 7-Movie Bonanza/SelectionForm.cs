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
    public partial class SelectionForm : Form
    {
        
        public OrderForm orderform = Program.ordercreen;
        public SelectionForm()
        {
            InitializeComponent();
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        string[] catgory = new string[] { "Comedy", "Drama", "Action", "Sci-Fi", "Horror", "Thriller", "Family", "New Release" };
        string[] family = new string[] { "Gnomeo and Juliet" };
        string[] drama = new string[] { "Company Men", "The Way Back", "Waiting for Forever" };
        string[] comedy = new string[] { "The Dilemma", "No Strings Attached", "Cedar Rapids", "Just Go With it" };
        string[] thriller = new string[] { "The Roommate" };
        string[] horror = new string[] { "The Rite" };
        string[] newlyReleased = new string[] { "Footloose", "Real Steel" };
        string[] scifi = new string[] { "Season of the Witch", "I am Number Four" };
        string[] action = new string[] {"The Green Hornet", "Death Race 2", "The Mechanic", "Sanctum", "The Other Woman", "The Eagle" };
        private void FirstNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            orderform.Show();
            this.Close();
        }
    }
}
