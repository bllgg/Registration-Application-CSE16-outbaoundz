using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Registration_Appication
{
    public partial class Form1 : Form
    {
        static int male17 = 0;
        static int female17 = 0;
        static int male18 = 0;
        static int female18 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSbmt_Click(object sender, EventArgs e)
        {
            // Constraints checking...!!!
            if (combo17Batch.Text == "" && combo18Batch.Text == "")
            {
                MessageBox.Show("Index numbers are Empty!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(combo17Batch.Text != "" && combo18Batch.Text != "")
            {
                MessageBox.Show("Both Index Numbers cannot be filled!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioMale.Checked == false && radioFemale.Checked == false)
            {
                MessageBox.Show("Please select the Gender!", "Invalid input", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }



            //Clear the inputs
            combo17Batch.Text = "";
            combo18Batch.Text = "";
            radioMale.Checked = false;
            radioFemale.Checked = false;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }

        private void btnSbmtEmg_Click(object sender, EventArgs e)
        {
            // Constraints checking...!!!
            if (txtIdxEmg.Text == "")
            {
                MessageBox.Show("Please Insert the Index Number!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(radio17BatchEmg.Checked == false && radio18BatchEmg.Checked == false)
            {
                MessageBox.Show("Please Insert the batch!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(radioMaleEmg.Checked == false && radioFemaleEmg.Checked == false)
            {
                MessageBox.Show("Please Insert the Gender", "INvalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //Clear the inputs
            txtIdxEmg.Text = "";
            radio17BatchEmg.Checked = false;
            radio18BatchEmg.Checked = false;
            radioMaleEmg.Checked = false;
            radioFemaleEmg.Checked = false;

        }

        private void btnUndoEmg_Click(object sender, EventArgs e)
        {

        }
    }
}
