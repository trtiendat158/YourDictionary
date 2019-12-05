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
            this.btnDelete.Click += BtnDelete_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnClose.Click += BtnExit_Click;
            
        }
        private void load_Words()
        {
            var LoadWord = this.Business.GetWords();
            grdW.DataSource = LoadWord;
        }
        private void Null()
        {
            txtEnglishW.Text = null;
            cbType.SelectedItem = null;
            rtbMeaning.Text = null;
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (grdW.SelectedRows.Count == 1)
            {
                manage_Enable_Disable(true);
                var Word = (Word)grdW.SelectedRows[0].DataBoundItem;
                txtEnglishW.Text = Word.English_Word;
                cbType.SelectedItem = Word.Word_type;
                rtbMeaning.Text = Word.Meaning;
                this.btnSave.Click += BtnSave_Click_Edit;
                this.btnCancel.Click += BtnCancel_Click;
            }
        }

        private void BtnSave_Click_Edit(object sender, EventArgs e)
        {
            var Word = (Word)grdW.SelectedRows[0].DataBoundItem;
            var EngW = txtEnglishW.Text;
            var Type = (string)cbType.SelectedItem;
            var Meaning = rtbMeaning.Text;
            this.Business.EditWord(Word.ID, EngW, Type, Meaning);
            MessageBox.Show("Edit Compelete", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
            manage_Enable_Disable(false);
            Null();
            load_Words();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (grdW.SelectedRows.Count == 1)
            {
                var Word = (Word)grdW.SelectedRows[0].DataBoundItem;
                this.Business.DeleteWord(Word.ID);
                MessageBox.Show("Delete Compelete", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_Words();
            }
        }

        private void manage_Enable_Disable(bool IsEnable)
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
            manage_Enable_Disable(true);
            this.btnSave.Click += BtnSave_Click_Add;
            this.btnCancel.Click += BtnCancel_Click;           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            manage_Enable_Disable(false);
        }

        private void BtnSave_Click_Add(object sender, EventArgs e)
        {
            var EngW = txtEnglishW.Text;
            var Type = (string)cbType.SelectedItem;
            var Meaning = rtbMeaning.Text;

            this.Business.AddWord(EngW, Type, Meaning);
            MessageBox.Show("Create successfully", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
            manage_Enable_Disable(false);
            Null();
            load_Words();
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            load_Words();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            var LoadWord = this.Business.GetWords();
            grdW.DataSource = LoadWord;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Do you want to exit ?", "Nofication", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
        }
    }
}
