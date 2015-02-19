using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace FoxForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b_text_box_Click(object sender, EventArgs e)
        {
            AddTextInput temp = new AddTextInput();
            temp.StartPosition = FormStartPosition.CenterParent;
            temp.Show();
        }

        private void b_drop_down_Click(object sender, EventArgs e)
        {
            AddDropDown temp = new AddDropDown();
            temp.Show();
        }


        private void exit_program()
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            } 
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            // do something
        }

        private void b_radio_Click(object sender, EventArgs e)
        {

            AddRadio temp = new AddRadio();
            temp.StartPosition = FormStartPosition.CenterParent;
            temp.Show();
        }

        private void b_hidden_input_Click(object sender, EventArgs e)
        {
            AddHiddenInput temp = new AddHiddenInput();
            temp.StartPosition = FormStartPosition.CenterParent;
            temp.Show();

        }

        private void b_submit_Click(object sender, EventArgs e)
        {
            Variables.current_form.add_html_element(new HTMLSubmitButton());
        }

        private void b_preview_Click(object sender, EventArgs e)
        {
            Variables.current_form.set_form_data(MainFormBox.Text);
            Preview temp = new Preview(Variables.current_form.generate_preview());
            temp.StartPosition = FormStartPosition.CenterParent;
            temp.Show();
            Variables.current_form.generate_preview();
        }

        private void b_generate_Click(object sender, EventArgs e)
        {
            //generate the code
        }

        private void b_save_current_form_Click(object sender, EventArgs e)
        {
            // save the form
        }

        private void b_open_saved_form_Click(object sender, EventArgs e)
        {
            // open a form
        }

        private void b_custom_HTML_Click(object sender, EventArgs e)
        {
            AddCustomHTML temp = new AddCustomHTML();
            temp.StartPosition = FormStartPosition.CenterParent;
            temp.Show();
        }

        public void add_element(string element_num, string type, string html)
        {
            string[] data = { element_num, type, html };
            MainFormBox.Text = MainFormBox.Text.Insert(MainFormBox.SelectionStart, "{" + element_num + "}");
            element_list.Items.Add(new ListViewItem(data));
        }

        private void edit_element(int index)
        {
            EditElement temp = new EditElement();
            temp.set_code(Variables.current_form.get_form_element_code(index));
            temp.set_num(index);
            temp.Show();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            exit_program();
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit_program();
        }

        private void element_list_DoubleClick(object sender, EventArgs e)
        {
            if (element_list.SelectedItems.Count > 0) edit_element(Convert.ToInt32(element_list.SelectedItems[0].SubItems[0].Text));

        

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (element_list.SelectedItems.Count > 0)
            {
                MessageBox.Show("test");
                edit_element(Convert.ToInt32(element_list.SelectedItems[0].SubItems[0].Text));
            }
        }

        public void refresh_element_list()
        {
            element_list.Items.Clear();
            for (int i = 0; i < Variables.current_form.get_last_var(); i++)
            {
                HTMLFormElement temp = Variables.current_form.get_form_element(i);
                string[] data = { Convert.ToString(i), temp.get_type(), temp.get_html() };
                element_list.Items.Add(new ListViewItem(data));
            }

        }

 




    }
}
