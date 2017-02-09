namespace DnDGame
{
    partial class frmTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutorial));
            this.grpTutorial = new System.Windows.Forms.GroupBox();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpTutorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTutorial
            // 
            this.grpTutorial.Controls.Add(this.lblTutorial);
            this.grpTutorial.Location = new System.Drawing.Point(13, 13);
            this.grpTutorial.Name = "grpTutorial";
            this.grpTutorial.Size = new System.Drawing.Size(466, 224);
            this.grpTutorial.TabIndex = 0;
            this.grpTutorial.TabStop = false;
            this.grpTutorial.Text = "Tutorial";
            // 
            // lblTutorial
            // 
            this.lblTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTutorial.Location = new System.Drawing.Point(7, 20);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(453, 185);
            this.lblTutorial.TabIndex = 0;
            this.lblTutorial.Text = resources.GetString("lblTutorial.Text");
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(404, 248);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 283);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpTutorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTutorial";
            this.Text = "Tutorial";
            this.grpTutorial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTutorial;
        private System.Windows.Forms.Label lblTutorial;
        private System.Windows.Forms.Button btnOK;
    }
}