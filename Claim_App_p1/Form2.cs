using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Claim_App_p1
{
    public partial class Form2 : Form
    {
        public static Form2 instance;

        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void LectureFill_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }
        private void btnSubmitClaim_Click(object sender, EventArgs e)
        {
            // Display a success message
            MessageBox.Show("Claim successfully submitted!");

            // Optionally, close the form or reset fields for new input
            // this.Close(); // Uncomment if you want to close the form after submission
            // ResetForm(); // Optionally, add a method to reset form fields
        }

    }
}
