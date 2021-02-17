using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4___Random_Numbers
{
    public partial class frmMain : Form
    {  
        int maxInt = 0;
        int minInt = 0;
        double maxDouble = 0.0;
        double minDouble = 0.0;
        double randNumber = 0.0;
        Random rand = new Random();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            string minInput = txtMin.Text;
            string maxInput = txtMax.Text;           
            if (!Int32.TryParse(minInput, out minInt))
                txtMin.Text = "Enter a valid number";
            else
                if (!Int32.TryParse(maxInput, out maxInt))
                txtMax.Text = "Enter a valid number";
            else
                lblRandomNumber.Text = $"{rand.Next(minInt, maxInt + 1)}";
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            string minInput = txtMin.Text;
            string maxInput = txtMax.Text;
            decimal roundTo = nudRounding.Value;
            if (!double.TryParse(minInput, out minDouble))
                txtMin.Text = "Enter a valid number";
            else
                if (!double.TryParse(maxInput, out maxDouble))
                txtMax.Text = "Enter a valid number";
            else
                randNumber = Math.Round(rand.NextDouble() * (maxDouble - minDouble) + minDouble, Convert.ToInt32(roundTo));
                lblRandomNumber.Text = $"{randNumber}";
        }
    }
}
