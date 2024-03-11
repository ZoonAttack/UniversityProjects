using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Classes
{
    internal class Utility
    {
        public static void ChangeButtonEnable(Button btn, bool enable)
        {
            btn.BeginInvoke(new MethodInvoker(() =>
            {
                btn.Enabled = enable;
                btn.Visible = enable;
            }));
        }
        public static void ChangeLabelEnable(Label lb, bool enable)
        {
            lb.BeginInvoke(new MethodInvoker(() =>
            {
                lb.Enabled = enable;
                lb.Visible = enable;
            }));
        }
    }
}
