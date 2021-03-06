﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace WindowsFormsApplication2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
               
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
            this.MinimumSize = new System.Drawing.Size(this.Width + 50, this.Height + 50);

            // no larger than screen size
            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
            radioButtonID.Checked = true;
            foreach (Control c in this.Controls)
            {
                c.Anchor = AnchorStyles.None;
            }
        }

        private void radioButtonID_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonID.Checked == true)
            {
                nameLabel.Enabled = false;
                nametextBox.Enabled = false;
                addressLabel.Enabled = false;
                addresstextBox.Enabled = false;
                dObLabel.Enabled = false;
                dObtextBox.Enabled = false;
                idLabel.Enabled = true;
                iDtextBox.Enabled = true;
            }
            else
            {
                nameLabel.Enabled = true;
                nametextBox.Enabled = true;
                addressLabel.Enabled = true;
                addresstextBox.Enabled = true;
                dObLabel.Enabled = true;
                dObtextBox.Enabled = true;
                idLabel.Enabled = false;
                iDtextBox.Enabled = false;
            }
        }

        private void logOffBut_Click(object sender, EventArgs e)
        {
            UIManager.Instance.logOffBut_ClickUi(e);
        }

        private void invokeActions()
        {
            String name = nametextBox.Text;
            String address = addresstextBox.Text;
            String dob = dObtextBox.Text;
            DataSet ds = new DataSet();
            
            

            if (radioButtonID.Checked)
            {
                if (UIManager.Instance.ConfirmSearchPatientClick(iDtextBox.Text))
                {
                    UIManager.Instance.swapVisibility2();
                    ds = UIManager.Instance.getDataSet();
                    
                    System.Windows.MessageBox.Show("Active Patient saved");
                }
                else
                {
                    System.Windows.MessageBox.Show("Invalid ID");
                }
            }

                if (radioButtonName.Checked)
                {
                    if (UIManager.Instance.ConfirmSearchPatientClick(name, address, dob) == true)
                    {
                        UIManager.Instance.swapVisibility2();
                        System.Windows.MessageBox.Show("Active Patient saved");
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Invalid Name, Address or DOB");
                    }
                }
            }

        private void confirmSearchbutton_Click(object sender, EventArgs e)
        {
            invokeActions();
         }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            UIManager.Instance.showCalendar();
        }
    }
}
