using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Text editor and web browser application with basic functionality.
 * Created by: Matthew Casiro
 * Created on: 26 May 2016
 */
namespace lab05
{
    public partial class Form1 : Form
    {
        RichTextBoxStreamType fileType;
        string fileName;
        public Form1()
        {
            InitializeComponent();
        }
        // Bold the selected text unless ALL text is bolded - then un-bold it
        private void btnBold_Click(object sender, EventArgs e)
        {
            Font f;
            FontStyle s;
            Boolean allStyled = true;
            int start, length;

            start = this.richTextBox1.SelectionStart;
            length = this.richTextBox1.SelectionLength;

            if (length != 0)
            {
                // Add bold to text and track if any text was unbolded initially
                for (int i = start; i < start + length; i++)
                {
                    this.richTextBox1.SelectionStart = i;
                    this.richTextBox1.SelectionLength = 1;
                    if ((richTextBox1.SelectionFont.Style & FontStyle.Bold) != FontStyle.Bold)
                    {
                        allStyled = false;
                    }
                    f = richTextBox1.Font;
                    s = richTextBox1.SelectionFont.Style;
                    s = s | FontStyle.Bold;

                    richTextBox1.SelectionFont = new Font(f.FontFamily, f.Size, s);
                }
                // If all the text was styled then remove the style instead
                if (allStyled)
                {
                    for (int i = start; i < start + length; i++)
                    {
                        this.richTextBox1.SelectionStart = i;

                        f = richTextBox1.Font;
                        s = richTextBox1.SelectionFont.Style;
                        s = s ^ FontStyle.Bold;

                        richTextBox1.SelectionFont = new Font(f.FontFamily, f.Size, s);
                    }
                }
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = length;
                richTextBox1.Focus();
            }
        }
        // Italicize the selected text unless ALL text is italic - then un-italic it
        private void btnItalics_Click(object sender, EventArgs e)
        {
            Font f;
            FontStyle s;
            Boolean allStyled = true;
            int start, length;

            start = this.richTextBox1.SelectionStart;
            length = this.richTextBox1.SelectionLength;

            if (length != 0)
            {
                // Add italics to text and track if any text was not italic initially
                this.richTextBox1.SelectionLength = 1;
                for (int i = start; i < start + length - 1; i++)
                {
                    this.richTextBox1.SelectionStart = i;
                    // Check if the entire selection is styled (character by character) and un-style afterwards if so
                    if ((richTextBox1.SelectionFont.Style & FontStyle.Italic) != FontStyle.Italic)
                    {
                        allStyled = false;
                    }
                    f = richTextBox1.Font;
                    s = richTextBox1.SelectionFont.Style;
                    s = s | FontStyle.Italic;

                    richTextBox1.SelectionFont = new Font(f.FontFamily, f.Size, s);
                }
                // If all the text was styled then remove the style instead
                if (allStyled)
                {
                    for (int i = start; i < start + length - 1; i++)
                    {
                        this.richTextBox1.SelectionStart = i;

                        f = richTextBox1.Font;
                        s = richTextBox1.SelectionFont.Style;
                        s = s ^ FontStyle.Italic;

                        richTextBox1.SelectionFont = new Font(f.FontFamily, f.Size, s);
                    }
                }
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = length;
                richTextBox1.Focus();
            }
        }
        // Underline the selected text unless ALL text is underlined - then un-underline it
        private void btnUnderline_Click(object sender, EventArgs e)
        {
            Font f;
            FontStyle s;
            Boolean allStyled = true;
            int start, length;

            start = this.richTextBox1.SelectionStart;
            length = this.richTextBox1.SelectionLength;

            if (length != 0)
            {
                // Add underline to text and track if any text was not underlined initially
                this.richTextBox1.SelectionLength = 1;
                for (int i = start; i < start + length - 1; i++)
                {
                    this.richTextBox1.SelectionStart = i;
                    // Check if the entire selection is styled (character by character) and un-style if so.
                    if ((richTextBox1.SelectionFont.Style & FontStyle.Underline) != FontStyle.Underline)
                    {
                        allStyled = false;
                    }
                    f = richTextBox1.Font;
                    s = richTextBox1.SelectionFont.Style;
                    s = s | FontStyle.Underline;

                    richTextBox1.SelectionFont = new Font(f.FontFamily, f.Size, s);
                }
                if (allStyled)
                {
                    // If all the text was styled then remove the style instead
                    for (int i = start; i < start + length - 1; i++)
                    {
                        this.richTextBox1.SelectionStart = i;
                        
                        f = richTextBox1.Font;
                        s = richTextBox1.SelectionFont.Style;
                        s = s ^ FontStyle.Underline;

                        richTextBox1.SelectionFont = new Font(f.FontFamily, f.Size, s);
                    }
                }
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = length;
                richTextBox1.Focus();
            }
        }
        // Go to the previous browser page
        private void button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        // Go to the browser page as indicated in the txbURL
        private void btnGo_Click(object sender, EventArgs e)
        {
            goToURL();
        }
        // Copy text to clipboard
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        // Adjust menu options based on tab selection
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "McBrowser")
            {
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                pasteToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
            } else {
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                pasteToolStripMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
            }
        }
        // Display an about form on selection
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
        // Navigate to the URL in txbURL when the enter key is pressed
        private void txbURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goToURL();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        // Generic code for navigating to URL
        private void goToURL()
        {
            string strUri = txbURL.Text;
            // Correct page address header if required
            if (!strUri.ToLower().StartsWith("http://") && !strUri.ToLower().StartsWith("https://"))
            {
                strUri = "http://" + strUri;
                
            }
            try
            {
                webBrowser1.Navigate(strUri);
                txbURL.Text = strUri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning! Error occured with the web browser:\n"+ex.ToString(),
                    "Browser Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        // Load the form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Go to an initial web page
            goToURL();
        }
        // Open a file and load in to the application
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!saveToolStripMenuItem.Enabled) { saveToolStripMenuItem.Enabled = true; }
            OpenFileDialog fD = new OpenFileDialog();
            string custom;
            // Open a file to the web browser
            if (tabControl1.SelectedTab.Text == "McBrowser")
            {
                fD.Filter = "HTML Files (.html)|*.html";
                custom = "file:///";
                if (fD.ShowDialog() == DialogResult.OK)
                {
                    txbURL.Text = custom + fD.FileName;
                    webBrowser1.Navigate(custom + fD.FileName);
                }
            // Open a file to the text editor
            } else {
                fD.Filter = "All Files (*.*)|*.*|Text Files (.txt)|*.txt|Rich Text Files (.rtf)|*.rtf";
                if (fD.ShowDialog() == DialogResult.OK)
                {
                    fileName = fD.FileName;
                    string[] customArray = fileName.Split('.');
                    if (customArray[customArray.Length - 1].Equals("txt"))
                    {
                        fileType = RichTextBoxStreamType.PlainText;
                        richTextBox1.LoadFile(fileName, fileType);
                    } else if (customArray[customArray.Length - 1].Equals("rtf")) {
                        fileType = RichTextBoxStreamType.RichText;
                        richTextBox1.LoadFile(fileName, fileType);
                    } else {
                        // Prompt user if incorrect file is chosen
                        MessageBox.Show("Unsupported file type. Please choose a .txt or .rtf file.",
                            "File Type Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Refresh the webpage
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        // Save the page/file to the current file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(fileName, fileType);
        }
        // Save the file/page to a new file
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sD = new SaveFileDialog();
            if (tabControl1.SelectedTab.Text == "McEditor")
            {
                sD.Filter = "Text Files (.txt)|*.txt|Rich Text Files (.rtf)|*.rtf";
                if (!saveToolStripMenuItem.Enabled) { saveToolStripMenuItem.Enabled = true; }
                if (sD.ShowDialog() == DialogResult.OK)
                {
                    if (sD.FileName.Length > 0)
                    {
                        string[] tmp = sD.FileName.Split('.');
                        if (tmp[tmp.Length - 1] == "rtf")
                        {
                            fileType = RichTextBoxStreamType.RichText;
                        }
                        else {
                            fileType = RichTextBoxStreamType.PlainText;
                        }
                    }
                    richTextBox1.SaveFile(sD.FileName, fileType);
                }
            } else {
                sD.Filter = "HTML File (.html)|*.html";
                if (!saveToolStripMenuItem.Enabled) { saveToolStripMenuItem.Enabled = true; }
                if (sD.ShowDialog() == DialogResult.OK)
                {
                    if (sD.FileName.Length > 0)
                    {
                        string[] tmp = sD.FileName.Split('.');
                        if (tmp[tmp.Length - 1] == "rtf")
                        {
                            fileType = RichTextBoxStreamType.RichText;
                        }
                        else {
                            fileType = RichTextBoxStreamType.PlainText;
                        }
                    }
                    richTextBox1.SaveFile(sD.FileName, fileType);
                }
            }
        }
        // remove the text and place it in the clipboard
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        // paste text from the clipboard
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        // Go back to the future
        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
