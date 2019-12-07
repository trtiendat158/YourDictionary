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
    public partial class Test : Form
    {
        private Words_Management business;
        DataTable dataWord;
        public Test()
        {
            InitializeComponent();
            business = new Words_Management();
            dataWord = new DataTable();
            this.btnExport.Click += BtnExport_Click;
            this.btnImport.Click += BtnImport_Click;
            this.Load += Test_Load;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            grdtest.DataSource = business.GetWords();
        }


        /// <summary>
        /// Còn bị lỗi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImport_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] listImport = File.ReadAllLines(dialog.FileName);
                string[] data = null;
                int x = 0;
                foreach (string text_line in listImport)
                {
                    data = text_line.Split(',');
                    if (x == 0)
                    {
                        for (int i = 0; i <= data.Count() - 1; i++)
                        {
                            dataWord.Columns.Add(data[i]);
                        }
                        x++;
                    }
                    else
                        dataWord.Rows.Add(data);
                }
                grdtest.DataSource = dataWord;
            }
        }
        /// <summary>
        /// còn bị lỗi chưa fix được
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExport_Click(object sender, EventArgs e)
        {
            int CountRow = grdtest.RowCount;
            int CountCeil = grdtest.Rows[0].Cells.Count;
            for(int i =0; i <= CountRow - 1; i++)
            {
                for(int j =0; j <= CountCeil - 1; j++)
                {
                    txtExport.Text = txtExport.Text + grdtest.Rows[i].Cells[j].Value.ToString() + ",";
                }
                txtExport.Text = txtExport.Text + "\r\n";
            }
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName +".csv", txtExport.Text);
                MessageBox.Show("Export Successfully");
            }
        }
    }
}
