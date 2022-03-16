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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
       // SqlConnection con = new SqlConnection("Data Source=DESKTOP-32MH31K;Initial Catalog=DbLibrary;Integrated Security=True");
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User.KullaniciGirisi(textBox1,textBox2);
            if(User.status==true)
            {
                frmHomePage frm=new frmHomePage();
                frm.Show();
                this.Hide();    
            }
            else 
            {
                MessageBox.Show("Kullanıcı adı ve şifrenizi kontrol ediniz.");

            }  


        }
    }
}
