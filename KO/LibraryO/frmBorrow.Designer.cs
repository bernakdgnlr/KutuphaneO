namespace LibraryO
{
    partial class frmBorrow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberIdentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.txtBorrowDate = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.IdentityList = new System.Windows.Forms.Label();
            this.txtIdentityList = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBookNameList = new System.Windows.Forms.Label();
            this.txtBookNameList = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MemberName,
            this.MemberLastName,
            this.MemberIdentity,
            this.Cinsiyet,
            this.Phone,
            this.Email});
            this.dataGridView1.Location = new System.Drawing.Point(19, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 156);
            this.dataGridView1.TabIndex = 54;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Üye Numara";
            this.Id.Name = "Id";
            // 
            // MemberName
            // 
            this.MemberName.DataPropertyName = "MemberName";
            this.MemberName.HeaderText = "Üye Adı";
            this.MemberName.Name = "MemberName";
            // 
            // MemberLastName
            // 
            this.MemberLastName.DataPropertyName = "MemberLastName";
            this.MemberLastName.HeaderText = "Üye Soyadı";
            this.MemberLastName.Name = "MemberLastName";
            // 
            // MemberIdentity
            // 
            this.MemberIdentity.DataPropertyName = "MemberIdentity";
            this.MemberIdentity.HeaderText = "Üye Kimlik Numarası";
            this.MemberIdentity.Name = "MemberIdentity";
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.DataPropertyName = "Sex";
            this.Cinsiyet.HeaderText = "Cinsiyet";
            this.Cinsiyet.Name = "Cinsiyet";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Telefon Numarası";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(134, 428);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBorrow.TabIndex = 53;
            this.btnBorrow.Text = "Teslim Et";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(31, 393);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(71, 13);
            this.lblBookId.TabIndex = 52;
            this.lblBookId.Text = "Kitap Numara";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(109, 390);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(100, 20);
            this.txtBookId.TabIndex = 51;
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(16, 356);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(88, 13);
            this.lblEmployeeId.TabIndex = 50;
            this.lblEmployeeId.Text = "Personel Numara";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(109, 353);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeId.TabIndex = 49;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Location = new System.Drawing.Point(41, 315);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(66, 13);
            this.lblMemberId.TabIndex = 48;
            this.lblMemberId.Text = "Üye Numara";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(109, 312);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(100, 20);
            this.txtMemberId.TabIndex = 47;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Location = new System.Drawing.Point(41, 279);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(63, 13);
            this.lblBorrowDate.TabIndex = 46;
            this.lblBorrowDate.Text = "Veriliş Tarihi";
            // 
            // txtBorrowDate
            // 
            this.txtBorrowDate.Location = new System.Drawing.Point(109, 276);
            this.txtBorrowDate.Name = "txtBorrowDate";
            this.txtBorrowDate.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowDate.TabIndex = 45;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(41, 238);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(61, 13);
            this.lblNumber.TabIndex = 44;
            this.lblNumber.Text = "Kitap Sayısı";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(109, 235);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 43;
            // 
            // IdentityList
            // 
            this.IdentityList.AutoSize = true;
            this.IdentityList.Location = new System.Drawing.Point(16, 9);
            this.IdentityList.Name = "IdentityList";
            this.IdentityList.Size = new System.Drawing.Size(62, 13);
            this.IdentityList.TabIndex = 42;
            this.IdentityList.Text = "Üye TC Ara";
            // 
            // txtIdentityList
            // 
            this.txtIdentityList.Location = new System.Drawing.Point(84, 6);
            this.txtIdentityList.Name = "txtIdentityList";
            this.txtIdentityList.Size = new System.Drawing.Size(100, 20);
            this.txtIdentityList.TabIndex = 41;
            this.txtIdentityList.TextChanged += new System.EventHandler(this.txtIdentityList_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id2,
            this.BookName,
            this.Author,
            this.Publisher,
            this.NumberOfBooks});
            this.dataGridView2.Location = new System.Drawing.Point(411, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(377, 156);
            this.dataGridView2.TabIndex = 57;
            // 
            // Id2
            // 
            this.Id2.DataPropertyName = "Id";
            this.Id2.HeaderText = "Kitap Numarası";
            this.Id2.Name = "Id2";
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Kitap Adı";
            this.BookName.Name = "BookName";
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Yazar";
            this.Author.Name = "Author";
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "Publisher";
            this.Publisher.HeaderText = "Yayınevi";
            this.Publisher.Name = "Publisher";
            // 
            // NumberOfBooks
            // 
            this.NumberOfBooks.DataPropertyName = "NumberOfBooks";
            this.NumberOfBooks.HeaderText = "Kitap Adedi";
            this.NumberOfBooks.Name = "NumberOfBooks";
            // 
            // lblBookNameList
            // 
            this.lblBookNameList.AutoSize = true;
            this.lblBookNameList.Location = new System.Drawing.Point(408, 9);
            this.lblBookNameList.Name = "lblBookNameList";
            this.lblBookNameList.Size = new System.Drawing.Size(68, 13);
            this.lblBookNameList.TabIndex = 56;
            this.lblBookNameList.Text = "Kitap Adı Ara";
            // 
            // txtBookNameList
            // 
            this.txtBookNameList.Location = new System.Drawing.Point(482, 6);
            this.txtBookNameList.Name = "txtBookNameList";
            this.txtBookNameList.Size = new System.Drawing.Size(100, 20);
            this.txtBookNameList.TabIndex = 55;
            this.txtBookNameList.TextChanged += new System.EventHandler(this.txtBookNameList_TextChanged);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(766, 428);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 58;
            this.btnback.Text = "Geri Dön";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 482);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblBookNameList);
            this.Controls.Add(this.txtBookNameList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lblBorrowDate);
            this.Controls.Add(this.txtBorrowDate);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.IdentityList);
            this.Controls.Add(this.txtIdentityList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.TextBox txtBorrowDate;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label IdentityList;
        private System.Windows.Forms.TextBox txtIdentityList;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblBookNameList;
        private System.Windows.Forms.TextBox txtBookNameList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberIdentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfBooks;
        private System.Windows.Forms.Button btnback;
    }
}

