using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Menu_Form
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            frmMain mainpage = new frmMain();
            string pass = txtPass.Text.ToString();
            int result = String.Compare(pass, "Paing");
            if (result == 0) //password correct
            {
                this.Hide();
                mainpage.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
