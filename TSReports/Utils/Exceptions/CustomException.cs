using System;
using System.Windows.Forms;

namespace TSReports.Utils.Exceptions
{
    class CustomException : Exception
    { 
        public CustomException(Exception e)
            : base() {
            MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
