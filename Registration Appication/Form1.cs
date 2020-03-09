﻿using System;
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
        private string[] groupNames = { "Beeston", "Carlton", "Arnold", "Selston", "Clifton", "Retford", "Calverton", "Ollerton" };
        private string[] groupColors = { "Red", "Orange", "Yellow", "Green", "Blue", "Gray", "Purple", "Brown"};

        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt;
        DataRow dr;
        int status_flag;
        
        private void btnSbmt_Click(object sender, EventArgs e)
        {
            // Constraints checking...!!!
            if (combo17Batch.Text == "" && combo18Batch.Text == "")
            {
                MessageBox.Show("Index numbers are Empty!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (combo17Batch.Text != "" && combo18Batch.Text != "")
            {
                MessageBox.Show("Both Index Numbers cannot be filled!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioMale.Checked == false && radioFemale.Checked == false)
            {
                MessageBox.Show("Please select the Gender!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try {
                    if (combo18Batch.Text == "" && radioMale.Checked == true)
                    {
                        this.batch17TableAdapter.Fill(this.attendanceDataSet.batch17);
                        dt = attendanceDataSet.batch17;
                        dr = dt.NewRow();

                        status_flag = 1;

                        dr["Index"] = combo17Batch.Text;
                        dr["gender"] = "Male";
                    }
                    else if (combo18Batch.Text == "" && radioFemale.Checked == true)
                    {
                        this.batch17TableAdapter.Fill(this.attendanceDataSet.batch17);
                        dt = attendanceDataSet.batch17;
                        dr = dt.NewRow();

                        status_flag = 2;

                        dr["Index"] = combo17Batch.Text;
                        dr["gender"] = "Female";
                    }
                    else if (combo17Batch.Text == "" && radioMale.Checked == true)
                    {
                        this.batch18TableAdapter.Fill(this.attendanceDataSet.batch18);
                        dt = attendanceDataSet.batch18;
                        dr = dt.NewRow();

                        status_flag = 3;

                        dr["Index"] = combo18Batch.Text;
                        dr["gender"] = "Male";
                    }
                    else if (combo17Batch.Text == "" && radioFemale.Checked == true)
                    {
                        this.batch18TableAdapter.Fill(this.attendanceDataSet.batch18);
                        dt = attendanceDataSet.batch18;
                        dr = dt.NewRow();

                        status_flag = 4;

                        dr["Index"] = combo18Batch.Text;
                        dr["gender"] = "Female";
                    }

                    //Updating Data
                    dt.Rows.Add(dr);
                    batch17TableAdapter.Update(attendanceDataSet);
                    batch18TableAdapter.Update(attendanceDataSet);
                    MessageBox.Show("Record Added Successfuly", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    status_flag = 0;
                    MessageBox.Show("Duplicate record number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (status_flag == 1)
                {
                    txtGroupName.Text = groupNames[male17].ToString();
                    //txtColor.Text = groupColors[male17].ToString();
                    color_func(male17);
                    male17 = (male17 + 1) % 8;
                }
                else if (status_flag == 2)
                {
                    txtGroupName.Text = groupNames[female17].ToString();
                    //txtColor.Text = groupColors[female17].ToString();
                    color_func(female17);
                    female17 = (female17 + 1) % 8;
                }
                else if (status_flag == 3)
                {
                    txtGroupName.Text = groupNames[male18].ToString();
                    //txtColor.Text = groupColors[male18].ToString();
                    color_func(male18);
                    male18 = (male18 + 1) % 8;
                }
                else if (status_flag == 4)
                {
                    txtGroupName.Text = groupNames[female18].ToString();
                    //txtColor.Text = groupColors[female18].ToString();
                    color_func(female18);
                    female18 = (female18 + 1) % 8;
                }

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
            else
            {
                try
                {
                    if (radio17BatchEmg.Checked == true && radioMaleEmg.Checked == true)
                    {
                        this.batch17TableAdapter.Fill(this.attendanceDataSet.batch17);
                        dt = attendanceDataSet.batch17;
                        dr = dt.NewRow();

                        status_flag = 1;
                        
                        dr["Index"] = txtIdxEmg.Text;
                        dr["gender"] = "Male";
                    }
                    else if (radio17BatchEmg.Checked == true && radioFemaleEmg.Checked == true)
                    {
                        this.batch17TableAdapter.Fill(this.attendanceDataSet.batch17);
                        dt = attendanceDataSet.batch17;
                        dr = dt.NewRow();

                        status_flag = 2;
                        
                        dr["Index"] = txtIdxEmg.Text;
                        dr["gender"] = "Female";
                    }
                    else if (radio18BatchEmg.Checked == true && radioMaleEmg.Checked == true)
                    {
                        this.batch18TableAdapter.Fill(this.attendanceDataSet.batch18);
                        dt = attendanceDataSet.batch18;
                        dr = dt.NewRow();

                        status_flag = 3;
                        
                        dr["Index"] = txtIdxEmg.Text;
                        dr["gender"] = "Male";
                    }
                    else if (radio18BatchEmg.Checked == true && radioFemaleEmg.Checked == true)
                    {
                        this.batch18TableAdapter.Fill(this.attendanceDataSet.batch18);
                        dt = attendanceDataSet.batch18;
                        dr = dt.NewRow();

                        status_flag = 4;
                        
                        dr["Index"] = txtIdxEmg.Text;
                        dr["gender"] = "Female";
                    }
                    dt.Rows.Add(dr);
                    batch17TableAdapter.Update(attendanceDataSet);
                    batch18TableAdapter.Update(attendanceDataSet);
                    MessageBox.Show("Record Added Successfuly", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    status_flag = 0;
                    MessageBox.Show("Duplicate record number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (status_flag == 1)
                {
                    txtGroupName.Text = groupNames[male17].ToString();
                    //txtColor.Text = groupColors[male17].ToString();
                    color_func(male17);
                    male17 = (male17 + 1) % 8;
                }
                else if(status_flag == 2)
                {
                    txtGroupName.Text = groupNames[female17].ToString();
                    //txtColor.Text = groupColors[female17].ToString();
                    color_func(female17);
                    female17 = (female17 + 1) % 8;
                }
                else if (status_flag == 3)
                {
                    txtGroupName.Text = groupNames[male18].ToString();
                    //txtColor.Text = groupColors[male18].ToString();
                    color_func(male18);
                    male18 = (male18 + 1) % 8;
                }
                else if (status_flag == 4)
                {
                    txtGroupName.Text = groupNames[female18].ToString();
                    //txtColor.Text = groupColors[female18].ToString();
                    color_func(female18);
                    female18 = (female18 + 1) % 8;
                }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceDataSet.batch18' table. You can move, or remove it, as needed.
            this.batch18TableAdapter.Fill(this.attendanceDataSet.batch18);
            // TODO: This line of code loads data into the 'attendanceDataSet.batch17' table. You can move, or remove it, as needed.
            this.batch17TableAdapter.Fill(this.attendanceDataSet.batch17);

        }

        private void color_func(int code)
        {
            if (0 == code)
            {
                txtColor.BackColor = Color.Red;
            }
            else if (1 == code)
            {
                txtColor.BackColor = Color.Orange;
            }
            else if (2 == code)
            {
                txtColor.BackColor = Color.Yellow;
            }
            else if (3 == code)
            {
                txtColor.BackColor = Color.Green;
            }
            else if (4 == code)
            {
                txtColor.BackColor = Color.Blue;
            }
            else if (5 == code)
            {
                txtColor.BackColor = Color.Gray;
            }
            else if (6 == code)
            {
                txtColor.BackColor = Color.Purple;
            }
            else if (7 == code)
            {
                txtColor.BackColor = Color.Brown;
            }
        }
    }
}
