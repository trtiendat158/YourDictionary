namespace YourDictionaryLibrary_Dat_Tan
{
    partial class Main_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Interface));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.cbWord = new System.Windows.Forms.ComboBox();
            this.rtbMeaningW = new System.Windows.Forms.RichTextBox();
            this.btnExportAndImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(203, 41);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(409, 31);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "YOUR DICTIONARY LIBRARY";
            // 
            // btnManage
            // 
            this.btnManage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.Black;
            this.btnManage.Image = ((System.Drawing.Image)(resources.GetObject("btnManage.Image")));
            this.btnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.Location = new System.Drawing.Point(512, 105);
            this.btnManage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(135, 45);
            this.btnManage.TabIndex = 35;
            this.btnManage.Text = "Manage";
            this.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManage.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(656, 105);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(116, 45);
            this.btnInfo.TabIndex = 34;
            this.btnInfo.Text = "Info";
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnLookUp
            // 
            this.btnLookUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookUp.ForeColor = System.Drawing.Color.Black;
            this.btnLookUp.Image = ((System.Drawing.Image)(resources.GetObject("btnLookUp.Image")));
            this.btnLookUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLookUp.Location = new System.Drawing.Point(255, 205);
            this.btnLookUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(150, 45);
            this.btnLookUp.TabIndex = 39;
            this.btnLookUp.Text = "Look up";
            this.btnLookUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLookUp.UseVisualStyleBackColor = true;
            // 
            // btnSpeak
            // 
            this.btnSpeak.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeak.ForeColor = System.Drawing.Color.Black;
            this.btnSpeak.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeak.Image")));
            this.btnSpeak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpeak.Location = new System.Drawing.Point(380, 105);
            this.btnSpeak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(123, 45);
            this.btnSpeak.TabIndex = 40;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpeak.UseVisualStyleBackColor = true;
            // 
            // cbWord
            // 
            this.cbWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbWord.FormattingEnabled = true;
            this.cbWord.Location = new System.Drawing.Point(15, 175);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(214, 580);
            this.cbWord.TabIndex = 43;
            // 
            // rtbMeaningW
            // 
            this.rtbMeaningW.Enabled = false;
            this.rtbMeaningW.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMeaningW.Location = new System.Drawing.Point(426, 175);
            this.rtbMeaningW.Name = "rtbMeaningW";
            this.rtbMeaningW.Size = new System.Drawing.Size(344, 577);
            this.rtbMeaningW.TabIndex = 44;
            this.rtbMeaningW.Text = "";
            // 
            // btnExportAndImport
            // 
            this.btnExportAndImport.Image = ((System.Drawing.Image)(resources.GetObject("btnExportAndImport.Image")));
            this.btnExportAndImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportAndImport.Location = new System.Drawing.Point(255, 282);
            this.btnExportAndImport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportAndImport.Name = "btnExportAndImport";
            this.btnExportAndImport.Size = new System.Drawing.Size(150, 45);
            this.btnExportAndImport.TabIndex = 47;
            this.btnExportAndImport.Text = "Export/Import";
            this.btnExportAndImport.UseVisualStyleBackColor = true;
            // 
            // Main_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 769);
            this.Controls.Add(this.btnExportAndImport);
            this.Controls.Add(this.rtbMeaningW);
            this.Controls.Add(this.cbWord);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnInfo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Interface_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.Button btnSpeak;
        internal System.Windows.Forms.ComboBox cbWord;
        private System.Windows.Forms.RichTextBox rtbMeaningW;
        private System.Windows.Forms.Button btnExportAndImport;
    }
}

