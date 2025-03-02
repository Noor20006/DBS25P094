using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITECHEvent
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateEvent u = new UpdateEvent();
            u.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEvent A = new AddEvent();
            A.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteEvent D = new DeleteEvent();
            D.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrganizeCommitee c = new OrganizeCommitee();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            VenueSelection c = new VenueSelection();
            c.Show();
        }
    }
}
