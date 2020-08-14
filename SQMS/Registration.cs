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
    public partial class Registration : MetroFramework.Forms.MetroForm
    {

        sqmscontext context = new sqmscontext();
        public Registration()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "invalid name");
                return;
            }

            if (string.IsNullOrEmpty(txtemail.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "invalid email");
                return;
            }

            if (string.IsNullOrEmpty(txtpass.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "invalid password");
                return;
            }

            if (string.IsNullOrEmpty(txtphone.Text) || txtphone.Text.Length > 11)
            {
                MetroFramework.MetroMessageBox.Show(this, "invalid phone number");
                return;
            }

            if (string.IsNullOrEmpty(richTextBox.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "please fill the address");
                return;
            }



            if (string.IsNullOrEmpty(mtdate.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "invalid datetime");

            }



           

            User userinfo;





            userinfo = new User();
            context.Users.Add(userinfo);

            string email = txtemail.Text;
            var u1 = context.Users.FirstOrDefault(u => u.Email == email);

            
            string email1 = txtemail.Text;

            var AA1 = context.Authorities.FirstOrDefault(f => f.Email == email1);


            if (u1 == null && AA1 == null)
            {
                userinfo.Name = txtname.Text;
                userinfo.Password = txtpass.Text;
                userinfo.Email = txtemail.Text;
                userinfo.PhoneNumber = txtphone.Text;
                userinfo.DOB = Convert.ToDateTime(mtdate.Text);
                userinfo.Address = richTextBox.Text;
                context.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "registration complete");

            }


            else
            {
                MetroFramework.MetroMessageBox.Show(this, "invalid emails");
                return;

            }

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void MetroLabel8_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Visible = true;
            this.Hide();
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
