using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows;
using System.IO;
using System.Net;

namespace RegexFriend
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtRegex_TextChanged_1(object sender, EventArgs e)
        {
            test_me_now();
        }

        private void richInput_TextChanged(object sender, EventArgs e)
        {
            test_me_now();
        }

        private void test_me_now()
        {
            int i = 0;
            string regex;

            regex = txtRegex.Text.ToLower();
            try
            {
                Match match = Regex.Match(richInput.Text, @regex);

                if (match.Success)
                {
                    richOutput.Text = "";
                    foreach (Match m in Regex.Matches(richInput.Text, @regex))
                    {
                        i = i + 1;
                        richOutput.AppendText(m.Value + "\n");
                    }
                    txtStatus.Text = "Found " + i.ToString() + " matches"; // Get length of matches found
                }
                else
                {
                    richOutput.Text = "";
                    txtStatus.Text = "Nothing found.";
                }
            }
            catch
            {
                richOutput.Text = "";
                txtStatus.Text = "Bad regex.";
            }
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string license;
            license = "RegexFriend - A tool to help with you little regexes\nCopyright (C) 2014  tisf\n\nThis program is free software: you can redistribute it and/or modify\nit under the terms of the GNU General Public License as published by\nthe Free Software Foundation, either version 3 of the License, or\n(at your option) any later version.\n\nThis program is distributed in the hope that it will be useful,\nbut WITHOUT ANY WARRANTY; without even the implied warranty of\nMERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the\nGNU General Public License for more details.\n\nYou should have received a copy of the GNU General Public License\nalong with this program.  If not, see http://www.gnu.org/licenses/.";
            MessageBox.Show(license, "License");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string about_text;
            about_text = "Written by Yuval tisf Nativ.\nMaintained in https://github.com/ytisf/RegexFriend";
            MessageBox.Show(about_text, "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to request a path and file name to save to.
           SaveFileDialog saveFile1 = new SaveFileDialog();

           // Initialize the SaveFileDialog to specify the RTF extension for the file.
           saveFile1.DefaultExt = "*.txt";
           saveFile1.Filter = "Text File|*.txt";

           // Determine if the user selected a file name from the saveFileDialog. 
           if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
              saveFile1.FileName.Length > 0)
           {
               // Save the contents of the RichTextBox into the file.
               richOutput.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
           }
        }

        private void loadInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "*";
            openFile1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                try
                {
                    richInput.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    txtStatus.Text = "Error: File cannot be loaded. Make sure the file is ASCII representable";
                    MessageBox.Show(ex.ToString(), "Title");
                }

            }
        }

        private void iPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRegex.Text = "(\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3})";
        }

        private void mACAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRegex.Text = "([A-Za-z0-9]{2}[\\-\\:][A-Za-z0-9]{2}[\\-\\:][A-Za-z0-9]{2}[\\-\\:][A-Za-z0-9]{2}[\\-\\:][A-Za-z0-9]{2}[\\-\\:][A-Za-z0-9]{2})";
        }

        private void internalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRegex.Text = "(([A-Za-z0-9]{2,30}\\.){1,3)[A-Za-z0-9]{2,30})";
        }

        private void domainNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRegex.Text = "(([A-Za-z0-9-_]{2,30}\\.){1,3}[A-Za-z0-9]{2,30})";
        }

        private void eMailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRegex.Text = "([A-Za-z0-9-_.]{3,30}@[A-Za-z0-9-_]{3,30}\\.([A-Za-z]{2,15}){1,3})";
        }

        private void uRLDecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a;
            a = WebUtility.UrlDecode(richInput.Text);
            richInput.Text = a;
        }

        private void uRLEncodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a;
            a = WebUtility.UrlEncode(richInput.Text);
            richInput.Text = a;
        }

        private void base64DecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try{
                byte[] encodedDataAsBytes = System.Convert.FromBase64String(richInput.Text);
                string returnValue = System.Text.ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);
                richInput.Text = returnValue;
            }
            catch{
                txtStatus.Text = "Error: Text is not BASE64 encoded";
            }
        }

        private void base64EncodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a;
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(richInput.Text);
            a = System.Convert.ToBase64String(toEncodeAsBytes);
            richInput.Text = a;
        }

        private void fullNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtRegex.Text = "([A-Z][a-z]{1,25}\\s[A-Z][a-z]{1,25})";
        }

        private void cheatSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheatSheet frm = new frmCheatSheet();
            frm.Show();
        }
    }
}
