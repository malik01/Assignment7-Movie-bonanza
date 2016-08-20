using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7_Movie_Bonanza
{
    /**
     * Author Shahzaib Malik
     * Student Number 300852792 
     * Course COMP-123
     * Semester 2016(summer)
     * Date Aug 17 2016
     */ 
    public static class Program
    {
        public static SelectionForm reopenselectionform;
        public static SplashForm splashsrceen;
        public static OrderForm ordercreen;
        public static SelectionForm selectionscreen;
        public static StreamForm streamscreen;
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            streamscreen = new StreamForm();
            ordercreen = new OrderForm();
            selectionscreen = new SelectionForm();
            splashsrceen = new SplashForm();
            Application.Run(splashsrceen);
        }
    }
}
