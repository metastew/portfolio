namespace DnDGame
{
    partial class frmGameMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStartBattle = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.grpHero = new System.Windows.Forms.GroupBox();
            this.lblHeroHealthOutput = new System.Windows.Forms.Label();
            this.lblHeroHealth = new System.Windows.Forms.Label();
            this.lblHeroOffenseOutput = new System.Windows.Forms.Label();
            this.lblHeroDefenseOutput = new System.Windows.Forms.Label();
            this.lblHeroNameOutput = new System.Windows.Forms.Label();
            this.lblHeroClassOutput = new System.Windows.Forms.Label();
            this.lblHeroClass = new System.Windows.Forms.Label();
            this.lblHeroDefense = new System.Windows.Forms.Label();
            this.lblHeroOffense = new System.Windows.Forms.Label();
            this.lblHeroName = new System.Windows.Forms.Label();
            this.grpMonster = new System.Windows.Forms.GroupBox();
            this.lblMonsterHealthOutput = new System.Windows.Forms.Label();
            this.lblMonsterHealth = new System.Windows.Forms.Label();
            this.lblMonsterOffenseOutput = new System.Windows.Forms.Label();
            this.lblMonsterDefenseOutput = new System.Windows.Forms.Label();
            this.lblMonsterNameOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonsterName = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.grpHero.SuspendLayout();
            this.grpMonster.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(428, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStartBattle
            // 
            this.btnStartBattle.Location = new System.Drawing.Point(428, 13);
            this.btnStartBattle.Name = "btnStartBattle";
            this.btnStartBattle.Size = new System.Drawing.Size(75, 23);
            this.btnStartBattle.TabIndex = 3;
            this.btnStartBattle.Text = "&Start Battle";
            this.btnStartBattle.UseVisualStyleBackColor = true;
            this.btnStartBattle.Click += new System.EventHandler(this.btnStartBattle_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.Location = new System.Drawing.Point(428, 42);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(75, 23);
            this.btnHeal.TabIndex = 4;
            this.btnHeal.Text = "&Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(428, 71);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "&Run!";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // grpHero
            // 
            this.grpHero.Controls.Add(this.lblHeroHealthOutput);
            this.grpHero.Controls.Add(this.lblHeroHealth);
            this.grpHero.Controls.Add(this.lblHeroOffenseOutput);
            this.grpHero.Controls.Add(this.lblHeroDefenseOutput);
            this.grpHero.Controls.Add(this.lblHeroNameOutput);
            this.grpHero.Controls.Add(this.lblHeroClassOutput);
            this.grpHero.Controls.Add(this.lblHeroClass);
            this.grpHero.Controls.Add(this.lblHeroDefense);
            this.grpHero.Controls.Add(this.lblHeroOffense);
            this.grpHero.Controls.Add(this.lblHeroName);
            this.grpHero.Location = new System.Drawing.Point(13, 167);
            this.grpHero.Name = "grpHero";
            this.grpHero.Size = new System.Drawing.Size(200, 179);
            this.grpHero.TabIndex = 6;
            this.grpHero.TabStop = false;
            this.grpHero.Text = "Hero";
            // 
            // lblHeroHealthOutput
            // 
            this.lblHeroHealthOutput.AutoSize = true;
            this.lblHeroHealthOutput.Location = new System.Drawing.Point(60, 125);
            this.lblHeroHealthOutput.Name = "lblHeroHealthOutput";
            this.lblHeroHealthOutput.Size = new System.Drawing.Size(24, 13);
            this.lblHeroHealthOutput.TabIndex = 10;
            this.lblHeroHealthOutput.Text = "test";
            // 
            // lblHeroHealth
            // 
            this.lblHeroHealth.AutoSize = true;
            this.lblHeroHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroHealth.Location = new System.Drawing.Point(6, 125);
            this.lblHeroHealth.Name = "lblHeroHealth";
            this.lblHeroHealth.Size = new System.Drawing.Size(48, 13);
            this.lblHeroHealth.TabIndex = 9;
            this.lblHeroHealth.Text = "Health:";
            // 
            // lblHeroOffenseOutput
            // 
            this.lblHeroOffenseOutput.AutoSize = true;
            this.lblHeroOffenseOutput.Location = new System.Drawing.Point(67, 100);
            this.lblHeroOffenseOutput.Name = "lblHeroOffenseOutput";
            this.lblHeroOffenseOutput.Size = new System.Drawing.Size(24, 13);
            this.lblHeroOffenseOutput.TabIndex = 8;
            this.lblHeroOffenseOutput.Text = "test";
            // 
            // lblHeroDefenseOutput
            // 
            this.lblHeroDefenseOutput.AutoSize = true;
            this.lblHeroDefenseOutput.Location = new System.Drawing.Point(70, 75);
            this.lblHeroDefenseOutput.Name = "lblHeroDefenseOutput";
            this.lblHeroDefenseOutput.Size = new System.Drawing.Size(24, 13);
            this.lblHeroDefenseOutput.TabIndex = 7;
            this.lblHeroDefenseOutput.Text = "test";
            // 
            // lblHeroNameOutput
            // 
            this.lblHeroNameOutput.AutoSize = true;
            this.lblHeroNameOutput.Location = new System.Drawing.Point(55, 27);
            this.lblHeroNameOutput.Name = "lblHeroNameOutput";
            this.lblHeroNameOutput.Size = new System.Drawing.Size(24, 13);
            this.lblHeroNameOutput.TabIndex = 6;
            this.lblHeroNameOutput.Text = "test";
            // 
            // lblHeroClassOutput
            // 
            this.lblHeroClassOutput.AutoSize = true;
            this.lblHeroClassOutput.Location = new System.Drawing.Point(53, 51);
            this.lblHeroClassOutput.Name = "lblHeroClassOutput";
            this.lblHeroClassOutput.Size = new System.Drawing.Size(24, 13);
            this.lblHeroClassOutput.TabIndex = 5;
            this.lblHeroClassOutput.Text = "test";
            // 
            // lblHeroClass
            // 
            this.lblHeroClass.AutoSize = true;
            this.lblHeroClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroClass.Location = new System.Drawing.Point(6, 51);
            this.lblHeroClass.Name = "lblHeroClass";
            this.lblHeroClass.Size = new System.Drawing.Size(41, 13);
            this.lblHeroClass.TabIndex = 3;
            this.lblHeroClass.Text = "Class:";
            // 
            // lblHeroDefense
            // 
            this.lblHeroDefense.AutoSize = true;
            this.lblHeroDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroDefense.Location = new System.Drawing.Point(6, 75);
            this.lblHeroDefense.Name = "lblHeroDefense";
            this.lblHeroDefense.Size = new System.Drawing.Size(58, 13);
            this.lblHeroDefense.TabIndex = 2;
            this.lblHeroDefense.Text = "Defense:";
            // 
            // lblHeroOffense
            // 
            this.lblHeroOffense.AutoSize = true;
            this.lblHeroOffense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroOffense.Location = new System.Drawing.Point(6, 100);
            this.lblHeroOffense.Name = "lblHeroOffense";
            this.lblHeroOffense.Size = new System.Drawing.Size(55, 13);
            this.lblHeroOffense.TabIndex = 1;
            this.lblHeroOffense.Text = "Offense:";
            // 
            // lblHeroName
            // 
            this.lblHeroName.AutoSize = true;
            this.lblHeroName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroName.Location = new System.Drawing.Point(6, 27);
            this.lblHeroName.Name = "lblHeroName";
            this.lblHeroName.Size = new System.Drawing.Size(43, 13);
            this.lblHeroName.TabIndex = 0;
            this.lblHeroName.Text = "Name:";
            // 
            // grpMonster
            // 
            this.grpMonster.Controls.Add(this.lblMonsterHealthOutput);
            this.grpMonster.Controls.Add(this.lblMonsterHealth);
            this.grpMonster.Controls.Add(this.lblMonsterOffenseOutput);
            this.grpMonster.Controls.Add(this.lblMonsterDefenseOutput);
            this.grpMonster.Controls.Add(this.lblMonsterNameOutput);
            this.grpMonster.Controls.Add(this.label2);
            this.grpMonster.Controls.Add(this.label3);
            this.grpMonster.Controls.Add(this.lblMonsterName);
            this.grpMonster.Location = new System.Drawing.Point(219, 167);
            this.grpMonster.Name = "grpMonster";
            this.grpMonster.Size = new System.Drawing.Size(203, 179);
            this.grpMonster.TabIndex = 7;
            this.grpMonster.TabStop = false;
            this.grpMonster.Text = "Monster";
            // 
            // lblMonsterHealthOutput
            // 
            this.lblMonsterHealthOutput.AutoSize = true;
            this.lblMonsterHealthOutput.Location = new System.Drawing.Point(60, 100);
            this.lblMonsterHealthOutput.Name = "lblMonsterHealthOutput";
            this.lblMonsterHealthOutput.Size = new System.Drawing.Size(24, 13);
            this.lblMonsterHealthOutput.TabIndex = 12;
            this.lblMonsterHealthOutput.Text = "test";
            // 
            // lblMonsterHealth
            // 
            this.lblMonsterHealth.AutoSize = true;
            this.lblMonsterHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonsterHealth.Location = new System.Drawing.Point(6, 100);
            this.lblMonsterHealth.Name = "lblMonsterHealth";
            this.lblMonsterHealth.Size = new System.Drawing.Size(48, 13);
            this.lblMonsterHealth.TabIndex = 11;
            this.lblMonsterHealth.Text = "Health:";
            // 
            // lblMonsterOffenseOutput
            // 
            this.lblMonsterOffenseOutput.AutoSize = true;
            this.lblMonsterOffenseOutput.Location = new System.Drawing.Point(67, 75);
            this.lblMonsterOffenseOutput.Name = "lblMonsterOffenseOutput";
            this.lblMonsterOffenseOutput.Size = new System.Drawing.Size(24, 13);
            this.lblMonsterOffenseOutput.TabIndex = 8;
            this.lblMonsterOffenseOutput.Text = "test";
            // 
            // lblMonsterDefenseOutput
            // 
            this.lblMonsterDefenseOutput.AutoSize = true;
            this.lblMonsterDefenseOutput.Location = new System.Drawing.Point(70, 51);
            this.lblMonsterDefenseOutput.Name = "lblMonsterDefenseOutput";
            this.lblMonsterDefenseOutput.Size = new System.Drawing.Size(24, 13);
            this.lblMonsterDefenseOutput.TabIndex = 7;
            this.lblMonsterDefenseOutput.Text = "test";
            // 
            // lblMonsterNameOutput
            // 
            this.lblMonsterNameOutput.AutoSize = true;
            this.lblMonsterNameOutput.Location = new System.Drawing.Point(55, 27);
            this.lblMonsterNameOutput.Name = "lblMonsterNameOutput";
            this.lblMonsterNameOutput.Size = new System.Drawing.Size(24, 13);
            this.lblMonsterNameOutput.TabIndex = 6;
            this.lblMonsterNameOutput.Text = "test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Defense:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Offense:";
            // 
            // lblMonsterName
            // 
            this.lblMonsterName.AutoSize = true;
            this.lblMonsterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonsterName.Location = new System.Drawing.Point(6, 27);
            this.lblMonsterName.Name = "lblMonsterName";
            this.lblMonsterName.Size = new System.Drawing.Size(43, 13);
            this.lblMonsterName.TabIndex = 0;
            this.lblMonsterName.Text = "Name:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(429, 184);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "&Next Room";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Location = new System.Drawing.Point(13, 13);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(409, 147);
            this.txtOutput.TabIndex = 2;
            // 
            // frmGameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 358);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpMonster);
            this.Controls.Add(this.grpHero);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnStartBattle);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGameMain";
            this.Text = "Hero of Drakenton";
            this.Load += new System.EventHandler(this.frmGameMain_Load);
            this.grpHero.ResumeLayout(false);
            this.grpHero.PerformLayout();
            this.grpMonster.ResumeLayout(false);
            this.grpMonster.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStartBattle;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox grpHero;
        private System.Windows.Forms.Label lblHeroName;
        private System.Windows.Forms.Label lblHeroDefense;
        private System.Windows.Forms.Label lblHeroOffense;
        private System.Windows.Forms.Label lblHeroClass;
        private System.Windows.Forms.GroupBox grpMonster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMonsterName;
        private System.Windows.Forms.Label lblHeroHealthOutput;
        private System.Windows.Forms.Label lblHeroHealth;
        private System.Windows.Forms.Label lblHeroOffenseOutput;
        private System.Windows.Forms.Label lblHeroDefenseOutput;
        private System.Windows.Forms.Label lblHeroNameOutput;
        private System.Windows.Forms.Label lblHeroClassOutput;
        private System.Windows.Forms.Label lblMonsterHealthOutput;
        private System.Windows.Forms.Label lblMonsterHealth;
        private System.Windows.Forms.Label lblMonsterOffenseOutput;
        private System.Windows.Forms.Label lblMonsterDefenseOutput;
        private System.Windows.Forms.Label lblMonsterNameOutput;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtOutput;
    }
}