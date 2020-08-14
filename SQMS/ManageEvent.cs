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
    public partial class ManageEvent : MetroFramework.Forms.MetroForm
    {

        sqmscontext context = new sqmscontext();

        int eid;
        public ManageEvent(int eid)
        {
            InitializeComponent();
            this.eid = eid;
        }

        private void ManageEvent_Load(object sender, EventArgs e)
        {
            dgvDetails.AutoGenerateColumns = false;
            this.LoadDetails();
        }

        private void LoadDetails()
        {


            var bk = context.Bookings.ToList();

            bk = bk.Where(e => e.EID == eid).ToList();

            dgvDetails.DataSource = bk.ToList();
            dgvDetails.Refresh();


        }

        private void MetroButton6_Click(object sender, EventArgs e)
        {
            AuthorityDashBoard a1 = new AuthorityDashBoard();
            a1.Visible = true;
            this.Visible = false;
        }

        private void MetroButton5_Click(object sender, EventArgs e)
        {
            var lion = context.Bookings.FirstOrDefault(t => t.EID == eid && t.Status == "Queued");
            if (lion != null)
            {
                QueueExecution q1 = new QueueExecution(eid);
                q1.Visible = true;
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Queue is finished");
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            LoadDetails();
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
