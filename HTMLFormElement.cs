using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoxForms
{
    class HTMLFormElement
    {
        /* this class is used to define each html element (drop down, text box, etc). There are classes for each major type that inherit element
         * from the parent class.
         */

        private string html_value;
        private string html_type;

        public HTMLFormElement()
        {
            this.html_value = "";
            this.html_type = "Custom";
        }
        public HTMLFormElement(string html)
        {
            this.html_value = html;
            this.html_type = "Custom";
        }

        public void set_html(string html)
        {
            this.html_value = html;
        }

        public void set_type(string type)
        {
            this.html_type = type;
        }
        public string get_html()
        {
            return this.html_value;
        }

        public string get_type()
        {
            return this.html_type;
        }
        public string to_string()
        {
            return this.html_type;
        }
    }

    class HTMLInputBox : HTMLFormElement
    {
        private string name;
        private int size;

        public HTMLInputBox(string name, int size)
        {
            this.name = name;
            this.size = size;
            this.set_type("Text Input");
            this.refresh_code();
        }

        private void refresh_code()
        {
            this.set_html("<input type=\"text\" size=\""+this.get_size()+"\" name=\""+this.get_name()+"\"/>");
        }

        public string get_name()
        {
            return this.name;
        }

        public int get_size()
        {
            return this.size;
        }

    }

    class HTMLHiddenInput : HTMLFormElement
    {

        // <input type="hidden" name="i_pidm" value="'||i_pidm||'"
        private string name;

        public HTMLHiddenInput(string name)
        {
            this.name = name;
            this.set_type("Hidden");
            this.refresh_code();
        }

        private void refresh_code()
        {
            this.set_html("<input type=\"hidden\" name=\"" + this.get_name() + "\" value=\"'||" + this.get_name() + "||'\"");
        }

        public string get_name()
        {
            return this.name;
        }
    }

    class HTMLSubmitButton : HTMLFormElement
    {
        // <input type="submit" value=" SUBMIT ">
        public HTMLSubmitButton()
        {
            this.set_html("<input type=\"submit\" value=\" SUBMIT \">");
            this.set_type("Submit");
        }
    }

    class HTMLDropDown : HTMLFormElement
    {
        private List<ValuePairs> drop_down_values;
        private string name;

        public HTMLDropDown(string name, List<ValuePairs> list)
        {
            this.name = name;
            this.drop_down_values = list;
            this.set_type("Drop Down");
            this.refresh_code();
        }
        public string get_name()
        {
            return this.name;
        }
        public void refresh_code()
        {
            string temp = "<select name=\"" +  this.get_name() + "\" size=\"1\" id=\"" + this.get_name() + "\">\r\n";
            temp += "     <option value=\"0\" selected=\"selected\">Select </option>\r\n";

            for (int i = 0; i < drop_down_values.Count; i++)
            {
                temp += "     <option value=\"" +drop_down_values[i].get_value() + "\">" + drop_down_values[i].get_display() + "</option>\r\n";
            }

            temp += "</select>";
            this.set_html(temp);
        }

    }

    class HTMLRadioButtons : HTMLFormElement
    {
        private List<ValuePairs> radio_button_values;
        private string name;

        public HTMLRadioButtons(string name, List<ValuePairs> list)
        {
            this.name = name;
            this.radio_button_values = list;
            this.set_type("Radio");
            this.refresh_code();
        }

        public string get_name()
        {
            return this.name;
        }

        public void refresh_code()
        {
            /*
             * <input type="radio" name="sex" value="male" checked>Male
<br>
<input type="radio" name="sex" value="female">Female
</form>
             * /
             */
            string temp = "";

            for (int i = 0; i < radio_button_values.Count; i++)
            {
                temp += "<input type=\"radio\" name=\"" + this.get_name() + "\" value=\""+ this.radio_button_values[i].get_value() +"\">"+this.radio_button_values[i].get_display();
            }
            this.set_html(temp);
        }
    }
}
