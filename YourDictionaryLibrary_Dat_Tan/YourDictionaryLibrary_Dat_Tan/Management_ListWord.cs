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
    public partial class Management_ListWord : Form
    {
        private Words_Management Business;
        public Management_ListWord()
        {
            InitializeComponent();
            this.Business = new Words_Management();
            this.Load += Management_Load;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnClose.Click += BtnClose_Click;
            this.grdW.CellClick += GrdW_CellClick;
            this.btnSearch.Click += BtnSearch_Click;
            this.txtSearch.KeyDown += TxtSearch_KeyDown;
        }
        private bool CheckNull()
        {
            if (txtEnglishW.Text == "" || cbType.Text == "" ||
            rtbMeaning.Text == "" ||
            txtPhonetic.Text == "")
            {
                return false;
            }
            return true;
        }
        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            grdW.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in grdW.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(txtSearch.Text.ToLower()))
                    {
                        row.Selected = true;
                        grdW.CurrentCell = row.Cells[1];
                        var word = (Word)row.DataBoundItem;
                        txtEnglishW.Text = word.English_Word;
                        cbType.Text = word.Word_Type;
                        txtPhonetic.Text = word.Phonetic;
                        rtbMeaning.Text = word.Meaning;
                        return;
                    }
                }
                throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show("Your Word Does Not Exist");
                grdW.ClearSelection();
            }
        }
        private void GrdW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var word = (Word)grdW.SelectedRows[0].DataBoundItem;
            txtEnglishW.Text = word.English_Word;
            cbType.Text = word.Word_Type;
            rtbMeaning.Text = word.Meaning;
            txtPhonetic.Text = word.Phonetic;
        }
        private void load_Words()
        {
            var LoadWord = this.Business.GetWords();
            LoadWord = LoadWord.OrderBy(w => w.English_Word).ToArray();
            grdW.DataSource = LoadWord;
            grdW.AllowUserToResizeRows = false;
            grdW.ClearSelection();
            grdW.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CheckNull() == true)
            {
                var EngW = txtEnglishW.Text;
                var Type = (string)cbType.SelectedItem;
                var Meaning = rtbMeaning.Text;
                var phonetic = txtPhonetic.Text;

                this.Business.AddWord(EngW, Type, phonetic, Meaning);
                MessageBox.Show("Create successfully", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_Words();
            }
            else
                MessageBox.Show("Data to Add not null");
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (grdW.SelectedRows.Count == 1)
            {
                if (CheckNull() == true)
                {
                    var Word = (Word)grdW.SelectedRows[0].DataBoundItem;
                    var EngW = txtEnglishW.Text;
                    var Type = (string)cbType.SelectedItem;
                    var Meaning = rtbMeaning.Text;
                    var phonetic = txtPhonetic.Text;
                    this.Business.EditWord(Word.ID, EngW, Type, phonetic, Meaning);
                    MessageBox.Show("Edit Compelete", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_Words();
                }
                else
                    MessageBox.Show("Do Not Set Data Null", "Nofication",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
            if (grdW.SelectedRows.Count == 1)
            {
                if(MessageBox.Show("Are You Sure Want To Delete this row", "Nofication", MessageBoxButtons.YesNo,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    var Word = (Word)grdW.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteWord(Word.ID);
                    MessageBox.Show("Delete Compelete", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_Words();
                }
            }
        }
        private void Management_Load(object sender, EventArgs e)
        {
            load_Words();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
