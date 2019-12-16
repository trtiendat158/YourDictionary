namespace YourDictionaryLibrary_Dat_Tan
{
    partial class Management_ListWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management_ListWord));
            this.txtEnglishW = new System.Windows.Forms.TextBox();
            this.panelQuanLy = new System.Windows.Forms.Panel();
            this.txtPhonetic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVnW = new System.Windows.Forms.Label();
            this.lblTypeW = new System.Windows.Forms.Label();
            this.lblEnlishW = new System.Windows.Forms.Label();
            this.rtbMeaning = new System.Windows.Forms.RichTextBox();
            this.cbType_Word = new System.Windows.Forms.ComboBox();
            this.grdW = new System.Windows.Forms.DataGridView();
            this.lblTitleManage = new System.Windows.Forms.Label();
            this.btnAdd_Word = new System.Windows.Forms.Button();
            this.btnDelete_Words = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch_Word = new System.Windows.Forms.Button();
            this.btnEdit_Word = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.panelQuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdW)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEnglishW
            // 
            this.txtEnglishW.Location = new System.Drawing.Point(3, 50);
            this.txtEnglishW.Name = "txtEnglishW";
            this.txtEnglishW.Size = new System.Drawing.Size(198, 20);
            this.txtEnglishW.TabIndex = 0;
            // 
            // panelQuanLy
            // 
            this.panelQuanLy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelQuanLy.BackgroundImage")));
            this.panelQuanLy.Controls.Add(this.txtPhonetic);
            this.panelQuanLy.Controls.Add(this.label1);
            this.panelQuanLy.Controls.Add(this.lblVnW);
            this.panelQuanLy.Controls.Add(this.lblTypeW);
            this.panelQuanLy.Controls.Add(this.lblEnlishW);
            this.panelQuanLy.Controls.Add(this.rtbMeaning);
            this.panelQuanLy.Controls.Add(this.cbType_Word);
            this.panelQuanLy.Controls.Add(this.txtEnglishW);
            this.panelQuanLy.Location = new System.Drawing.Point(25, 49);
            this.panelQuanLy.Name = "panelQuanLy";
            this.panelQuanLy.Size = new System.Drawing.Size(659, 187);
            this.panelQuanLy.TabIndex = 42;
            // 
            // txtPhonetic
            // 
            this.txtPhonetic.Location = new System.Drawing.Point(242, 137);
            this.txtPhonetic.Name = "txtPhonetic";
            this.txtPhonetic.Size = new System.Drawing.Size(269, 20);
            this.txtPhonetic.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(238, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phonetic:";
            // 
            // lblVnW
            // 
            this.lblVnW.AutoSize = true;
            this.lblVnW.BackColor = System.Drawing.Color.Transparent;
            this.lblVnW.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVnW.ForeColor = System.Drawing.Color.White;
            this.lblVnW.Location = new System.Drawing.Point(238, 11);
            this.lblVnW.Name = "lblVnW";
            this.lblVnW.Size = new System.Drawing.Size(87, 22);
            this.lblVnW.TabIndex = 3;
            this.lblVnW.Text = "Meaning:";
            // 
            // lblTypeW
            // 
            this.lblTypeW.AutoSize = true;
            this.lblTypeW.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeW.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeW.ForeColor = System.Drawing.Color.White;
            this.lblTypeW.Location = new System.Drawing.Point(-1, 96);
            this.lblTypeW.Name = "lblTypeW";
            this.lblTypeW.Size = new System.Drawing.Size(100, 22);
            this.lblTypeW.TabIndex = 3;
            this.lblTypeW.Text = "Word type:";
            // 
            // lblEnlishW
            // 
            this.lblEnlishW.AutoSize = true;
            this.lblEnlishW.BackColor = System.Drawing.Color.Transparent;
            this.lblEnlishW.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnlishW.ForeColor = System.Drawing.Color.White;
            this.lblEnlishW.Location = new System.Drawing.Point(-1, 11);
            this.lblEnlishW.Name = "lblEnlishW";
            this.lblEnlishW.Size = new System.Drawing.Size(123, 22);
            this.lblEnlishW.TabIndex = 3;
            this.lblEnlishW.Text = "English word:";
            // 
            // rtbMeaning
            // 
            this.rtbMeaning.Location = new System.Drawing.Point(242, 36);
            this.rtbMeaning.Name = "rtbMeaning";
            this.rtbMeaning.Size = new System.Drawing.Size(269, 50);
            this.rtbMeaning.TabIndex = 2;
            this.rtbMeaning.Text = "";
            // 
            // cbType_Word
            // 
            this.cbType_Word.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbType_Word.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType_Word.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType_Word.FormattingEnabled = true;
            this.cbType_Word.Items.AddRange(new object[] {
            "Verb",
            "Noun",
            "Adjective ",
            "Adverb "});
            this.cbType_Word.Location = new System.Drawing.Point(3, 135);
            this.cbType_Word.Name = "cbType_Word";
            this.cbType_Word.Size = new System.Drawing.Size(198, 21);
            this.cbType_Word.TabIndex = 1;
            // 
            // grdW
            // 
            this.grdW.AllowUserToAddRows = false;
            this.grdW.AllowUserToDeleteRows = false;
            this.grdW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdW.Location = new System.Drawing.Point(10, 298);
            this.grdW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdW.Name = "grdW";
            this.grdW.ReadOnly = true;
            this.grdW.RowHeadersVisible = false;
            this.grdW.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdW.RowTemplate.Height = 24;
            this.grdW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdW.Size = new System.Drawing.Size(686, 271);
            this.grdW.TabIndex = 43;
            // 
            // lblTitleManage
            // 
            this.lblTitleManage.AutoSize = true;
            this.lblTitleManage.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleManage.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleManage.ForeColor = System.Drawing.Color.White;
            this.lblTitleManage.Location = new System.Drawing.Point(207, 11);
            this.lblTitleManage.Name = "lblTitleManage";
            this.lblTitleManage.Size = new System.Drawing.Size(279, 26);
            this.lblTitleManage.TabIndex = 39;
            this.lblTitleManage.Text = "MANAGE DICTIONARY";
            // 
            // btnAdd_Word
            // 
            this.btnAdd_Word.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Word.Location = new System.Drawing.Point(304, 251);
            this.btnAdd_Word.Name = "btnAdd_Word";
            this.btnAdd_Word.Size = new System.Drawing.Size(80, 31);
            this.btnAdd_Word.TabIndex = 37;
            this.btnAdd_Word.Text = "Add";
            this.btnAdd_Word.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd_Word.UseVisualStyleBackColor = true;
            // 
            // btnDelete_Words
            // 
            this.btnDelete_Words.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_Words.Location = new System.Drawing.Point(510, 252);
            this.btnDelete_Words.Name = "btnDelete_Words";
            this.btnDelete_Words.Size = new System.Drawing.Size(77, 31);
            this.btnDelete_Words.TabIndex = 36;
            this.btnDelete_Words.Text = "Delete";
            this.btnDelete_Words.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete_Words.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(597, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 31);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSearch_Word
            // 
            this.btnSearch_Word.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_Word.ForeColor = System.Drawing.Color.Black;
            this.btnSearch_Word.Location = new System.Drawing.Point(152, 251);
            this.btnSearch_Word.Name = "btnSearch_Word";
            this.btnSearch_Word.Size = new System.Drawing.Size(90, 31);
            this.btnSearch_Word.TabIndex = 34;
            this.btnSearch_Word.Text = "Search";
            this.btnSearch_Word.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch_Word.UseVisualStyleBackColor = true;
            // 
            // btnEdit_Word
            // 
            this.btnEdit_Word.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_Word.Location = new System.Drawing.Point(408, 251);
            this.btnEdit_Word.Name = "btnEdit_Word";
            this.btnEdit_Word.Size = new System.Drawing.Size(78, 31);
            this.btnEdit_Word.TabIndex = 38;
            this.btnEdit_Word.Text = "Edit";
            this.btnEdit_Word.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit_Word.UseVisualStyleBackColor = true;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(28, 256);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(121, 21);
            this.cbSearch.TabIndex = 45;
            // 
            // Management_ListWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 580);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.panelQuanLy);
            this.Controls.Add(this.grdW);
            this.Controls.Add(this.lblTitleManage);
            this.Controls.Add(this.btnAdd_Word);
            this.Controls.Add(this.btnDelete_Words);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch_Word);
            this.Controls.Add(this.btnEdit_Word);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Management_ListWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.panelQuanLy.ResumeLayout(false);
            this.panelQuanLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnglishW;
        private System.Windows.Forms.Panel panelQuanLy;
        private System.Windows.Forms.Label lblVnW;
        private System.Windows.Forms.Label lblTypeW;
        private System.Windows.Forms.Label lblEnlishW;
        private System.Windows.Forms.RichTextBox rtbMeaning;
        private System.Windows.Forms.ComboBox cbType_Word;
        private System.Windows.Forms.DataGridView grdW;
        private System.Windows.Forms.Label lblTitleManage;
        private System.Windows.Forms.Button btnAdd_Word;
        private System.Windows.Forms.Button btnDelete_Words;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch_Word;
        private System.Windows.Forms.Button btnEdit_Word;
        private System.Windows.Forms.TextBox txtPhonetic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSearch;
    }
}