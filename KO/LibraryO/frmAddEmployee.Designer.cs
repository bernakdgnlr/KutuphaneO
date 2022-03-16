namespace LibraryO
{
    partial class frmAddEmployee
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
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmpLastName = new System.Windows.Forms.Label();
            this.txtEmpPassword = new System.Windows.Forms.TextBox();
            this.lblEmpPassword = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(33, 80);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(66, 13);
            this.lblEmpName.TabIndex = 0;
            this.lblEmpName.Text = "Personel Adı";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(105, 77);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(105, 113);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // lblEmpLastName
            // 
            this.lblEmpLastName.AutoSize = true;
            this.lblEmpLastName.Location = new System.Drawing.Point(16, 116);
            this.lblEmpLastName.Name = "lblEmpLastName";
            this.lblEmpLastName.Size = new System.Drawing.Size(83, 13);
            this.lblEmpLastName.TabIndex = 2;
            this.lblEmpLastName.Text = "Personel Soyadı";
            this.lblEmpLastName.Click += new System.EventHandler(this.lblEmpLastName_Click);
            // 
            // txtEmpPassword
            // 
            this.txtEmpPassword.Location = new System.Drawing.Point(105, 144);
            this.txtEmpPassword.Name = "txtEmpPassword";
            this.txtEmpPassword.Size = new System.Drawing.Size(100, 20);
            this.txtEmpPassword.TabIndex = 5;
            // 
            // lblEmpPassword
            // 
            this.lblEmpPassword.AutoSize = true;
            this.lblEmpPassword.Location = new System.Drawing.Point(27, 147);
            this.lblEmpPassword.Name = "lblEmpPassword";
            this.lblEmpPassword.Size = new System.Drawing.Size(72, 13);
            this.lblEmpPassword.TabIndex = 4;
            this.lblEmpPassword.Text = "Personel Şifre";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(121, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(234, 264);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Geri dön";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 299);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmpPassword);
            this.Controls.Add(this.lblEmpPassword);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblEmpLastName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblEmpName);
            this.Name = "frmAddEmployee";
            this.Text = "frmAddEmployee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmpLastName;
        private System.Windows.Forms.TextBox txtEmpPassword;
        private System.Windows.Forms.Label lblEmpPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
    }
}