using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQMS
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        sqmscontext context = new sqmscontext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            var info = context.Authorities.FirstOrDefault(u => u.Email == txtUsername.Text && u.Password == txtPass.Text);
            var info1 = context.Users.FirstOrDefault(u => u.Email == txtUsername.Text && u.Password == txtPass.Text);
            //  MessageBox.Show("invalid emails and password");

            if (info != null)
            {
                LoginHelper.AInfo = info;
                AuthorityDashBoard A1 = new AuthorityDashBoard();
                A1.Visible = true;
                this.Visible = false;
                

            }
            else if (info1 != null)
            {
                LoginHelper.UInfo = info1;
                UserDashBoard u1 = new UserDashBoard();
                u1.Visible = true;
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("invalid emails and password");
            }
        }

        private void MetroLabel3_Click(object sender, EventArgs e)
        {
            Registration r1 = new Registration();
            r1.Visible = true;
            this.Hide();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
