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
    public partial class Estimation : MetroFramework.Forms.MetroForm
    {
        sqmscontext context = new sqmscontext();
        int evid;
        int sum;
        public Estimation(int evid, int sum)
        {
            InitializeComponent();
            this.evid = evid;
            this.sum = sum;
        }

        private void Estimation_Load(object sender, EventArgs e)
        {
            lbTimeRem.Text = sum.ToString();

            firsttoken();

        }
        private void firsttoken()
        {
            var lion = context.Bookings.Where(t => t.EID == evid && t.Status == "Queued").ToList();
            int minT = lion.Min(b => b.Token);
            lbToken.Text = minT.ToString();

        }
    }
}
