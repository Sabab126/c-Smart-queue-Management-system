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
    public partial class Add_Booking : MetroFramework.Forms.MetroForm
    {

        sqmscontext context = new sqmscontext();
        public Add_Booking()
        {
            InitializeComponent();
        }
        private void Add_Booking_Load(object sender, EventArgs e)
        {
            this.Init();
            txtTimeReq.ReadOnly = true;

        }
        private void Init()
        {
            comAuthority.SelectedItem = null;
            comAuthority.DataSource = context.Authorities.ToList();
            comAuthority.DisplayMember = "AName";
        }

        private void comEvent_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comAuthority_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comAuthority.SelectedItem != null)
            {
                comEvent.SelectedItem = null;
                Authority a;
                a = new Authority();
                a = (Authority)comAuthority.SelectedItem;
                var elist = context.Events.Where(m => m.AID ==a.Akey).ToList();
                comEvent.DataSource = elist.ToList();
                comEvent.DisplayMember = "Ename";

            }
            
            

        }

        private void Add_Booking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


            if (!ValidationHelper.IsValidInt(txtTimeReq.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Select number of minutes");
                return;
            }


            
            Booking book;

            book = new Booking();

            context.Bookings.Add(book);
            var ev = (Event)comEvent.SelectedItem;
            book.BookingDetails = "";
            book.EID = ev.EID;
            book.UID = LoginHelper.UInfo.Userkey;
            book.Status = "Queued";
            book.TimeRequired = Int32.Parse(txtTimeReq.Text);

            //var a = context.Bookings.Where(c => c.EID==ev.EID).ToList();

            int maxt = context.Bookings.Where(c => c.EID == ev.EID).Select(c => c.Token).DefaultIfEmpty(0).Max();

            book.Token = maxt + 1;

            context.SaveChanges();

            MetroFramework.MetroMessageBox.Show(this, "Booking Created Successfully");

            this.Init();



         

        }

        private void Add_Booking_Load_1(object sender, EventArgs e)
        {
            this.Init();

        }

        private void ComEvent_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtTimeReq.Text = "";
            if (comEvent.SelectedItem != null)
            {
                Event ev;
                ev = new Event();
                ev = (Event)comEvent.SelectedItem;
                if (ev.TimeRequired == null)
                    txtTimeReq.ReadOnly = false;
                else
                {
                    txtTimeReq.Text = ev.TimeRequired.ToString();
                    txtTimeReq.ReadOnly = true;
                }

            }
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            UserDashBoard u1 = new UserDashBoard();
            u1.Visible = true;
            this.Hide();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            LoginHelper.UInfo = null;
            LoginForm l1 = new LoginForm();
            l1.Visible = true;
            this.Visible = false;
        }
    }
}
