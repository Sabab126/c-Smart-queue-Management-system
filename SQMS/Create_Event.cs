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
    public partial class Create_Event : MetroFramework.Forms.MetroForm
    {

        sqmscontext context = new sqmscontext();
        public Create_Event()
        {
            InitializeComponent();
        }

        private void Create_Event_Load(object sender, EventArgs e)
        {
            
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid Name");
                return;
            }

            if (!string.IsNullOrEmpty(txtTimeReq.Text)) {
                if (!ValidationHelper.IsValidInt(txtTimeReq.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid Time Duration");
                    return;
                } }

            if (!ValidationHelper.IsValidDateTime(dtStartDay.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid Start Day");
                return;
            }


            if (!ValidationHelper.IsValidDateTime(dtEndDay.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid End Day");
                return;
            }

            if(Convert.ToDateTime(dtStartDay.Text)<DateTime.Now)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please select a future date");
                return;
            }

            if (Convert.ToDateTime(dtEndDay.Text) < Convert.ToDateTime(dtStartDay.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "End date can't be earlier than Start date");
                return;
            }

            if (LoginHelper.AInfo.MaxEvents >= LoginHelper.AInfo.EventCount)
            {
                Event ev;

                ev = new Event();
                context.Events.Add(ev);

                ev.Ename = txtName.Text;
                ev.Edetails = txtDetails.Text;

                if (!string.IsNullOrEmpty(txtTimeReq.Text))
                {
                    ev.TimeRequired = Int32.Parse(txtTimeReq.Text);
                }
                ev.EStartDay = Convert.ToDateTime(dtStartDay.Text);
                ev.EEndDate = Convert.ToDateTime(dtEndDay.Text);
                ev.TerminalCount = 0;
                ev.AID = LoginHelper.AInfo.Akey;
                context.SaveChanges();
                MetroFramework.MetroMessageBox.Show(this, "Event Creation Successful");
                //LoginHelper.AInfo.EventCount++;
            }
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            AuthorityDashBoard a1 = new AuthorityDashBoard();
            a1.Visible = true;
            this.Visible = false;
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
