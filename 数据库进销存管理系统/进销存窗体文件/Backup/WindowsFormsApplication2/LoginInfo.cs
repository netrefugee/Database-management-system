using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class LoginInfo
    {
        private static string _bh;
        public static string Bh
        {
            get { return _bh; }
            set { _bh = value; }
        }
        private static string _xm;
        public static string Xm
        {
            get { return _xm; }
            set { _xm = value; }
        }
        private static string _qx;
        public static string Qx
        {
            get { return _qx; }
            set { _qx = value; }
        }
    }
}
