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
    public partial class OrderForm : Form
    {
        public SelectionForm selectionForm = Program.selectionscreen;
        public StreamForm streamform = Program.streamscreen;
        public OrderForm()
        {
            InitializeComponent();
        }
        public void stream()
        {
            streamform.Show();
            this.Hide();
        }
        public void cancel()
        {
            this.selectionForm.Show();
            this.Close();
        }
        private void streambutton_Click(object sender, EventArgs e)
        {
            stream();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private string _title,_cost;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            titletextbox.Text = Title;
            costtextbox.Text = Cost;
            //decimal buyMovie = 10.00m;
            //decimal subTotal = decimal.Parse(costtextbox.Text);
            //decimal salesTax = 0.13m * subTotal;
            //decimal grandTotal = salesTax + subTotal;

        }
    }
}
