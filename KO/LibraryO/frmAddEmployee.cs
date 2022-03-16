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
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-32MH31K;Initial Catalog=DbLibrary;Integrated Security=True");
        private void lblEmpLastName_Click(object sender, EventArgs e)
        {

        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (User.UserId==3)
            {


                con.Open();
                SqlCommand command = new SqlCommand("insert into Employee(EmpName,EmpLastName,EmpPassword)values(@empName,@empLastName,@empPassword)", con);
                command.Parameters.AddWithValue("@empName", txtEmpName.Text);
                command.Parameters.AddWithValue("@empLastName", txtLastName.Text);
                command.Parameters.AddWithValue("@empPassword", txtEmpPassword.Text);

                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Personel eklendi.");
            }
            else
            {
                MessageBox.Show("Böyle bir yetkiniz bulunmuyor!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            frmHomePage frm = new frmHomePage();
            frm.Show();
            this.Hide();
        }
    }
}
