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
        decimal[] cost = new decimal[]
        { 1.99m, 1.99m, 2.99m, 2.99m, 2.99m, 1.99m, 0.99m, 4.99m  };
        string[] catgory = new string[] { "Comedy", "Drama", "Action", "Sci-Fi", "Horror", "Thriller", "Family", "New Release" };
        string[] family = new string[] { "Gnomeo and Juliet" };
        string[] drama = new string[] { "Company Men", "The Way Back", "Waiting for Forever" };
        string[] comedy = new string[] { "The Dilemma", "No Strings Attached", "Cedar Rapids", "Just Go With it" };
        string[] thriller = new string[] { "The Roommate" };
        string[] horror = new string[] { "The Rite" };
        string[] newlyReleased = new string[] { "Footloose", "Real Steel" };
        string[] scifi = new string[] { "Season of the Witch", "I am Number Four" };
        string[] action = new string[] { "The Green Hornet", "Death Race 2", "The Mechanic", "Sanctum", "The Other Woman", "The Eagle" };
        private void FirstNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            orderform.Show();
            this.Close();
        }

        private void catagoryDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int category = catagoryDropDown.SelectedIndex;


            if (category == 0)
            {
                movielistbox.Items.Clear();
                movielistbox.Items.AddRange(comedy);
                catagoryDropDown.Text = catgory[0];
                costtextbox.Text = cost[0].ToString();
            }
            if (category == 1)
            {
                movielistbox.Items.Clear();
                movielistbox.Items.AddRange(drama);
                catagoryDropDown.Text = catgory[1];
                costtextbox.Text = cost[0].ToString();
            }
            if (category == 2)
            {
                movielistbox.Items.Clear();
                movielistbox.Items.AddRange(action);
                catagoryDropDown.Text = catgory[2];
                costtextbox.Text = cost[2].ToString();
            }
            if (category == 3)
            {
                movielistbox.Items.Clear();
                movielistbox.Items.AddRange(scifi);
                catagoryDropDown.Text = catgory[3];
                costtextbox.Text = cost[2].ToString();
            }
            if (category == 4)
            {
                movielistbox.Items.Clear();
                movielistbox.Items.AddRange(horror);
                catagoryDropDown.Text = catgory[4];
                costtextbox.Text = cost[2].ToString();
            }
            if (category == 5)
            {
                movielistbox.Items.Clear();
                movielistbox.Items.AddRange(thriller);
                catagoryDropDown.Text = catgory[5];
                costtextbox.Text = cost[0].ToString();
            }
            if (category == 6)
            {
                movielistbox.Items.Clear();
                movielistbox.Items.AddRange(family);
                catagoryDropDown.Text = catgory[6];
                costtextbox.Text = cost[6].ToString();
            }
            if (category == 7)
            {
                movielistbox.Items.Clear();
                movielistbox.Items.AddRange(newlyReleased);
                catagoryDropDown.Text = catgory[7];
                costtextbox.Text = cost[7].ToString();
            }
        }

        private void movielistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            titletextbox.Text = string.Empty;

            foreach (string value in movielistbox.SelectedItems)
            {
                titletextbox.Text = value.ToString();
                if (value == "The Dilemma")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.thedilemma);
                }
                if (value == "No Strings Attached")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.nostringsattached);
                }
                if (value == "Cedar Rapids")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.cedarrapids);
                }
                if (value == "Just Go With it")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.justgowithit);
                }
                if (value == "Company Men")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.companymen);
                }
                if (value == "The Way Back")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.thewayback);
                }
                if (value == "Waiting for Forever")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.waitingforever);
                }
                if (value == "The Green Hornet")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.thegreenhornet);
                }
                if (value == "Death Race 2")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.deathrace2);
                }
                if (value == "The Mechanic")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.themechanic);
                }
                if (value == "Sanctum")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.sanctum);
                }
                if (value == "The Other Woman")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.theotherwoman);
                }
                if (value == "The Eagle")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.theeagle);
                }
                if (value == "Season of the Witch")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.seasonofthewitch);
                }
                if (value == "I am Number Four")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.iamnumberfour);
                }
                if (value == "The Rite")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.therite);
                }
                if (value == "The Roommate")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.theroommate);
                }
                if (value == "Gnomeo and Juliet")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.gnomeoandjuliet);
                }
                if (value == "Footloose")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.footloose);
                }
                if (value == "Real Steel")
                {
                    moviespictures.Image = new Bitmap(Properties.Resources.realsteel);
                }
            }
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
