using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7_Movie_Bonanza
{
    public static class Program
    {
        public static SplashForm splashsrceen;
        public static SelectionForm selectionscreen;
        public static OrderForm ordercreen;
        public static StreamForm streamscreen;
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            selectionscreen = new SelectionForm();
            splashsrceen = new SplashForm();
            
            Application.Run(splashsrceen);
        }
    }
}
