namespace DnDGame
{
    partial class frmPointAllocation
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
            this.lblOffense = new System.Windows.Forms.Label();
            this.lblDefense = new System.Windows.Forms.Label();
            this.lblOffenseStat = new System.Windows.Forms.Label();
            this.lblDefenseStat = new System.Windows.Forms.Label();
            this.btnOffenseAdd = new System.Windows.Forms.Button();
            this.btnOffenseSub = new System.Windows.Forms.Button();
            this.btnDefenseSub = new System.Windows.Forms.Button();
            this.btnDefenseAdd = new System.Windows.Forms.Button();
            this.lblPointInstructions = new System.Windows.Forms.Label();
            this.lblPointClass = new System.Windows.Forms.Label();
            this.lblPointInstruction2 = new System.Windows.Forms.Label();
            this.lblHowManyPoints = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOffense
            // 
            this.lblOffense.AutoSize = true;
            this.lblOffense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffense.Location = new System.Drawing.Point(13, 61);
            this.lblOffense.Name = "lblOffense";
            this.lblOffense.Size = new System.Drawing.Size(55, 13);
            this.lblOffense.TabIndex = 0;
            this.lblOffense.Text = "Offense:";
            // 
            // lblDefense
            // 
            this.lblDefense.AutoSize = true;
            this.lblDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefense.Location = new System.Drawing.Point(13, 96);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.Size = new System.Drawing.Size(58, 13);
            this.lblDefense.TabIndex = 1;
            this.lblDefense.Text = "Defense:";
            // 
            // lblOffenseStat
            // 
            this.lblOffenseStat.AutoSize = true;
            this.lblOffenseStat.Location = new System.Drawing.Point(75, 61);
            this.lblOffenseStat.Name = "lblOffenseStat";
            this.lblOffenseStat.Size = new System.Drawing.Size(13, 13);
            this.lblOffenseStat.TabIndex = 2;
            this.lblOffenseStat.Text = "0";
            // 
            // lblDefenseStat
            // 
            this.lblDefenseStat.AutoSize = true;
            this.lblDefenseStat.Location = new System.Drawing.Point(75, 96);
            this.lblDefenseStat.Name = "lblDefenseStat";
            this.lblDefenseStat.Size = new System.Drawing.Size(13, 13);
            this.lblDefenseStat.TabIndex = 3;
            this.lblDefenseStat.Text = "0";
            // 
            // btnOffenseAdd
            // 
            this.btnOffenseAdd.Location = new System.Drawing.Point(106, 56);
            this.btnOffenseAdd.Name = "btnOffenseAdd";
            this.btnOffenseAdd.Size = new System.Drawing.Size(28, 23);
            this.btnOffenseAdd.TabIndex = 4;
            this.btnOffenseAdd.Text = "+";
            this.btnOffenseAdd.UseVisualStyleBackColor = true;
            this.btnOffenseAdd.Click += new System.EventHandler(this.btnOffenseAdd_Click);
            // 
            // btnOffenseSub
            // 
            this.btnOffenseSub.Location = new System.Drawing.Point(140, 56);
            this.btnOffenseSub.Name = "btnOffenseSub";
            this.btnOffenseSub.Size = new System.Drawing.Size(28, 23);
            this.btnOffenseSub.TabIndex = 5;
            this.btnOffenseSub.Text = "-";
            this.btnOffenseSub.UseVisualStyleBackColor = true;
            this.btnOffenseSub.Click += new System.EventHandler(this.btnOffenseSub_Click);
            // 
            // btnDefenseSub
            // 
            this.btnDefenseSub.Location = new System.Drawing.Point(140, 91);
            this.btnDefenseSub.Name = "btnDefenseSub";
            this.btnDefenseSub.Size = new System.Drawing.Size(28, 23);
            this.btnDefenseSub.TabIndex = 7;
            this.btnDefenseSub.Text = "-";
            this.btnDefenseSub.UseVisualStyleBackColor = true;
            this.btnDefenseSub.Click += new System.EventHandler(this.btnDefenseSub_Click);
            // 
            // btnDefenseAdd
            // 
            this.btnDefenseAdd.Location = new System.Drawing.Point(106, 91);
            this.btnDefenseAdd.Name = "btnDefenseAdd";
            this.btnDefenseAdd.Size = new System.Drawing.Size(28, 23);
            this.btnDefenseAdd.TabIndex = 6;
            this.btnDefenseAdd.Text = "+";
            this.btnDefenseAdd.UseVisualStyleBackColor = true;
            this.btnDefenseAdd.Click += new System.EventHandler(this.btnDefenseAdd_Click);
            // 
            // lblPointInstructions
            // 
            this.lblPointInstructions.AutoSize = true;
            this.lblPointInstructions.Location = new System.Drawing.Point(13, 13);
            this.lblPointInstructions.Name = "lblPointInstructions";
            this.lblPointInstructions.Size = new System.Drawing.Size(79, 13);
            this.lblPointInstructions.TabIndex = 8;
            this.lblPointInstructions.Text = "You picked the";
            // 
            // lblPointClass
            // 
            this.lblPointClass.AutoSize = true;
            this.lblPointClass.Location = new System.Drawing.Point(88, 13);
            this.lblPointClass.Name = "lblPointClass";
            this.lblPointClass.Size = new System.Drawing.Size(31, 13);
            this.lblPointClass.TabIndex = 9;
            this.lblPointClass.Text = "class";
            // 
            // lblPointInstruction2
            // 
            this.lblPointInstruction2.AutoSize = true;
            this.lblPointInstruction2.Location = new System.Drawing.Point(13, 26);
            this.lblPointInstruction2.Name = "lblPointInstruction2";
            this.lblPointInstruction2.Size = new System.Drawing.Size(56, 13);
            this.lblPointInstruction2.TabIndex = 10;
            this.lblPointInstruction2.Text = "You have ";
            // 
            // lblHowManyPoints
            // 
            this.lblHowManyPoints.AutoSize = true;
            this.lblHowManyPoints.Location = new System.Drawing.Point(63, 26);
            this.lblHowManyPoints.Name = "lblHowManyPoints";
            this.lblHowManyPoints.Size = new System.Drawing.Size(13, 13);
            this.lblHowManyPoints.TabIndex = 11;
            this.lblHowManyPoints.Text = "0";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(25, 137);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 12;
            this.btnContinue.Text = "&Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(106, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPointAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 172);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblHowManyPoints);
            this.Controls.Add(this.lblPointInstruction2);
            this.Controls.Add(this.lblPointClass);
            this.Controls.Add(this.lblPointInstructions);
            this.Controls.Add(this.btnDefenseSub);
            this.Controls.Add(this.btnDefenseAdd);
            this.Controls.Add(this.btnOffenseSub);
            this.Controls.Add(this.btnOffenseAdd);
            this.Controls.Add(this.lblDefenseStat);
            this.Controls.Add(this.lblOffenseStat);
            this.Controls.Add(this.lblDefense);
            this.Controls.Add(this.lblOffense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPointAllocation";
            this.ShowIcon = false;
            this.Text = "Character Creation: Point Allocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOffense;
        private System.Windows.Forms.Label lblDefense;
        private System.Windows.Forms.Label lblOffenseStat;
        private System.Windows.Forms.Label lblDefenseStat;
        private System.Windows.Forms.Button btnOffenseAdd;
        private System.Windows.Forms.Button btnOffenseSub;
        private System.Windows.Forms.Button btnDefenseSub;
        private System.Windows.Forms.Button btnDefenseAdd;
        private System.Windows.Forms.Label lblPointInstructions;
        private System.Windows.Forms.Label lblPointClass;
        private System.Windows.Forms.Label lblPointInstruction2;
        private System.Windows.Forms.Label lblHowManyPoints;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnCancel;
    }
}