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
    public partial class Export_and_Import_Data_Words : Form
    {
        private Words_Management business;
        DataTable dataWord;
        public Export_and_Import_Data_Words()
        {
            InitializeComponent();
            business = new Words_Management();
            dataWord = new DataTable();
            this.btnExport_Data_Words.Click += BtnExport_Click;
            this.btnImport_Data_Words.Click += BtnImport_Click;
            this.btnSave_Data_Words.Click += BtnSave_Click;
            this.btnReload.Click += BtnReload_Click;
            this.Load += ExportandImport_Load;
            btnSave_Data_Words.Enabled = false;
            this.grdForEX_IM.ReadOnly = true;
            this.grdForEX_IM.AllowUserToResizeRows = false;
            this.grdForEX_IM.AllowUserToResizeColumns = false;
        }
        private void BtnReload_Click(object sender, EventArgs e)
        {
            dataWord = new DataTable();
            LoadAllIndexIn_DB();
            btnImport_Data_Words.Enabled = true;
            btnExport_Data_Words.Enabled = true;
            btnSave_Data_Words.Enabled = false;
            MessageBox.Show("Reload Successfully");
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int CountRow = grdForEX_IM.RowCount;
                int CountCeil = grdForEX_IM.Rows[0].Cells.Count;
                string[] abc = new string[4];
                for (int i = 0; i <= CountRow - 1; i++)
                {
                    for (int j = 0; j <= CountCeil - 1; j++)
                    {
                        abc[j] = grdForEX_IM.Rows[i].Cells[j].Value.ToString();
                    }
                    business.AddWordFromImport(abc);
                }
                btnSave_Data_Words.Enabled = false;
                MessageBox.Show("Save Successfully", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllIndexIn_DB();
                btnExport_Data_Words.Enabled = true;
                btnImport_Data_Words.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            try
            {
                btnSave_Data_Words.Enabled = true;
                btnExport_Data_Words.Enabled = false;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave_Data_Words.Enabled = false;
                int CountRow = grdForEX_IM.RowCount;
                int CountCeil = grdForEX_IM.Rows[0].Cells.Count;
                txtExport.Text = "English Word,Type Word,Phonetic,Meaning\r\n";
                for (int i = 0; i <= CountRow - 1; i++)
                {
                    for (int j = 1; j <= CountCeil - 1; j++)
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
                    File.WriteAllText(dialog.FileName + ".csv", txtExport.Text);
                    MessageBox.Show("Export Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
