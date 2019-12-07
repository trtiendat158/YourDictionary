using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourDictionaryLibrary_Dat_Tan
{
    public partial class Save_Data : Form
    {
        public Save_Data()
        {
            InitializeComponent();
            btnOpen.Click += BtnOpen_Click;
            btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var content = this.grdFile.Text;
                File.WriteAllText(dialog.FileName, content);
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var content = File.ReadAllText(dialog.FileName);
                this.grdFile.Text = content;
            }
        }
    }
}
