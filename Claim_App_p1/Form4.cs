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
    public partial class Form4 : Form
    {
        public static Form4 instance;

        public Form4()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }
    }
}
