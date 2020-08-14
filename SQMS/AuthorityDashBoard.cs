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
    public partial class AuthorityDashBoard : MetroFramework.Forms.MetroForm
    {
        int eventid;
        sqmscontext context = new sqmscontext();
        public AuthorityDashBoard()
        {
            InitializeComponent();
            this.eventid = 0;
        }

        private void AuthorityDashBoard_Load(object sender, EventArgs e)
        {
            dgvDetails.AutoGenerateColumns = false;
            this.LoadDetails();
            
        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Event c = new Create_Event();
            c.ShowDialog();
        }


        private void LoadDetails()
        {
           

            var ev = context.Events.ToList();

            ev = ev.Where(e => e.AID == LoginHelper.AInfo.Akey).ToList();

            dgvDetails.DataSource = ev.ToList();
            dgvDetails.Refresh();
            

        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            if (eventid != 0)
            {
                CreateTerminal t1 = new CreateTerminal(eventid);
                t1.Visible = true;
                this.Hide();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Please select an event row first");

        }

        private void DgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                eventid = Int32.Parse(id);
                
            }
        }

        private void MetroButton5_Click(object sender, EventArgs e)
        {
            if (eventid != 0)
            {
                ManageEvent t1 = new ManageEvent(eventid);
                t1.Visible = true;
                this.Hide();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Please select an event row first");
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
