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
    public partial class Testing_Review_Words : Form
    {
        private Words_Management Business;
        int id1, id2, id3, id4, id5;
        public Testing_Review_Words()
        {
            InitializeComponent();
            this.Business = new Words_Management();
            this.Load += Testing_Words_Load;
            this.btnCheck_Answer.Click += BtnCheck_Answer_Click;
            this.btnRightAnswer.Click += BtnRightAnswer_Click;
            this.btnReloadTest.Click += BtnReloadTest_Click;
        }
        private void BtnReloadTest_Click(object sender, EventArgs e)
        {
            Testing_Words_Load(sender, e);
            SetDefault();
        }
        private void SetDefault()
        {
            txtAnswer1.Text = ""; txtAnswer2.Text = ""; txtAnswer3.Text = ""; txtAnswer4.Text = ""; txtAnswer5.Text = "";
            cboxTrue1.Checked = false; cboxTrue2.Checked = false;cboxTrue3.Checked = false;cboxTrue4.Checked = false;cboxTrue5.Checked = false;
            cboxFalse1.Checked = false; cboxFalse2.Checked = false; cboxFalse3.Checked = false; cboxFalse4.Checked = false; cboxFalse5.Checked = false;
        }
        private void BtnRightAnswer_Click(object sender, EventArgs e)
        {
            txtAnswer1.Text = this.Business.GetWord(id1).English_Word.ToLower();
            txtAnswer2.Text = this.Business.GetWord(id2).English_Word.ToLower();
            txtAnswer3.Text = this.Business.GetWord(id3).English_Word.ToLower();
            txtAnswer4.Text = this.Business.GetWord(id4).English_Word.ToLower();
            txtAnswer5.Text = this.Business.GetWord(id5).English_Word.ToLower();
        }
        private void BtnCheck_Answer_Click(object sender, EventArgs e)
        {
            Do_CheckedCheckBox(cboxTrue1, cboxFalse1, id1, txtAnswer1.Text);
            Do_CheckedCheckBox(cboxTrue2, cboxFalse2, id2, txtAnswer2.Text);
            Do_CheckedCheckBox(cboxTrue3, cboxFalse3, id3, txtAnswer3.Text);
            Do_CheckedCheckBox(cboxTrue4, cboxFalse4, id4, txtAnswer4.Text);
            Do_CheckedCheckBox(cboxTrue5, cboxFalse5, id5, txtAnswer5.Text);
        }
        private void Do_CheckedCheckBox(CheckBox cboxTrue, CheckBox cboxFalse, int id, string txtAnswer)
        {
            cboxTrue.Checked = IsCheckAnswer(id, txtAnswer);
            if (cboxTrue.Checked == true)
            {
                cboxFalse.Checked = false;
            }
            else
            {
                cboxFalse.Checked = true;
            }
        }
        private bool IsCheckAnswer(int ID, string txtAnswer)
        {
            if (this.Business.GetWord(ID).English_Word.ToLower() == txtAnswer.ToLower())
                return true;
            else
                return false;
        }
        private int Avoid_Similar_id(int Firts_ID, int Second_ID)
        {
            while (Firts_ID == Second_ID)
            {
                Second_ID = this.Business.Random_ID();
            }
            return Second_ID;
        }
        private void Testing_Words_Load(object sender, EventArgs e)
        {
            this.Business.Add_ID_List();
            id1 = this.Business.Random_ID();
            id2 = this.Business.Random_ID();
            id2 = Avoid_Similar_id(id1, id2); ;
            id3 = this.Business.Random_ID();
            id3 = Avoid_Similar_id(id2, id3); ;
            id4 = this.Business.Random_ID();
            id4 = Avoid_Similar_id(id3, id4); ;
            id5 = this.Business.Random_ID();
            id5 = Avoid_Similar_id(id4, id5); ;

            txtquestion1.Text = this.Business.GetWord(id1).Meaning;
            txtquestion2.Text = this.Business.GetWord(id2).Meaning;
            txtquestion3.Text = this.Business.GetWord(id3).Meaning;
            txtquestion4.Text = this.Business.GetWord(id4).Meaning;
            txtquestion5.Text = this.Business.GetWord(id5).Meaning;
        }
    }
}
