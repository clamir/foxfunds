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
    public partial class AddTextInput : Form
    {
        public AddTextInput()
        {
            InitializeComponent();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            if (this.name.Text.Length > 0)
            {
                Variables.current_form.add_html_element(new HTMLInputBox(this.name.Text, Convert.ToInt32(this.size.Text)));
            }
            this.Hide();
            this.Dispose();
        }
    }
}
