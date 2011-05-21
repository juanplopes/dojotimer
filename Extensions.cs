using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DojoTimer
{
    public static class Extensions
    {
        public static object Invoke<T>(this T cont, Action<T> action) where T : Control
        {
            return Invoke(cont, obj => { action(obj); return (object)null; });
        }

        public static TRet Invoke<T, TRet>(this T cont, Func<T, TRet> action) where T : Control
        {
            if (cont.InvokeRequired)
            {
                return (TRet)cont.Invoke(action, cont);
            }
            else
            {
                return action(cont);
            }
        }
    }
}
