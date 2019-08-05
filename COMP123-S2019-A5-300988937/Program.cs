using COMP123_S2019_A5_300988937.Data;
using COMP123_S2019_A5_300988937.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_300988937
{
    enum FormName
    {
        SPLASH_FORM,
        START_FORM,
        SELECT_FORM,
        PRODUCT_INFO_FORM,
        ORDER_FORM,
        ABOUT_FORM
    }
    static class Program
    {
        public static Product product;
        public static Dictionary<FormName, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms = new Dictionary<FormName, Form>();
            //instantiate all forms here
            Forms.Add(FormName.SPLASH_FORM, new SplashForm());
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.SELECT_FORM, new SelectForm());
            Forms.Add(FormName.PRODUCT_INFO_FORM, new ProductInfoForm());
            Forms.Add(FormName.ORDER_FORM, new OrderForm());
            Forms.Add(FormName.ABOUT_FORM, new AboutForm());
            product = new Product();
            Application.Run(Forms[FormName.START_FORM]);
        }
    }
}
