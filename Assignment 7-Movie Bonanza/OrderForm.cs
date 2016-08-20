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
    }
}
