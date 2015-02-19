using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoxForms
{
    class ValuePairs
    {
        /*
         * These objects are used to store the value and display name pairs for drop down lists and radio buttons.
         * They're passed from the forms used to create them (AddDropDown and AddRadio) to the HTMLDropdown and HTMLRadioButton
         * in lists as parameters.
         */

        private string value, display;

        public ValuePairs(string v, string d)
        {
            this.value = v;
            this.display = d;
        }

        public string get_value()
        {
            return this.value;
        }

        public string get_display()
        {
            return this.display;
        }

        public void set_value(string v)
        {
            this.value = v;
        }

        public void set_display(string d)
        {
            this.value = d;
        }
    }
}
