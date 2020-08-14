using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQMS
{
    public partial class Booking
    {
        public string EventName
        {
            get
            {
                if (this.Event == null)
                {
                    return "";
                }
                return this.Event.Ename;

            }
        }

        public string StartDay
        {
            get
            {
                if (this.Event == null)
                {
                    return "";
                }
                return this.Event.EStartDay.ToShortDateString().ToString();

            }
        }
    }
}
