using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextFileDataAccessGUI
{
    public partial class FileName : Form
    {
        public FileName(string newFileName)
        {
            InitializeComponent();

            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
