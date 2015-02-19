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
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        public Preview(string html)
        {
            InitializeComponent();
            webBrowser1.DocumentText = html;
        }
    }
}
