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
    public partial class Browser_Web_Look_NewWord : Form
    {
        WebBrowser wb;
        public Browser_Web_Look_NewWord()
        {
            InitializeComponent();
            wb = new WebBrowser();
            this.btn_Web_Cambrigde.Click += BtnGG_Click;
            this.btn_Web_VDict.Click += BtnVdict_Click;
            this.btn_Web_Dict.Click += BtnDict_Click;
            this.btn_Web_GGS.Click += BtnGGS_Click;
            wb.ScriptErrorsSuppressed = true;
            wb.Height = 548;
            wb.Width = 1064;
            pnlBrowser.Controls.Add(wb);
        }
        private void BtnGGS_Click(object sender, EventArgs e)
        {
            wb.Navigate("https://www.google.com");
        }
        private void BtnDict_Click(object sender, EventArgs e)
        {
            wb.Navigate("https://www.dict.com/anh-viet");
        }
        private void BtnVdict_Click(object sender, EventArgs e)
        {
            wb.Navigate("https://vdict.com");
        }
        private void BtnGG_Click(object sender, EventArgs e)
        {
            wb.Navigate("https://dictionary.cambridge.org/vi/dictionary/english-vietnamese/");
        }
    }
}
