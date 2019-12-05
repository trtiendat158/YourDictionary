using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
            this.btnManage.Click += BtnManage_Click;
            this.btnInfo.Click += BtnInfo_Click;
            this.btnLookUp.Click += BtnLookUp_Click;
        }

        private void BtnLookUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This word don't exist, do you want to look up this in another web ?","Nofication", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            Help info = new Help();
            info.ShowDialog();
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            Management manageW = new Management();
            manageW.ShowDialog();
        }

        
    }
}
