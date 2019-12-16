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
        Speak_Phonetic_Word speakEngW;
        public Main_Interface()
        {
            InitializeComponent();
            this.Business = new Words_Management();
            speakEngW = new Speak_Phonetic_Word();
            this.Load += Main_Interface_Load;
            this.btnManage_ListWord.Click += btnManage_ListWord_Click;
            this.btnInfo_TeamBuilding.Click += btnInfo_TeamBuilding_Click;
            this.btnLookUp_Word_inWeb.Click += btnLookup_Word_inWeb_Click;
            this.btnSpeak_Word.Click += btnSpeak_Word_Click;
            this.btnExport_and_Import_Data_Words.Click += btnExport_and_Import_Data_Words_Click;
            this.MaximizeBox = false;
            this.cbWord.Click += CbWord_Click;
            this.btnTest.Click += BtnTest_Click;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            var testing = new Testing_Words();
            testing.ShowDialog();
        }
        private void CbWord_Click(object sender, EventArgs e)
        {
            var data = cbWord.SelectedItem as Word;
            rtbMeaningW.Text = "Type:" + "  " + data.Word_Type + "\r\n" +
                "Phonetic: " + data.Phonetic + "\r\n" +
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
        private void btnExport_and_Import_Data_Words_Click(object sender, EventArgs e)
        {
            var form = new Export_and_Import_Data_Words();
            form.ShowDialog();
            LoadData();
        }
        /// <summary>
        /// Bắt sự kiện btnSpeak.click lấy dữ liêu từ combobox vào speakEng,speak
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpeak_Word_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbWord.SelectedItem == null)
                    MessageBox.Show("Cant Find Word in your list Data", "Thông báo");
                else
                {
                    var data = cbWord.SelectedItem as Word;
                    this.speakEngW.speak(data.English_Word);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " (Check Your Conection)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void btnLookup_Word_inWeb_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This Function Help You Look Up in another Web, Click \"OK\" To continue", "Nofication",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var Browser = new Browser_Web_Look_NewWord();
                Browser.ShowDialog();
            }
        }
        private void btnInfo_TeamBuilding_Click(object sender, EventArgs e)
        {
            Infomation_TeamBuilding info = new Infomation_TeamBuilding();
            info.ShowDialog();
        }
        private void btnManage_ListWord_Click(object sender, EventArgs e)
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