using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;
using System.Runtime.InteropServices;
using System.Threading;

namespace Preview
{
    class WinAPI
    {

        public const Int32 WM_CLOSE = 0x0010;
        [DllImport("user32.dll", SetLastError = true)]

        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, int len, StringBuilder st);

        public void DemoKiller(){
           
                IntPtr ptr = WinAPI.FindWindow(null, "Demo");
                StringBuilder st = new StringBuilder(40);
                
                    WinAPI.SendMessage(ptr, WinAPI.WM_CLOSE, 0, st);
   
        }

}
}
