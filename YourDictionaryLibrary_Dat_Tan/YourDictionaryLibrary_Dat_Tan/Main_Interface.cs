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
    public partial class Main_Interface : Form
    {
        private Words_Management Business;
        public Main_Interface()
        {
            InitializeComponent();
            this.Business = new Words_Management();
            this.Load += Main_Interface_Load;
            this.btnManage.Click += BtnManage_Click;
            this.btnInfo.Click += BtnInfo_Click;
            this.btnLookUp.Click += BtnLookUp_Click;
        }
        private void LoadData()
        {
            this.cbWord.DataSource = this.Business.GetWords();
            this.cbWord.DisplayMember = "English_Word";
            this.cbWord.ValueMember = "ID";
        }
        private void Main_Interface_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnLookUp_Click(object sender, EventArgs e)
        {
            if(cbWord.SelectedItem == null)
            {
                if(MessageBox.Show("This word don't exist, do you want to look up this in another web ?", "Nofication", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var Browser = new Browser();
                    Browser.ShowDialog();
                }
            }
            else
            {
                var data = cbWord.SelectedItem as Word;
                txtType.Text = data.Word_type;
                txtMeaning.Text = data.Meaning;
            }          
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            Infomation info = new Infomation();
            info.ShowDialog();
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            Management manageW = new Management();
            manageW.ShowDialog();
            LoadData();
        }

        private void Main_Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are You Sure Want To Exit", "Nofication", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)!= DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
