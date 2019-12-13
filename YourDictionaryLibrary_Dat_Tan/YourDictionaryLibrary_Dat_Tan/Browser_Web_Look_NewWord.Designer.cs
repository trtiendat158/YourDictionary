namespace YourDictionaryLibrary_Dat_Tan
{
    partial class Browser_Web_Look_NewWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser_Web_Look_NewWord));
            this.btnCambrigde = new System.Windows.Forms.Button();
            this.btnVDict = new System.Windows.Forms.Button();
            this.pnlBrowser = new System.Windows.Forms.Panel();
            this.btnDict = new System.Windows.Forms.Button();
            this.btnGGS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCambrigde
            // 
            this.btnCambrigde.Image = ((System.Drawing.Image)(resources.GetObject("btnCambrigde.Image")));
            this.btnCambrigde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambrigde.Location = new System.Drawing.Point(32, 12);
            this.btnCambrigde.Name = "btnCambrigde";
            this.btnCambrigde.Size = new System.Drawing.Size(105, 43);
            this.btnCambrigde.TabIndex = 0;
            this.btnCambrigde.Text = "Cambrigde";
            this.btnCambrigde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCambrigde.UseVisualStyleBackColor = true;
            // 
            // btnVDict
            // 
            this.btnVDict.Image = ((System.Drawing.Image)(resources.GetObject("btnVDict.Image")));
            this.btnVDict.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVDict.Location = new System.Drawing.Point(155, 12);
            this.btnVDict.Name = "btnVDict";
            this.btnVDict.Size = new System.Drawing.Size(100, 43);
            this.btnVDict.TabIndex = 1;
            this.btnVDict.Text = "      Vdict";
            this.btnVDict.UseVisualStyleBackColor = true;
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Location = new System.Drawing.Point(32, 81);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(1064, 548);
            this.pnlBrowser.TabIndex = 3;
            // 
            // btnDict
            // 
            this.btnDict.Image = ((System.Drawing.Image)(resources.GetObject("btnDict.Image")));
            this.btnDict.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDict.Location = new System.Drawing.Point(282, 12);
            this.btnDict.Name = "btnDict";
            this.btnDict.Size = new System.Drawing.Size(94, 43);
            this.btnDict.TabIndex = 4;
            this.btnDict.Text = "Dict.com";
            this.btnDict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDict.UseVisualStyleBackColor = true;
            // 
            // btnGGS
            // 
            this.btnGGS.Image = ((System.Drawing.Image)(resources.GetObject("btnGGS.Image")));
            this.btnGGS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGGS.Location = new System.Drawing.Point(409, 12);
            this.btnGGS.Name = "btnGGS";
            this.btnGGS.Size = new System.Drawing.Size(122, 43);
            this.btnGGS.TabIndex = 5;
            this.btnGGS.Text = "Google Search";
            this.btnGGS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGGS.UseVisualStyleBackColor = true;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 641);
            this.Controls.Add(this.btnGGS);
            this.Controls.Add(this.btnDict);
            this.Controls.Add(this.pnlBrowser);
            this.Controls.Add(this.btnVDict);
            this.Controls.Add(this.btnCambrigde);
            this.Name = "Browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCambrigde;
        private System.Windows.Forms.Button btnVDict;
        private System.Windows.Forms.Panel pnlBrowser;
        private System.Windows.Forms.Button btnDict;
        private System.Windows.Forms.Button btnGGS;
    }
}