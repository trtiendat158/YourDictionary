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
            this.lblVnW = new System.Windows.Forms.Label();
            this.lblTypeW = new System.Windows.Forms.Label();
            this.lblEnlishW = new System.Windows.Forms.Label();
            this.rtbMeaning = new System.Windows.Forms.RichTextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.grdW = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitleManage = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelQuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdW)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEnglishW
            // 
            this.txtEnglishW.Enabled = false;
            this.txtEnglishW.Location = new System.Drawing.Point(3, 50);
            this.txtEnglishW.Name = "txtEnglishW";
            this.txtEnglishW.Size = new System.Drawing.Size(198, 20);
            this.txtEnglishW.TabIndex = 0;
            // 
            // panelQuanLy
            // 
            this.panelQuanLy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelQuanLy.BackgroundImage")));
            this.panelQuanLy.Controls.Add(this.lblVnW);
            this.panelQuanLy.Controls.Add(this.lblTypeW);
            this.panelQuanLy.Controls.Add(this.lblEnlishW);
            this.panelQuanLy.Controls.Add(this.rtbMeaning);
            this.panelQuanLy.Controls.Add(this.cbType);
            this.panelQuanLy.Controls.Add(this.txtEnglishW);
            this.panelQuanLy.Location = new System.Drawing.Point(25, 49);
            this.panelQuanLy.Name = "panelQuanLy";
            this.panelQuanLy.Size = new System.Drawing.Size(566, 187);
            this.panelQuanLy.TabIndex = 42;
            // 
            // lblVnW
            // 
            this.lblVnW.AutoSize = true;
            this.lblVnW.BackColor = System.Drawing.Color.Transparent;
            this.lblVnW.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVnW.ForeColor = System.Drawing.Color.White;
            this.lblVnW.Location = new System.Drawing.Point(238, 11);
            this.lblVnW.Name = "lblVnW";
            this.lblVnW.Size = new System.Drawing.Size(108, 22);
            this.lblVnW.TabIndex = 3;
            this.lblVnW.Text = "Vietnamese:";
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
            this.rtbMeaning.Enabled = false;
            this.rtbMeaning.Location = new System.Drawing.Point(242, 50);
            this.rtbMeaning.Name = "rtbMeaning";
            this.rtbMeaning.Size = new System.Drawing.Size(269, 106);
            this.rtbMeaning.TabIndex = 2;
            this.rtbMeaning.Text = "";
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Enabled = false;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Verb",
            "Noun",
            "Adjective ",
            "Adverb "});
            this.cbType.Location = new System.Drawing.Point(3, 135);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(198, 21);
            this.cbType.TabIndex = 1;
            // 
            // grdW
            // 
            this.grdW.AllowUserToAddRows = false;
            this.grdW.AllowUserToDeleteRows = false;
            this.grdW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdW.Location = new System.Drawing.Point(10, 298);
            this.grdW.Margin = new System.Windows.Forms.Padding(2);
            this.grdW.Name = "grdW";
            this.grdW.ReadOnly = true;
            this.grdW.RowHeadersWidth = 51;
            this.grdW.RowTemplate.Height = 24;
            this.grdW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdW.Size = new System.Drawing.Size(686, 271);
            this.grdW.TabIndex = 43;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(597, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 31);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Red;
            this.btnSave.Location = new System.Drawing.Point(597, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 32);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
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
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(175, 252);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 31);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(457, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 31);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
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
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Location = new System.Drawing.Point(23, 252);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(90, 31);
            this.btnReload.TabIndex = 34;
            this.btnReload.Text = "Reload";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(317, 251);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 31);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(707, 580);
            this.Controls.Add(this.panelQuanLy);
            this.Controls.Add(this.grdW);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitleManage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitleManage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnEdit;
    }
}