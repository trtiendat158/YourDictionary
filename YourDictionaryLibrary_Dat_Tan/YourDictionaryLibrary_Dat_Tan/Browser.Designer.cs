namespace YourDictionaryLibrary_Dat_Tan
{
    partial class Browser
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
            this.btnGG = new System.Windows.Forms.Button();
            this.btnVdict = new System.Windows.Forms.Button();
            this.pnlBrowser = new System.Windows.Forms.Panel();
            this.btnDict = new System.Windows.Forms.Button();
            this.btnGGS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGG
            // 
            this.btnGG.Location = new System.Drawing.Point(32, 12);
            this.btnGG.Name = "btnGG";
            this.btnGG.Size = new System.Drawing.Size(105, 43);
            this.btnGG.TabIndex = 0;
            this.btnGG.Text = "Cambrigde";
            this.btnGG.UseVisualStyleBackColor = true;
            // 
            // btnVdict
            // 
            this.btnVdict.Location = new System.Drawing.Point(155, 12);
            this.btnVdict.Name = "btnVdict";
            this.btnVdict.Size = new System.Drawing.Size(105, 43);
            this.btnVdict.TabIndex = 1;
            this.btnVdict.Text = "Vdict";
            this.btnVdict.UseVisualStyleBackColor = true;
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
            this.btnDict.Location = new System.Drawing.Point(282, 12);
            this.btnDict.Name = "btnDict";
            this.btnDict.Size = new System.Drawing.Size(105, 43);
            this.btnDict.TabIndex = 4;
            this.btnDict.Text = "Dict.com";
            this.btnDict.UseVisualStyleBackColor = true;
            // 
            // btnGGS
            // 
            this.btnGGS.Location = new System.Drawing.Point(409, 12);
            this.btnGGS.Name = "btnGGS";
            this.btnGGS.Size = new System.Drawing.Size(105, 43);
            this.btnGGS.TabIndex = 5;
            this.btnGGS.Text = "Google Search";
            this.btnGGS.UseVisualStyleBackColor = true;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 641);
            this.Controls.Add(this.btnGGS);
            this.Controls.Add(this.btnDict);
            this.Controls.Add(this.pnlBrowser);
            this.Controls.Add(this.btnVdict);
            this.Controls.Add(this.btnGG);
            this.Name = "Browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGG;
        private System.Windows.Forms.Button btnVdict;
        private System.Windows.Forms.Panel pnlBrowser;
        private System.Windows.Forms.Button btnDict;
        private System.Windows.Forms.Button btnGGS;
    }
}