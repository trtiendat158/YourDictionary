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
    public partial class ExportandImport : Form
    {
        private Words_Management business;
        DataTable dataWord;
        public ExportandImport()
        {
            InitializeComponent();
            business = new Words_Management();
            dataWord = new DataTable();
            this.btnExport.Click += BtnExport_Click;
            this.btnImport.Click += BtnImport_Click;
            this.btnSave.Click += BtnSave_Click;
            this.btnReload.Click += BtnReload_Click;
            this.Load += ExportandImport_Load;
            btnSave.Enabled = false;
            this.grdForEX_IM.ReadOnly = true;
            this.grdForEX_IM.AllowUserToResizeRows = false;
            this.grdForEX_IM.AllowUserToResizeColumns = false;
        }
        private void BtnReload_Click(object sender, EventArgs e)
        {
            dataWord = new DataTable();
            LoadAllIndexIn_DB();
            btnExport.Enabled = true;
            btnSave.Enabled = false;
            MessageBox.Show("Reload Successfully");
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            int CountRow = grdForEX_IM.RowCount;
            int CountCeil = grdForEX_IM.Rows[0].Cells.Count;
            string[] abc = new string[3];
            for (int i = 0; i <= CountRow - 1; i++)
            {
                for (int j = 0; j <= CountCeil - 1; j++)
                {
                        abc[j]=grdForEX_IM.Rows[i].Cells[j].Value.ToString();
                }
                business.AddWordFromImport(abc);
            }
            btnSave.Enabled = false;
            MessageBox.Show("Save Successfully","Nofication",MessageBoxButtons.OK,MessageBoxIcon.Information);
            LoadAllIndexIn_DB();
            btnExport.Enabled = true;
            btnImport.Enabled = false;
        }
        private void LoadAllIndexIn_DB()
        {
            grdForEX_IM.DataSource = business.GetWords();
            grdForEX_IM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ExportandImport_Load(object sender, EventArgs e)
        {
            LoadAllIndexIn_DB();
        }
        private void BtnImport_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnExport.Enabled = false;
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
                grdForEX_IM.DataSource = dataWord;
                grdForEX_IM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            int CountRow = grdForEX_IM.RowCount;
            int CountCeil = grdForEX_IM.Rows[0].Cells.Count;
            txtExport.Text = "English Word,Type Word,Phonetic,Meaning\r\n";
            for(int i =0; i <= CountRow - 1; i++)
            {
                for(int j =1; j <= CountCeil - 1; j++)
                {
                    if (j == CountCeil - 1)
                        txtExport.Text = txtExport.Text + grdForEX_IM.Rows[i].Cells[j].Value.ToString();
                    else
                        txtExport.Text = txtExport.Text + grdForEX_IM.Rows[i].Cells[j].Value.ToString() + ",";
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
