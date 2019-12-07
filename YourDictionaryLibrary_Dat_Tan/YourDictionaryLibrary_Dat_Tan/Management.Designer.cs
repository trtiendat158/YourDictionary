namespace YourDictionaryLibrary_Dat_Tan
{
    partial class Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.txtEnglishW = new System.Windows.Forms.TextBox();
            this.panelQuanLy = new System.Windows.Forms.Panel();
            this.txtPhonetic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVnW = new System.Windows.Forms.Label();
            this.lblTypeW = new System.Windows.Forms.Label();
            this.lblEnlishW = new System.Windows.Forms.Label();
            this.rtbMeaning = new System.Windows.Forms.RichTextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.grdW = new System.Windows.Forms.DataGridView();
            this.lblTitleManage = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelQuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdW)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEnglishW
            // 
            this.txtEnglishW.Location = new System.Drawing.Point(4, 62);
            this.txtEnglishW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnglishW.Name = "txtEnglishW";
            this.txtEnglishW.Size = new System.Drawing.Size(263, 22);
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
            this.panelQuanLy.Controls.Add(this.cbType);
            this.panelQuanLy.Controls.Add(this.txtEnglishW);
            this.panelQuanLy.Location = new System.Drawing.Point(33, 60);
            this.panelQuanLy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelQuanLy.Name = "panelQuanLy";
            this.panelQuanLy.Size = new System.Drawing.Size(879, 230);
            this.panelQuanLy.TabIndex = 42;
            // 
            // txtPhonetic
            // 
            this.txtPhonetic.Location = new System.Drawing.Point(323, 164);
            this.txtPhonetic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhonetic.Name = "txtPhonetic";
            this.txtPhonetic.Size = new System.Drawing.Size(357, 22);
            this.txtPhonetic.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phonetic:";
            // 
            // lblVnW
            // 
            this.lblVnW.AutoSize = true;
            this.lblVnW.BackColor = System.Drawing.Color.Transparent;
            this.lblVnW.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVnW.ForeColor = System.Drawing.Color.White;
            this.lblVnW.Location = new System.Drawing.Point(317, 14);
            this.lblVnW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVnW.Name = "lblVnW";
            this.lblVnW.Size = new System.Drawing.Size(111, 26);
            this.lblVnW.TabIndex = 3;
            this.lblVnW.Text = "Meaning:";
            // 
            // lblTypeW
            // 
            this.lblTypeW.AutoSize = true;
            this.lblTypeW.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeW.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeW.ForeColor = System.Drawing.Color.White;
            this.lblTypeW.Location = new System.Drawing.Point(-1, 118);
            this.lblTypeW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeW.Name = "lblTypeW";
            this.lblTypeW.Size = new System.Drawing.Size(128, 26);
            this.lblTypeW.TabIndex = 3;
            this.lblTypeW.Text = "Word type:";
            // 
            // lblEnlishW
            // 
            this.lblEnlishW.AutoSize = true;
            this.lblEnlishW.BackColor = System.Drawing.Color.Transparent;
            this.lblEnlishW.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnlishW.ForeColor = System.Drawing.Color.White;
            this.lblEnlishW.Location = new System.Drawing.Point(-1, 14);
            this.lblEnlishW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnlishW.Name = "lblEnlishW";
            this.lblEnlishW.Size = new System.Drawing.Size(156, 26);
            this.lblEnlishW.TabIndex = 3;
            this.lblEnlishW.Text = "English word:";
            // 
            // rtbMeaning
            // 
            this.rtbMeaning.Location = new System.Drawing.Point(323, 44);
            this.rtbMeaning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbMeaning.Name = "rtbMeaning";
            this.rtbMeaning.Size = new System.Drawing.Size(357, 61);
            this.rtbMeaning.TabIndex = 2;
            this.rtbMeaning.Text = "";
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Verb",
            "Noun",
            "Adjective ",
            "Adverb "});
            this.cbType.Location = new System.Drawing.Point(4, 166);
            this.cbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(263, 24);
            this.cbType.TabIndex = 1;
            // 
            // grdW
            // 
            this.grdW.AllowUserToAddRows = false;
            this.grdW.AllowUserToDeleteRows = false;
            this.grdW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdW.Location = new System.Drawing.Point(13, 367);
            this.grdW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdW.Name = "grdW";
            this.grdW.ReadOnly = true;
            this.grdW.RowHeadersVisible = false;
            this.grdW.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdW.RowTemplate.Height = 24;
            this.grdW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdW.Size = new System.Drawing.Size(915, 334);
            this.grdW.TabIndex = 43;
            // 
            // lblTitleManage
            // 
            this.lblTitleManage.AutoSize = true;
            this.lblTitleManage.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleManage.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitleManage.ForeColor = System.Drawing.Color.White;
            this.lblTitleManage.Location = new System.Drawing.Point(276, 14);
            this.lblTitleManage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleManage.Name = "lblTitleManage";
            this.lblTitleManage.Size = new System.Drawing.Size(355, 35);
            this.lblTitleManage.TabIndex = 39;
            this.lblTitleManage.Text = "MANAGE DICTIONARY";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(405, 309);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 38);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(680, 310);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 38);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(796, 309);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 38);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(157, 310);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 38);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(544, 309);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 38);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 319);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 22);
            this.txtSearch.TabIndex = 44;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 714);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panelQuanLy);
            this.Controls.Add(this.grdW);
            this.Controls.Add(this.lblTitleManage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Management";
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
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DataGridView grdW;
        private System.Windows.Forms.Label lblTitleManage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtPhonetic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}