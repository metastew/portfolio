using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DnDGame
{
    public partial class frmClassSelection : Form
    {
        Player newPlayer = null;
        public frmClassSelection(Player player)
        {
            InitializeComponent();
            newPlayer = player;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string charClass ="";
            int offense =0;
            int defense =0;
            
            if (radThiefSelect.Checked) {
                charClass = "Thief";
                offense = int.Parse(lblThiefOffenseStat.Text);
                defense = int.Parse(lblThiefDefenseStat.Text);
            } else if (radWarriorSelect.Checked) {
                charClass = "Warrior";
                offense = int.Parse(lblWarriorOffenseStat.Text);
                defense = int.Parse(lblWarriorDefenseStat.Text);
            } else if (radKnightSelect.Checked) {
                charClass = "Knight";
                offense = int.Parse(lblKnightOffenseStat.Text);
                defense = int.Parse(lblKnightDefenseStat.Text);
            } else {
                MessageBox.Show("Please choose a class!");
            }

            if (!charClass.Equals(""))
            {
                newPlayer.Class = charClass;
                newPlayer.Offense = offense;
                newPlayer.Defense = defense;

                frmPointAllocation points = new frmPointAllocation(newPlayer);
                points.Show();
                this.Dispose();
            }
        }
    }
}
