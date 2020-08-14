using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQMS
{
    class ValidationHelper
    {
        public static bool IsValidInt(string val)
        {
            try
            {
                int d = Int32.Parse(val);
                return true;

            }
            catch (Exception e)
            {
                return false;

            }
        }

        public static bool IsValidDateTime(string val)
        {
            try
            {
                DateTime d = DateTime.Parse(val);
                return true;

            }
            catch (Exception e)
            {
                return false;

            }
        }
    }
}
