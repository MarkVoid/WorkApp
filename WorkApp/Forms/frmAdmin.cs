using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkApp.Entities;
using WorkApp.Model;

namespace WorkApp
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        Employee b = new Employee();
        Work c = new Work();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            log.Focus();
            this.Hide();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            DataTable dt1 = b.Select();
            DataTable dt2 = c.Select();
            EmployeeView.DataSource = dt1;
            WorkView.DataSource = dt2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void btnClearWork_Click(object sender, EventArgs e)
        {
            ClearWork();
        }
        private void Clear()
        {
            txtUsernameadm.Text = "";
            txtPasswordadm.Text = "";
            txtUsernameadm.Focus();
        }
        private void ClearWork()
        {
            txtName.Text = "";
            txtWork.Text = "";
            txtTimer.Text = "";
            txtName.Focus();
        }

        private void EmployeeView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtEmpId.Text = EmployeeView.Rows[rowIndex].Cells[0].Value.ToString();
            txtUsernameadm.Text = EmployeeView.Rows[rowIndex].Cells[1].Value.ToString();
            txtPasswordadm.Text = EmployeeView.Rows[rowIndex].Cells[2].Value.ToString();
        }
        private void WorkView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtWorkId.Text = WorkView.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = WorkView.Rows[rowIndex].Cells[1].Value.ToString();
            txtTimer.Text = WorkView.Rows[rowIndex].Cells[2].Value.ToString();
            txtWork.Text = WorkView.Rows[rowIndex].Cells[3].Value.ToString();
            
        }
        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            b.UserName = txtUsernameadm.Text;
            b.Password = txtPasswordadm.Text;

            bool success = b.Insert(b);
            if (success == true)
            {
                MessageBox.Show("New Employee Added");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add Employee");
            }
            DataTable dt1 = b.Select();
            EmployeeView.DataSource = dt1;
        }

        private void btnWorkAdd_Click(object sender, EventArgs e)
        {
            c.Name = txtName.Text;
            c.WorkName = txtWork.Text;
            c.Timer = txtTimer.Text;

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Work Inserted");
            }
            else
            {
                MessageBox.Show("Failed to add New Work. Try Again.");
            }
            DataTable dt2 = c.Select();
            WorkView.DataSource = dt2;
        }

        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {
            b.Id = Convert.ToInt32(txtEmpId.Text);
            b.UserName = txtUsernameadm.Text;
            b.Password = txtPasswordadm.Text;

            bool success = b.Update(b);
            if (success == true)
            {
                MessageBox.Show("Employee has been Updated");
            }
            else
            {
                MessageBox.Show("Failed to update Employee");
            }
            DataTable dt1 = b.Select();
            EmployeeView.DataSource = dt1;
        }

        private void btnWorkUpdate_Click(object sender, EventArgs e)
        {
            c.WorkId = Convert.ToInt32(txtWorkId.Text);
            c.Name = txtName.Text;
            c.WorkName = txtWork.Text;
            c.Timer = txtTimer.Text;

            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Work was Updated");
            }
            else
            {
                MessageBox.Show("Failed to update Work");
            }
            DataTable dt2 = c.Select();
            WorkView.DataSource = dt2;
        }

        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            b.Id = Convert.ToInt32(txtEmpId.Text);
            bool success = b.Delete(b);
            if (success == true)
            {
                MessageBox.Show("Employee deleted");
                DataTable dt1 = b.Select();
                EmployeeView.DataSource = dt1;

            }
            else
            {
                MessageBox.Show("Failed to delete Employee");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.WorkId = Convert.ToInt32(txtWorkId.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Work deleted");
                DataTable dt2 = b.Select();
                WorkView.DataSource = dt2;
            }
            else
            {
                MessageBox.Show("Failed to delete Work");
            }
        }

        private void EmployeeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
