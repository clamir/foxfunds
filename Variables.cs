
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoxForms
{
    class Variables
    {
        // this class is used to hold global variables so that they're available from all classes in the app
        // so, anywhere you use "Variables.current_form.SOMETHING" it's using this class as a pass through to reach
        // the current instance of FoxLinkForm and call a method or variable from within it.

        public static MainWindow main_form;
        public static FoxLinkForm current_form = new FoxLinkForm();


        public static void create_main_form()
        {
            main_form = new MainWindow();
        }
    }

    
}
