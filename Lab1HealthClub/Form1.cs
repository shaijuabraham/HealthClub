using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1HealthClub
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            radAdult.Checked = false;
            radChild.Checked = false;
            radSeniorCitizen.Checked = false;
        // for the checkbox
            chkKarate.Checked = false;
            chkYoga.Checked = false;
            chkPersonalTri.Checked = false;
         // Txt 
            txtMonths.Clear();
            lblMonFee.Text = " ";
            lblTotalFee.Text = " ";


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal StandardFee = 0;
            if(radAdult.Checked )
            {
                StandardFee = 40;
            }
            else if(radChild.Checked) {
                StandardFee = 20;
            }
            else if (radStudent.Checked)
            {
                StandardFee = 25;
            }
            else if (radSeniorCitizen.Checked)
            {
                StandardFee = 30;
            }

            if (chkYoga.Checked)
            {
                StandardFee+=10;
            }
            if (chkKarate.Checked)
            {
                StandardFee += 30;
            }
            if (chkPersonalTri.Checked)
            {
                StandardFee+= 50;
            }
          //  int numMonths = int.Parse(txtMonths.Text);

            if (int.TryParse(txtMonths.Text, out int numMonths))
            {
                decimal monthlyFee = StandardFee;
                decimal total = monthlyFee * numMonths;

                lblMonFee.Text = "$" + monthlyFee.ToString();
                lblTotalFee.Text = "$" + total.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Month");
            }

        }
    }
}
