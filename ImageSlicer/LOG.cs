using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ImageSlicer
{
    public static class LOG
    {
        public static void ex(Exception ex)
        {
            string err = ex.Message + "\r\n" + ex.StackTrace;
            MessageBox.Show(err);
        }

        public static void msg(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
