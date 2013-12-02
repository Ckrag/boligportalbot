using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boligportalbot
{
    static class CrossThreadMsg
    {
        public static void CreateMessage(TextBox box, string msg, bool timer = true, bool appendText = true)
        {
            //set timer string depending on parameter
            string timerLinespacing = "  ";
            string theTime;
            string newline = "\r\n";
            if (timer) { theTime = DateTime.Now.ToString("HH:mm:ss tt"); }
            else { theTime = ""; }

            if (appendText)
            {
                if (box.InvokeRequired)
                {
                    box.Invoke(new MethodInvoker(delegate { box.Text += theTime + timerLinespacing + msg + newline; }));
                }
                else
                {
                    box.Text += theTime + timerLinespacing + msg + newline;
                }
            }
            else
            {
                if (box.InvokeRequired)
                {
                    box.Invoke(new MethodInvoker(delegate { box.Text = msg + newline; }));
                }
                else
                {
                    box.Text = msg + newline;
                }
            }
        }
    }
}
