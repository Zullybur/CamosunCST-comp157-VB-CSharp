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
 * About box application with information and exit button.
 * Created by: Matthew Casiro
 * Created on: 26 May 2016
 */
namespace lab05
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }
        // Close the form
        private void btnAbout_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
