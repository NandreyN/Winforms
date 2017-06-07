using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsViewFile
{
    public partial class SearchForm : Form
    {
        public string SearchBoxContent => SearchBox.Text;

        public SearchForm()
        {
            InitializeComponent();
        }
    }
}
