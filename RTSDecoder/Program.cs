using System;
using System.Threading;
using System.Windows.Forms;

namespace RTSDecoder
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Thread mythread;
            
            mythread = new Thread(ThreadLoop);
            mythread.Start();
            
            Application.Run(new MainForm(mythread));
        }

        public static void ThreadLoop()
        {
            Application.Run(new Splash());           
        }
    }
}
