using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_store2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.Run(new Employee_Form());
            Application.Run(new Product_form());
            Application.Run(new supplier_form());
            Application.Run(new Form2());
            Application.Run(new Pet_Form());
        }
    }
}
