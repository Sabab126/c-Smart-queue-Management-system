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
    public partial class UserDashBoard : MetroFramework.Forms.MetroForm
    {
        sqmscontext context = new sqmscontext();
        int bookingid;
        int token;
        public UserDashBoard()
        {
            InitializeComponent();
            bookingid = 1;

        }

        private void UserDashBoard_Load(object sender, EventArgs e)
        {
            dgvDetails.AutoGenerateColumns = false;
            LoadDetails();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            Add_Booking ab = new Add_Booking();
            ab.Visible = true;
            this.Hide();
        }

        private void LoadDetails()
        {


            var con = context.Bookings.ToList();

            //if (key != "")

            // con = con.Where(c => c.Name.ToUpper().Contains(key.ToUpper())).ToList();
            con = context.Bookings.Where(u => u.UID == LoginHelper.UInfo.Userkey).ToList();

            dgvDetails.DataSource = con.ToList();
            dgvDetails.Refresh();

            //  if (con.Count > 0)
            //    this.LoadDetail(con.First().Id);


        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            LoginHelper.UInfo = null;
            LoginForm l1 = new LoginForm();
            l1.Visible = true;
            this.Visible = false;
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            if (bookingid != 0)
            {
                var a = context.Bookings.FirstOrDefault(ev => ev.BID == bookingid);
                int evid = a.EID;
                var list = context.Bookings.Where(n => n.EID == evid && n.Token < token && n.Status == "Queued").ToList();

                if (list == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Your token has already expired");
                    return;
                }

                var b = context.Events.FirstOrDefault(ev => ev.EID == evid);
                int termCount=b.TerminalCount;
                int sum=list.Skip(termCount).Sum(m => m.TimeRequired);

                if (termCount != 0)
                {
                    sum = sum / termCount;
                    Estimation e1 = new Estimation(evid, sum);
                    e1.Visible = true;
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Estimation is not available yet");
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Please select a booking row first");
        }

        private void DgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tk = dgvDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                bookingid = Int32.Parse(id);
                token = Int32.Parse(tk);

            }
        }
    }
}
