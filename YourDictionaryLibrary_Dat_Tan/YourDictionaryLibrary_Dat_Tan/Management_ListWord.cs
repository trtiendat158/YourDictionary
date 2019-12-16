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
            this.btnAdd_Word.Click += btnAdd_Word_Click;
            this.btnDelete_Words.Click += btnDelete_Words_Click;
            this.btnEdit_Word.Click += btnEdit_Word_Click;
            this.btnClose.Click += BtnClose_Click;
            this.grdW.CellClick += GrdW_CellClick;
            this.btnSearch_Word.Click += btnSearch_Word_Click;
            this.cbSearch.KeyDown += CbSearch_KeyDown;
        }
        private void CbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Word_Click(sender, e);
            }
        }
        private bool CheckNull()
        {
            if (txtEnglishW.Text == "" || cbType_Word.Text == "" ||
            rtbMeaning.Text == "" ||
            txtPhonetic.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btnSearch_Word_Click(object sender, EventArgs e)
        {
            grdW.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in grdW.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(cbSearch.Text.ToLower()))
                    {
                        row.Selected = true;
                        grdW.CurrentCell = row.Cells[1];
                        var word = (Word)row.DataBoundItem;
                        txtEnglishW.Text = word.English_Word;
                        cbType_Word.Text = word.Word_Type;
                        txtPhonetic.Text = word.Phonetic;
                        rtbMeaning.Text = word.Meaning;
                        return;
                    }
                }
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
            cbType_Word.Text = word.Word_Type;
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
            this.cbSearch.DataSource = this.Business.GetWords();
            this.cbSearch.DisplayMember = "English_Word";
            this.cbSearch.ValueMember = "ID";
        }
        private void btnAdd_Word_Click(object sender, EventArgs e)
        {
            if (CheckNull() == true)
            {
                var words = this.Business.GetWords();
                var Word_to_check = txtEnglishW.Text.ToLower();
                if (this.Business.Check_Word_Exist(words,Word_to_check)==true)
                {
                    if(MessageBox.Show("This word \"" + Word_to_check+"\" already exist, are you sure want to continue creating","Nofication",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var EngW = txtEnglishW.Text;
                        var Type = (string)cbType_Word.SelectedItem;
                        var Meaning = rtbMeaning.Text;
                        var phonetic = txtPhonetic.Text;

                        this.Business.AddWord(EngW, Type, phonetic, Meaning);
                        MessageBox.Show("Create successfully", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_Words();
                    }
                }
                else
                {
                    var EngW = txtEnglishW.Text;
                    var Type = (string)cbType_Word.SelectedItem;
                    var Meaning = rtbMeaning.Text;
                    var phonetic = txtPhonetic.Text;

                    this.Business.AddWord(EngW, Type, phonetic, Meaning);
                    MessageBox.Show("Create successfully", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_Words();
                }
            }
            else
                MessageBox.Show("Data to Add not null");
        }
        private void btnEdit_Word_Click(object sender, EventArgs e)
        {
            if (grdW.SelectedRows.Count == 1)
            {
                if (CheckNull() == true)
                {
                    var Word = (Word)grdW.SelectedRows[0].DataBoundItem;
                    var EngW = txtEnglishW.Text;
                    var Type = (string)cbType_Word.SelectedItem;
                    var Meaning = rtbMeaning.Text;
                    var phonetic = txtPhonetic.Text;
                    this.Business.EditWord(Word.Id, EngW, Type, phonetic, Meaning);
                    MessageBox.Show("Edit Compelete", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_Words();
                }
                else
                    MessageBox.Show("Do Not Set Data Null", "Nofication",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDelete_Words_Click(object sender, EventArgs e)
        {
            if (grdW.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Are You Sure Want To Delete this row", "Nofication", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Are You Sure Want To Delete this row", "Nofication", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        var Word = (Word)grdW.SelectedRows[0].DataBoundItem;
                        this.Business.DeleteWord(Word.Id);
                        MessageBox.Show("Delete Compelete", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_Words();
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Warning!!! Are You Sure Want To Delete These Rows", "Nofication", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    for (int i = 1; i < grdW.SelectedRows.Count; i++)
                    {
                        var word = (Word)grdW.SelectedRows[i].DataBoundItem;
                        this.Business.DeleteWord(word.Id);
                    }
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