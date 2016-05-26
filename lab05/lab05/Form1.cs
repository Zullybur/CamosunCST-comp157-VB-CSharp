using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

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
                this.richTextBox1.SelectionLength = 1;
                for (int i = start; i < start + length - 1; i++)
                {
                    this.richTextBox1.SelectionStart = i;
                    if ((richTextBox1.SelectionFont.Style & FontStyle.Bold) != FontStyle.Bold)
                    {
                        allStyled = false;
                    }
                    f = richTextBox1.Font;
                    s = richTextBox1.SelectionFont.Style;
                    s = s | FontStyle.Bold;

                    richTextBox1.SelectionFont = new Font(f.FontFamily, f.Size, s);
                }
                if (allStyled)
                {
                    for (int i = start; i < start + length - 1; i++)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            goToURL();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "McBrowser")
            {
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                pasteToolStripMenuItem.Enabled = false;
            } else {
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                pasteToolStripMenuItem.Enabled = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void txbURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goToURL();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void goToURL()
        {
            string strUri = txbURL.Text;
            if (!strUri.ToLower().StartsWith("http://") && !strUri.ToLower().StartsWith("https://"))
            {
                strUri = "http://" + strUri;
                
            }
            try
            {
                webBrowser1.Navigate(txbURL.Text);
                if (webBrowser1.Url != null)
                {
                    txbURL.Text = webBrowser1.Url.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning! Error occured with the web browser:\n"+ex.ToString(),
                    "Browser Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("http://camosun.ca");
            goToURL();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!saveToolStripMenuItem.Enabled) { saveToolStripMenuItem.Enabled = true; }
            OpenFileDialog fD = new OpenFileDialog();
            string custom;
            if (tabControl1.SelectedTab.Text == "McBrowser")
            {
                fD.Filter = "HTML Files (.html)|*.html";
                custom = "file:///";
                if (fD.ShowDialog() == DialogResult.OK)
                {
                    txbURL.Text = custom + fD.FileName;
                    webBrowser1.Navigate(custom + fD.FileName);
                }
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
                        MessageBox.Show("Unsupported file type. Please choose a .txt or .rtf file.",
                            "File Type Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(fileName, fileType);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sD = new SaveFileDialog();
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
                    } else {
                        fileType = RichTextBoxStreamType.PlainText;
                    }
                }
                richTextBox1.SaveFile(sD.FileName, fileType);
            }
                
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
    }
}
