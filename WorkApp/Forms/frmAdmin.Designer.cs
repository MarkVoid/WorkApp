
namespace WorkApp
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeView = new System.Windows.Forms.DataGridView();
            this.WorkView = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEmpUpdate = new System.Windows.Forms.Button();
            this.btnEmpDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtUsernameadm = new System.Windows.Forms.TextBox();
            this.txtPasswordadm = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnWorkAdd = new System.Windows.Forms.Button();
            this.btnWorkUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearWork = new System.Windows.Forms.Button();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtWorkId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // EmployeeView
            // 
            this.EmployeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeView.Location = new System.Drawing.Point(656, 8);
            this.EmployeeView.Name = "EmployeeView";
            this.EmployeeView.RowHeadersWidth = 51;
            this.EmployeeView.RowTemplate.Height = 29;
            this.EmployeeView.Size = new System.Drawing.Size(367, 212);
            this.EmployeeView.TabIndex = 1;
            this.EmployeeView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeView_CellContentClick);
            this.EmployeeView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EmployeeView_RowHeaderMouseClick);
            // 
            // WorkView
            // 
            this.WorkView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkView.Location = new System.Drawing.Point(656, 226);
            this.WorkView.Name = "WorkView";
            this.WorkView.RowHeadersWidth = 51;
            this.WorkView.RowTemplate.Height = 29;
            this.WorkView.Size = new System.Drawing.Size(367, 212);
            this.WorkView.TabIndex = 2;
            this.WorkView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.WorkView_RowHeaderMouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 399);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(112, 399);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 39);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(556, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnEmpAdd_Click);
            // 
            // btnEmpUpdate
            // 
            this.btnEmpUpdate.Location = new System.Drawing.Point(556, 57);
            this.btnEmpUpdate.Name = "btnEmpUpdate";
            this.btnEmpUpdate.Size = new System.Drawing.Size(94, 39);
            this.btnEmpUpdate.TabIndex = 6;
            this.btnEmpUpdate.Text = "Update";
            this.btnEmpUpdate.UseVisualStyleBackColor = true;
            this.btnEmpUpdate.Click += new System.EventHandler(this.btnEmpUpdate_Click);
            // 
            // btnEmpDelete
            // 
            this.btnEmpDelete.Location = new System.Drawing.Point(556, 102);
            this.btnEmpDelete.Name = "btnEmpDelete";
            this.btnEmpDelete.Size = new System.Drawing.Size(94, 39);
            this.btnEmpDelete.TabIndex = 7;
            this.btnEmpDelete.Text = "Delete";
            this.btnEmpDelete.UseVisualStyleBackColor = true;
            this.btnEmpDelete.Click += new System.EventHandler(this.btnEmpDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(129, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 39);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtUsernameadm
            // 
            this.txtUsernameadm.Location = new System.Drawing.Point(81, 152);
            this.txtUsernameadm.Name = "txtUsernameadm";
            this.txtUsernameadm.Size = new System.Drawing.Size(195, 27);
            this.txtUsernameadm.TabIndex = 9;
            // 
            // txtPasswordadm
            // 
            this.txtPasswordadm.Location = new System.Drawing.Point(81, 217);
            this.txtPasswordadm.Name = "txtPasswordadm";
            this.txtPasswordadm.Size = new System.Drawing.Size(195, 27);
            this.txtPasswordadm.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(329, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 27);
            this.txtName.TabIndex = 11;
            // 
            // btnWorkAdd
            // 
            this.btnWorkAdd.Location = new System.Drawing.Point(556, 226);
            this.btnWorkAdd.Name = "btnWorkAdd";
            this.btnWorkAdd.Size = new System.Drawing.Size(94, 39);
            this.btnWorkAdd.TabIndex = 12;
            this.btnWorkAdd.Text = "Add";
            this.btnWorkAdd.UseVisualStyleBackColor = true;
            this.btnWorkAdd.Click += new System.EventHandler(this.btnWorkAdd_Click);
            // 
            // btnWorkUpdate
            // 
            this.btnWorkUpdate.Location = new System.Drawing.Point(556, 271);
            this.btnWorkUpdate.Name = "btnWorkUpdate";
            this.btnWorkUpdate.Size = new System.Drawing.Size(94, 39);
            this.btnWorkUpdate.TabIndex = 13;
            this.btnWorkUpdate.Text = "Update";
            this.btnWorkUpdate.UseVisualStyleBackColor = true;
            this.btnWorkUpdate.Click += new System.EventHandler(this.btnWorkUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(556, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 39);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtWork
            // 
            this.txtWork.Location = new System.Drawing.Point(329, 189);
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(195, 27);
            this.txtWork.TabIndex = 15;
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(329, 268);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(195, 27);
            this.txtTimer.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Timer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Work";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(544, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "Employees";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(591, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 28);
            this.label8.TabIndex = 23;
            this.label8.Text = "Work";
            // 
            // btnClearWork
            // 
            this.btnClearWork.Location = new System.Drawing.Point(371, 325);
            this.btnClearWork.Name = "btnClearWork";
            this.btnClearWork.Size = new System.Drawing.Size(94, 39);
            this.btnClearWork.TabIndex = 24;
            this.btnClearWork.Text = "Clear";
            this.btnClearWork.UseVisualStyleBackColor = true;
            this.btnClearWork.Click += new System.EventHandler(this.btnClearWork_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(81, 84);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(195, 27);
            this.txtEmpId.TabIndex = 25;
            // 
            // txtWorkId
            // 
            this.txtWorkId.Location = new System.Drawing.Point(329, 41);
            this.txtWorkId.Name = "txtWorkId";
            this.txtWorkId.Size = new System.Drawing.Size(195, 27);
            this.txtWorkId.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "id";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtWorkId);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.btnClearWork);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.txtWork);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnWorkUpdate);
            this.Controls.Add(this.btnWorkAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPasswordadm);
            this.Controls.Add(this.txtUsernameadm);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEmpDelete);
            this.Controls.Add(this.btnEmpUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.WorkView);
            this.Controls.Add(this.EmployeeView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EmployeeView;
        private System.Windows.Forms.DataGridView WorkView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEmpUpdate;
        private System.Windows.Forms.Button btnEmpDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtUsernameadm;
        private System.Windows.Forms.TextBox txtPasswordadm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnWorkAdd;
        private System.Windows.Forms.Button btnWorkUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtWork;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClearWork;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtWorkId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.TextBox txtIdEmp;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}