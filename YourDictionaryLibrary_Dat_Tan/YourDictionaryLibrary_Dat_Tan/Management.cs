﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourDictionaryLibrary_Dat_Tan
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
            this.btnClose.Click += BtnExit_Click;
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Do you want to exit ?", "Nofication", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
        }
    }
}
