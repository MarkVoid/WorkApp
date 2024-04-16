using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkApp.Entities;

namespace WorkApp
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        Work c = new Work();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            log.Focus();
            this.Hide();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int C = 0;
        private void timer_tick(object sender, EventArgs e)
        {
            C++;
            label1.Text = C.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                btnStart.Text = "Start Work";
            }
            else
            {
                timer1.Enabled = true;
                btnStart.Text = "Stop Work";
            }
        }

        private void btnOver_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            c.Name = labelName.Text;
            c.WorkName = ComboWork.Text;
            c.Timer = label1.Text;

            bool sucess = c.Insert(c);
            if (sucess == true)
            {
                MessageBox.Show("New Work Inserted");
            }
            else
            {
                MessageBox.Show("Failed to add New Work. Try Again.");
            }
            DataTable dt2 = c.Select();
            WorkView.DataSource = dt2;

            label1.Text = "0";
            C = 0;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            labelName.Text = Name;
            DataTable dt2 = c.Select();
            WorkView.DataSource = dt2;
            label1.Text = "0";
        }

        private void WorkView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            labelName.Text = Name;
        }

        private void ComboWork_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WorkView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }
    }
}
