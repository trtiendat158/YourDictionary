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
    public partial class Browser : Form
    {
        WebBrowser wb;
        public Browser()
        {
            InitializeComponent();
            wb = new WebBrowser();
            this.btnCambrigde.Click += BtnGG_Click;
            this.btnVDict.Click += BtnVdict_Click;
            this.btnDict.Click += BtnDict_Click;
            this.btnGGS.Click += BtnGGS_Click;
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
