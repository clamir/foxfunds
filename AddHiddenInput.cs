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
    public partial class AddHiddenInput : Form
    {
        public AddHiddenInput()
        {
            InitializeComponent();
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            if (name.Text.Length > 0) Variables.current_form.add_html_element(new HTMLHiddenInput(name.Text));
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
