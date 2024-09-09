using System;
using System.Windows.Forms;

namespace Claim_App_p1
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click if needed
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Handle radio button change if needed
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if radioButton1 is selected
            if (radioButton1.Checked)
            {
                // Open Form2
                Form2 form = new Form2();
                form.Show();
                this.Hide(); // Optionally hide Form1
            }
            else if (radioButton2.Checked)
            {
                // Open Form4
                Form4 form = new Form4();
                form.Show();
                this.Hide(); // Optionally hide Form1
            }
            else
            {
                MessageBox.Show("Please select a role before logging in.");
            }
        }
    }
}
