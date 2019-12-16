namespace YourDictionaryLibrary_Dat_Tan
{
    partial class Export_and_Import_Data_Words
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grdForEX_IM = new System.Windows.Forms.DataGridView();
            this.wordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnExport_Data_Words = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImport_Data_Words = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave_Data_Words = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReload = new System.Windows.Forms.ToolStripMenuItem();
            this.txtExport = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdForEX_IM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdForEX_IM
            // 
            this.grdForEX_IM.AllowUserToAddRows = false;
            this.grdForEX_IM.AllowUserToDeleteRows = false;
            this.grdForEX_IM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdForEX_IM.Location = new System.Drawing.Point(0, 30);
            this.grdForEX_IM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdForEX_IM.Name = "grdForEX_IM";
            this.grdForEX_IM.ReadOnly = true;
            this.grdForEX_IM.RowHeadersVisible = false;
            this.grdForEX_IM.RowHeadersWidth = 51;
            this.grdForEX_IM.Size = new System.Drawing.Size(755, 524);
            this.grdForEX_IM.TabIndex = 0;
            // 
            // wordBindingSource
            // 
            this.wordBindingSource.DataMember = "Word";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExport_Data_Words,
            this.btnImport_Data_Words,
            this.btnSave_Data_Words,
            this.btnReload});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnExport_Data_Words
            // 
            this.btnExport_Data_Words.Name = "btnExport_Data_Words";
            this.btnExport_Data_Words.Size = new System.Drawing.Size(66, 26);
            this.btnExport_Data_Words.Text = "Export";
            // 
            // btnImport_Data_Words
            // 
            this.btnImport_Data_Words.Name = "btnImport_Data_Words";
            this.btnImport_Data_Words.Size = new System.Drawing.Size(68, 26);
            this.btnImport_Data_Words.Text = "Import";
            // 
            // btnSave_Data_Words
            // 
            this.btnSave_Data_Words.Name = "btnSave_Data_Words";
            this.btnSave_Data_Words.Size = new System.Drawing.Size(54, 26);
            this.btnSave_Data_Words.Text = "Save";
            // 
            // btnReload
            // 
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(70, 26);
            this.btnReload.Text = "Reload";
            // 
            // txtExport
            // 
            this.txtExport.Location = new System.Drawing.Point(752, 30);
            this.txtExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExport.Multiline = true;
            this.txtExport.Name = "txtExport";
            this.txtExport.ReadOnly = true;
            this.txtExport.Size = new System.Drawing.Size(313, 523);
            this.txtExport.TabIndex = 2;
            // 
            // Export_and_Import_Data_Words
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtExport);
            this.Controls.Add(this.grdForEX_IM);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Export_and_Import_Data_Words";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.grdForEX_IM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.DataGridView grdForEX_IM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnExport_Data_Words;
        private System.Windows.Forms.TextBox txtExport;
        private System.Windows.Forms.ToolStripMenuItem btnImport_Data_Words;
        private System.Windows.Forms.BindingSource wordBindingSource;
        private System.Windows.Forms.ToolStripMenuItem btnSave_Data_Words;
        private System.Windows.Forms.ToolStripMenuItem btnReload;
    }
}