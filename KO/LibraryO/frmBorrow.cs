using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryO
{
    public partial class frmBorrow : Form
    {
        public frmBorrow()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-32MH31K;Initial Catalog=DbLibrary;Integrated Security=True");

        SqlDataAdapter adtr;
        SqlCommand cmd;
        DataTable table = new DataTable();

        SqlDataAdapter adtr2;
        SqlCommand cmd2;
        DataTable table2 = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Borrow()
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into Borrow(Number,BorrowDate,MemberId,EmployeeId,BookId)values(@number,@borrowDate,@memberId,@employeeId,@bookId)", con);
            command.Parameters.AddWithValue("@number", txtNumber.Text);
            command.Parameters.AddWithValue("@borrowDate", txtBorrowDate.Text);
            command.Parameters.AddWithValue("@memberId", txtMemberId.Text);
            command.Parameters.AddWithValue("@employeeId", txtEmployeeId.Text);
            command.Parameters.AddWithValue("@bookId", txtBookId.Text);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Teslim edildi.");
            BookList();
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            
            Borrow();
                     



        }
        void BookList()
        {
            table.Clear();
            cmd = new SqlCommand("sp_ListBookName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("BookName", txtBookNameList.Text);
            adtr = new SqlDataAdapter(cmd);
            adtr.Fill(table);
            dataGridView2.DataSource = table;
        }
        void MemberList()
        {
            table2.Clear();
            cmd2 = new SqlCommand("sp_ListMemberIdentity", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("MemberIdentity", txtIdentityList.Text);
            adtr2 = new SqlDataAdapter(cmd2);
            adtr2.Fill(table2);
            dataGridView1.DataSource = table2;
        }

    
        private void txtIdentityList_TextChanged(object sender, EventArgs e)
        {
            
            MemberList();
        }

        private void txtBookNameList_TextChanged(object sender, EventArgs e)
        {
           
            BookList();
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmHomePage frm = new frmHomePage();
            frm.Show();
            this.Hide();
        }
    }
}
