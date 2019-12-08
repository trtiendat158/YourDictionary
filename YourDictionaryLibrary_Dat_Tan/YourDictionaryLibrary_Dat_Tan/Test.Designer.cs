namespace YourDictionaryLibrary_Dat_Tan
{
    partial class Test
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
            this.grdtest = new System.Windows.Forms.DataGridView();
            this.wordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.words_DataDataSet = new YourDictionaryLibrary_Dat_Tan.Words_DataDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImport = new System.Windows.Forms.ToolStripMenuItem();
            this.txtExport = new System.Windows.Forms.TextBox();
            this.wordTableAdapter = new YourDictionaryLibrary_Dat_Tan.Words_DataDataSetTableAdapters.WordTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdtest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.words_DataDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdtest
            // 
            this.grdtest.AllowUserToAddRows = false;
            this.grdtest.AllowUserToDeleteRows = false;
            this.grdtest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdtest.Location = new System.Drawing.Point(0, 24);
            this.grdtest.Name = "grdtest";
            this.grdtest.ReadOnly = true;
            this.grdtest.Size = new System.Drawing.Size(566, 426);
            this.grdtest.TabIndex = 0;
            // 
            // wordBindingSource
            // 
            this.wordBindingSource.DataMember = "Word";
            this.wordBindingSource.DataSource = this.words_DataDataSet;
            // 
            // words_DataDataSet
            // 
            this.words_DataDataSet.DataSetName = "Words_DataDataSet";
            this.words_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExport,
            this.btnImport});
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
            // txtExport
            // 
            this.txtExport.Location = new System.Drawing.Point(564, 24);
            this.txtExport.Multiline = true;
            this.txtExport.Name = "txtExport";
            this.txtExport.Size = new System.Drawing.Size(236, 426);
            this.txtExport.TabIndex = 2;
            // 
            // wordTableAdapter
            // 
            this.wordTableAdapter.ClearBeforeFill = true;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtExport);
            this.Controls.Add(this.grdtest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Test";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.grdtest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.words_DataDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdtest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.TextBox txtExport;
        private System.Windows.Forms.ToolStripMenuItem btnImport;
        private Words_DataDataSet words_DataDataSet;
        private System.Windows.Forms.BindingSource wordBindingSource;
        private Words_DataDataSetTableAdapters.WordTableAdapter wordTableAdapter;
    }
}