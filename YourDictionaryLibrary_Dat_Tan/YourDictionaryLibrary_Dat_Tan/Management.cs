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
    public partial class Management : Form
    {
        private Words_Management Business;
        public Management()
        {
            InitializeComponent();
            this.Business = new Words_Management();
            this.Load += Management_Load;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnReload.Click += BtnReload_Click;
            this.btnClose.Click += BtnExit_Click;
            
        }
        private void manage_button(bool IsEnable)
        {
            if(IsEnable == true)
            {
                this.btnSave.Enabled = true;
                this.btnCancel.Enabled = true;
            }
            else
            {
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
            }
        } 
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            manage_button(true);
            this.btnSave.Click += BtnSave_Click;
            this.btnCancel.Click += BtnCancel_Click;           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            manage_button(false);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var EngW = txtEnglishW.Text;
            var Type = (string)cbType.SelectedItem;
            var Meaning = rtbMeaning.Text;

            this.Business.AddWord(EngW, Type, Meaning);
            MessageBox.Show("Update successfully", "Notication");
            manage_button(false);
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            var LoadWord = this.Business.GetWords();
            grdW.DataSource = LoadWord;
        }

        private void Management_Load(object sender, EventArgs e)
        {
            var LoadWord = this.Business.GetWords();
            grdW.DataSource = LoadWord;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //4444
            this.Close();
            MessageBox.Show("Do you want to exit ?", "Nofication", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
        }
    }
}
