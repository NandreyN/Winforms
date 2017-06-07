using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormsViewFile
{
    public partial class Form1 : Form
    {
        private SearchForm sForm;
        public Form1()
        {
            sForm = new SearchForm();;
            sForm.Show();
            InitializeComponent();
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (var reader = new StreamReader(myStream, Encoding.UTF8))
                        {
                            string value = reader.ReadToEnd();
                            textBox.Text = value;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string srchData = sForm.SearchBoxContent;
            // Perform searching
            bool found = textBox.Text.Contains(srchData);
            if (found)
            {
                int index = textBox.Text.IndexOf(srchData, StringComparison.Ordinal);
                textBox.SelectionStart = index;
                textBox.SelectionLength = srchData.Length;
                textBox.Focus();
                textBox.ScrollToCaret();
            }
            else
                MessageBox.Show(@"Not found");
        }
    }
}
