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
    public partial class frmMain : Form
    {
        static public Player player = null;
        static public frmTutorial tutorial = new frmTutorial();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreateChar_Click(object sender, EventArgs e)
        {

            // create new player
            player = new Player();
            frmClassSelection classSelect = new frmClassSelection(player);
            classSelect.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            tutorial.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            // start the game
            if (player != null)
            {
                if (player.Created == true)
                {
                    switch (player.Class)
                    {

                        // give players weapons based on their class
                        case "Thief":
                            Dagger weapThief = new Dagger();
                            player.Weapon = weapThief;
                            Cloak armorThief = new Cloak();
                            player.Armor = armorThief;
                            break;
                        case "Warrior":
                            Claymore weapWarrior = new Claymore();
                            player.Weapon = weapWarrior;
                            FurHide armorWarrior = new FurHide();
                            player.Armor = armorWarrior;
                            break;
                        case "Knight":
                            Claymore weapKnight = new Claymore();
                            player.Weapon = weapKnight;
                            FurHide armorKnight = new FurHide();
                            player.Armor = armorKnight;
                            break;
                    }

                    frmGameMain game = new frmGameMain(player, this);
                    game.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please create a character first!");
                }
            }
            else
            {
                MessageBox.Show("Please create a character first!");
            }
        }
    }
}
