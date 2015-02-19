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
    public partial class AddRadio : Form
    {
        public AddRadio()
        {
            InitializeComponent();
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            List<ValuePairs> temp_list = new List<ValuePairs>();

            for (int i = 0; i < this.values.RowCount - 1; i++)
            {
                ValuePairs temp_pair = new ValuePairs(Convert.ToString(this.values.Rows[i].Cells[0].Value), Convert.ToString(this.values.Rows[i].Cells[1].Value));
                temp_list.Add(temp_pair);
            }

            Variables.current_form.add_html_element(new HTMLRadioButtons(this.name.Text, temp_list));

            this.Hide();
            this.Dispose();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
