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
    public partial class CreateTerminal : MetroFramework.Forms.MetroForm
    {
        sqmscontext context = new sqmscontext();
        int eid;
        public CreateTerminal(int eid)
        {
            InitializeComponent();
            this.eid = eid;
        }

        private void CreateTerminal_Load(object sender, EventArgs e)
        {
            dtStartTime.ShowUpDown = true;
            dtStartTime.CustomFormat = "HH:mm";
            dtEndTime.ShowUpDown = true;
            dtEndTime.CustomFormat = "HH:mm";
        }

        private void DtStartDay_MouseDown(object sender, MouseEventArgs e)
        {
            //dtStartTime.CustomFormat = "HH:mm";
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid Name");
                return;
            }

           
                Terminal ter;

                ter = new Terminal();
                context.Terminals.Add(ter);
                ter.Tname = txtName.Text;
                ter.TDetails = txtDetails.Text;

                ter.TStartTime = Convert.ToDateTime(dtStartTime.Text);
                ter.TEndTime = Convert.ToDateTime(dtEndTime.Text);
                ter.EID = this.eid;
                
                var ev = context.Events.FirstOrDefault(c => c.EID == eid);
                ev.TerminalCount++;

                context.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Terminal Creation Successful");
        }
        

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            AuthorityDashBoard a1 = new AuthorityDashBoard();
            a1.Visible = true;
            this.Hide();
            
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            LoginHelper.AInfo = null;
            LoginForm l1 = new LoginForm();
            l1.Visible = true;
            this.Visible = false;
        }
    }
    
}
