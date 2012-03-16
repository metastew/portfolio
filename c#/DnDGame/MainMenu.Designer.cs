namespace DnDGame
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCreateChar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCredit = new System.Windows.Forms.Label();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateChar
            // 
            this.btnCreateChar.Location = new System.Drawing.Point(78, 95);
            this.btnCreateChar.Name = "btnCreateChar";
            this.btnCreateChar.Size = new System.Drawing.Size(115, 23);
            this.btnCreateChar.TabIndex = 0;
            this.btnCreateChar.Text = "Create a Character";
            this.btnCreateChar.UseVisualStyleBackColor = true;
            this.btnCreateChar.Click += new System.EventHandler(this.btnCreateChar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Magneto", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Hero of Drakenton";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(78, 124);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(115, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(78, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.BackColor = System.Drawing.Color.Transparent;
            this.lblCredit.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.ForeColor = System.Drawing.Color.White;
            this.lblCredit.Location = new System.Drawing.Point(89, 54);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(88, 13);
            this.lblCredit.TabIndex = 5;
            this.lblCredit.Text = "by Craig Cannon";
            // 
            // btnTutorial
            // 
            this.btnTutorial.Location = new System.Drawing.Point(78, 153);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(115, 23);
            this.btnTutorial.TabIndex = 6;
            this.btnTutorial.Text = "Tutorial";
            this.btnTutorial.UseVisualStyleBackColor = true;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(276, 220);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCreateChar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateChar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Button btnTutorial;
    }
}

