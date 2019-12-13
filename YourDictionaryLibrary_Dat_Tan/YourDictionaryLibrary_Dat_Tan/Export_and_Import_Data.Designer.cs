namespace YourDictionaryLibrary_Dat_Tan
{
    partial class Export_and_Import_Data
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
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.txtExport = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.ToolStripMenuItem();
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
            this.grdForEX_IM.Location = new System.Drawing.Point(0, 24);
            this.grdForEX_IM.Name = "grdForEX_IM";
            this.grdForEX_IM.ReadOnly = true;
            this.grdForEX_IM.RowHeadersVisible = false;
            this.grdForEX_IM.Size = new System.Drawing.Size(566, 426);
            this.grdForEX_IM.TabIndex = 0;
            // 
            // wordBindingSource
            // 
            this.wordBindingSource.DataMember = "Word";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExport,
            this.btnImport,
            this.btnSave,
            this.btnReload});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnExport
            // 
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(53, 20);
            this.btnExport.Text = "Export";
            // 
            // btnImport
            // 
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(55, 20);
            this.btnImport.Text = "Import";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(43, 20);
            this.btnSave.Text = "Save";
            // 
            // txtExport
            // 
            this.txtExport.Location = new System.Drawing.Point(564, 24);
            this.txtExport.Multiline = true;
            this.txtExport.Name = "txtExport";
            this.txtExport.ReadOnly = true;
            this.txtExport.Size = new System.Drawing.Size(236, 426);
            this.txtExport.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(55, 20);
            this.btnReload.Text = "Reload";
            // 
            // ExportandImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtExport);
            this.Controls.Add(this.grdForEX_IM);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExportandImport";
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
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.TextBox txtExport;
        private System.Windows.Forms.ToolStripMenuItem btnImport;
        private System.Windows.Forms.BindingSource wordBindingSource;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnReload;
    }
}