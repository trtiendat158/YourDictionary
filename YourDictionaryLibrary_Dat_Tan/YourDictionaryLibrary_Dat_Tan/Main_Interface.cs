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
    public partial class Main_Interface : Form
    {
        private Words_Management Business;
        Speak_Phonetic_Word speakEngW;
        public Main_Interface()
        {
            InitializeComponent();
            this.Business = new Words_Management();
            speakEngW = new Speak_Phonetic_Word();
            this.Load += Main_Interface_Load;
            this.btnManage.Click += BtnManage_Click;
            this.btnInfo.Click += BtnInfo_Click;
            this.btnLookUp.Click += BtnLookUp_Click;
            this.btnSpeak.Click += BtnSpeak_Click;
            this.cbWord.KeyDown += CbWord_KeyDown;
            this.btnExportAndImport.Click += btnExportAndImport_Click;
            this.MaximizeBox = false;
        }
        private void btnExportAndImport_Click(object sender, EventArgs e)
        {
            var form = new Export_and_Import_Data();
            form.ShowDialog();
            LoadData();
        }
        private void CbWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLookUp.PerformClick();
            }
        }
        /// <summary>
        /// Bắt sự kiện btnSpeak.click lấy dữ liêu từ combobox vào speakEng,speak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSpeak_Click(object sender, EventArgs e)
        {
            if (cbWord.SelectedItem == null)
                MessageBox.Show("Cant Find Word in your list Data","Thông báo");
            else
            {
                var data = cbWord.SelectedItem as Word;
                this.speakEngW.speak(data.English_Word);
            }
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
                    var Browser = new Browser_Web_Look_NewWord();
                    Browser.ShowDialog();
                }
            }
            else
            {
                var data = cbWord.SelectedItem as Word;
                rtbMeaningW.Text = "Type:" + "  " + data.Word_Type + "\r\n"+ 
                    "Phonetic: "+data.Phonetic+"\r\n"+
                    "Meaning:\r\n" + " \t" + data.Meaning;
                rtbMeaningW.Find(data.Word_Type);
                rtbMeaningW.SelectionColor = Color.Black;
                rtbMeaningW.Find(data.Phonetic);
                rtbMeaningW.SelectionColor = Color.Black;
                rtbMeaningW.Find(data.Meaning);
                rtbMeaningW.SelectionColor = Color.Black;
                rtbMeaningW.Find("Type:");
                rtbMeaningW.SelectionColor = Color.Red;
                rtbMeaningW.Find("Phonetic:");
                rtbMeaningW.SelectionColor = Color.Red;
                rtbMeaningW.Find("Meaning");
                rtbMeaningW.SelectionColor = Color.Blue;
            }
        }
        private void BtnInfo_Click(object sender, EventArgs e)
        {
            Infomation_TeamBuilding info = new Infomation_TeamBuilding();
            info.ShowDialog();
        }
        private void BtnManage_Click(object sender, EventArgs e)
        {
            Management_ListWord manageW = new Management_ListWord();
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
//fix csdl///