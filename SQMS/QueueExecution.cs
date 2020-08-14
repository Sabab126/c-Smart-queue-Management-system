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
    public partial class QueueExecution : MetroFramework.Forms.MetroForm
    {
        sqmscontext context = new sqmscontext();
        int eid;
        public QueueExecution(int eid)
        {
            InitializeComponent();
            this.eid = eid;
        }

        private void Init()
        {
            comboTerminal.SelectedItem = null;
            comboTerminal.DataSource = context.Terminals.Where(t=> t.EID==eid).ToList();
            comboTerminal.DisplayMember = "Tname";
        }

        private void QueueExecution_Load(object sender, EventArgs e)
        {
            //this.Visible = true;
            this.Init();
            firsttoken();
            

        }

        private void firsttoken() {

            try
            {
                var lion = context.Bookings.Where(t => t.EID == eid && t.Status == "Queued").ToList();
                int minT = lion.Min(b => b.Token);
                lbToken.Text = minT.ToString();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Queue is finished");
                //this.Visible = false;
            }
            }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

            if (comboTerminal.SelectedItem == null) {
                MetroFramework.MetroMessageBox.Show(this, "Please select a terminal first");
                return;
            }
            int a = Int32.Parse(lbToken.Text);


            var lion = context.Bookings.FirstOrDefault(t => t.EID == eid && t.Token== a);

            if (lion != null)
            {
                lion.Status = "Completed";
                lbToken.Text = (Int32.Parse(lbToken.Text) + 1).ToString();
                context.SaveChanges();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Queue is finished");
            }
            
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            if (comboTerminal.SelectedItem == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please select a terminal first");
                return;
            }

            int a = Int32.Parse(lbToken.Text);
            var lion = context.Bookings.FirstOrDefault(t => t.EID == eid && t.Token == a);
            if (lion != null)
            {
                lion.Status = "Defaulter";
                lbToken.Text = (Int32.Parse(lbToken.Text) + 1).ToString();
                context.SaveChanges();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Queue is finished");
            }
        }
    }
}
