using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FoxForms
{
    public partial class EditElement : Form
    {
        private int element_num;

        public EditElement()
        {
            InitializeComponent();
        }

        public void set_code(string code)
        {
            html_code.Text = code;
        }

        public void set_num(int num)
        {
            this.element_num = num;
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            Variables.current_form.get_form_element(this.element_num).set_html(this.html_code.Text);
            Variables.main_form.refresh_element_list();
            this.Hide();
            this.Dispose();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }


    }
}
