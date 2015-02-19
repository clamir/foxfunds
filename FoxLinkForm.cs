using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FoxForms
{
    class FoxLinkForm
    {
        /* This class defines the form itself - each form produced by the application will use an instance of this object.
         * It contains a list of all of the elements (text box, drop down, etc) that are on the form as well as an element counter
         * (last_var). form_data is the contents of the text box on the main form but it is only updated as necessary (ie: to generate a preview).
         */

        private int last_var; // counts the variables in the form
        private string form_comment; // comment to display what the form is
        private List<HTMLFormElement> html_elements;
        private string form_data;

        public FoxLinkForm()
        {
            this.last_var = 0;
            this.html_elements = new List<HTMLFormElement>(); // holds the html elements
            this.form_comment = "Form created by blah on blah";
            this.form_data = "";
        }

        public void inc_last_var()
        {
            this.last_var++;
        }

        public void set_form_comment(string comment)
        {
            this.form_comment = comment;
        }

        public void set_form_data(string data)
        {
            this.form_data = data;
        }

        public void add_html_element(HTMLFormElement element)
        {
            this.html_elements.Add(element);
            Variables.main_form.add_element(Convert.ToString(this.get_last_var()), element.get_type(), element.get_html());
            this.inc_last_var();
        }

        public int get_last_var()
        {
            return this.last_var;
        }

        public string get_form_comment()
        {
            return this.form_comment;
        }

        public string get_form_data()
        {
            return this.form_data;
        }

        public HTMLFormElement get_form_element(int index)
        {
            return this.html_elements.ElementAt(index);
        }

        public string get_form_element_code(int index)
        {
            return this.html_elements.ElementAt(index).get_html();
        }

        public string generate_preview()
        {

            int start_token = -1;
            string temp_output = "";
            string temp_token = "";

            temp_output = "<form name=\"PMform\" action=\"https://bannerweb.rollins.edu/prod/owa/www_infotech.pkg_intl_fin_cert.p_application_submit\" method=\"POST\" onsubmit=\"return check_form(this); window.close();\">";

            for (int i = 0; i < this.form_data.Length; i++)
            {
                if (start_token < 0)
                {
                    if (this.form_data[i] != '{')
                    {

                        if (this.form_data[i] == '\n')
                        {
                            temp_output += "<p>";
                            //i++; // to skip the \n which is the next char
                        } else temp_output += this.form_data[i];
                    }
                    else start_token = i;
                }
                else
                {
                    if (this.form_data[i] != '}')
                    {
                        temp_token += this.form_data[i];
                    }
                    else
                    {
                        temp_output += this.get_form_element_code(Convert.ToInt32(temp_token));
                        temp_token = "";
                        start_token = -1;
                    }


                }

            }

            
            StreamWriter preview_file = new StreamWriter("preview.html");
            preview_file.Write(temp_output);
            preview_file.Close();

           // System.Diagnostics.Process.Start(@"preview.html");
            
            
            temp_output += "</form>";
            return temp_output;

        }
    }
}
