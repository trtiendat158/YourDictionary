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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.btnGG = new System.Windows.Forms.Button();
            this.btnVdict = new System.Windows.Forms.Button();
            this.pnlBrowser = new System.Windows.Forms.Panel();
            this.btnDict = new System.Windows.Forms.Button();
            this.btnGGS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGG
            // 
            this.btnGG.Image = ((System.Drawing.Image)(resources.GetObject("btnGG.Image")));
            this.btnGG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGG.Location = new System.Drawing.Point(43, 15);
            this.btnGG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGG.Name = "btnGG";
            this.btnGG.Size = new System.Drawing.Size(140, 53);
            this.btnGG.TabIndex = 0;
            this.btnGG.Text = "Cambrigde";
            this.btnGG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGG.UseVisualStyleBackColor = true;
            // 
            // btnVdict
            // 
            this.btnVdict.Image = ((System.Drawing.Image)(resources.GetObject("btnVdict.Image")));
            this.btnVdict.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVdict.Location = new System.Drawing.Point(207, 15);
            this.btnVdict.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVdict.Name = "btnVdict";
            this.btnVdict.Size = new System.Drawing.Size(133, 53);
            this.btnVdict.TabIndex = 1;
            this.btnVdict.Text = "      Vdict";
            this.btnVdict.UseVisualStyleBackColor = true;
            // 
            // pnlBrowser
            // 
            this.pnlBrowser.Location = new System.Drawing.Point(43, 100);
            this.pnlBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBrowser.Name = "pnlBrowser";
            this.pnlBrowser.Size = new System.Drawing.Size(1419, 674);
            this.pnlBrowser.TabIndex = 3;
            // 
            // btnDict
            // 
            this.btnDict.Image = ((System.Drawing.Image)(resources.GetObject("btnDict.Image")));
            this.btnDict.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDict.Location = new System.Drawing.Point(376, 15);
            this.btnDict.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDict.Name = "btnDict";
            this.btnDict.Size = new System.Drawing.Size(126, 53);
            this.btnDict.TabIndex = 4;
            this.btnDict.Text = "Dict.com";
            this.btnDict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDict.UseVisualStyleBackColor = true;
            // 
            // btnGGS
            // 
            this.btnGGS.Image = ((System.Drawing.Image)(resources.GetObject("btnGGS.Image")));
            this.btnGGS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGGS.Location = new System.Drawing.Point(545, 15);
            this.btnGGS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGGS.Name = "btnGGS";
            this.btnGGS.Size = new System.Drawing.Size(162, 53);
            this.btnGGS.TabIndex = 5;
            this.btnGGS.Text = "Google Search";
            this.btnGGS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGGS.UseVisualStyleBackColor = true;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1477, 789);
            this.Controls.Add(this.btnGGS);
            this.Controls.Add(this.btnDict);
            this.Controls.Add(this.pnlBrowser);
            this.Controls.Add(this.btnVdict);
            this.Controls.Add(this.btnGG);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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