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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventForm E = new EventForm();
            E.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssignTask a = new AssignTask();
            a.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationtype r = new registrationtype();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssignCommitee a = new AssignCommitee();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinalFinancial f = new FinalFinancial();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ITEC i = new ITEC();
            i.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssignVenue a = new AssignVenue();
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            result r = new result();
            r.Show();
        }
    }
}
