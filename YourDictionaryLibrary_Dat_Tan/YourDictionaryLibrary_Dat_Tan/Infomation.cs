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
    public partial class Infomation : Form
    {
        public Infomation()
        {
            InitializeComponent();
            this.btnOk.Click += BtnOk_Click;
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
