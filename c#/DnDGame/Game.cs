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
    public partial class frmGameMain : Form
    {
        // class level variables for frmGameMain
        Player newPlayer = null;
        frmMain _main = null;
        Monster[] _monsters = null;
        Monster monster = null;
        int countMonsters = 5;
        int count = 0;
        int turn = 0;

        // constructor for frmGameMain
        public frmGameMain(Player player, frmMain main)
        {
            // initialize objects
            InitializeComponent();
            newPlayer = player;
            _main = main;
            _monsters = generateMonsters(countMonsters);
            monster = _monsters[count];
        }

        // on frmGameMain Load
        private void frmGameMain_Load(object sender, EventArgs e)
        {
            // populate the hero and monster stats
            lblHeroNameOutput.Text = newPlayer.Name;
            lblHeroClassOutput.Text = newPlayer.Class;
            lblHeroHealthOutput.Text = newPlayer.Health + " / 100";
            lblHeroOffenseOutput.Text = newPlayer.Offense.ToString();
            lblHeroDefenseOutput.Text = newPlayer.Defense.ToString();

            if (monster == null)
            {
                // if monsters doesn't exist, don't populate monster stats
                lblMonsterNameOutput.Text = "--";
                lblMonsterHealthOutput.Text = "--";
                lblMonsterOffenseOutput.Text = "--";
                lblMonsterDefenseOutput.Text = "--";
            }
            else
            {
                // if monster exists, populate monster stats
                refreshMonsterStats();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            _main.Show();
            this.Close();
        }

        // generate Monsters for Hero to fight
        private Monster[] generateMonsters(int numOfMonsters)
        {
            // function level variable used for constructing a Monster object
            string _name ="";
            int _offense = 0;
            int _defense = 0;
            
            // random number to help us pick a random monster to populate listOfMonsters
            Random _r = new Random();

            // holds an array of Monster objects
            Monster[] listOfMonsters = new Monster[numOfMonsters];

            // generate monsters individually
            for(int i = 0; i < (numOfMonsters - 1); i++)
            {
                int randomNum = _r.Next(1, 5); // for listOfMonsters populating

                // let randomNum pick the monster to populate
                switch (randomNum)
                {
                    case 1:
                        // medium-weak monster
                        _name = "Goblin";
                        _offense = _r.Next(1, 10);
                        _defense = _r.Next(1, 10);
                        break;
                    case 2:
                        // weakest monster
                        _name = "Stray Dog";
                        _offense = _r.Next(2, 6);
                        _defense = _r.Next(2, 6);
                        break;
                    case 3:
                        // medium strong monster
                        _name = "Orc";
                        _offense = _r.Next(2,10);
                        _defense = _r.Next(2, 10);
                        break;
                    case 4:
                        // strong monster
                        _name = "Baby Dragon";
                        _offense = _r.Next(3, 10);
                        _defense = _r.Next(3, 10);
                        break;
                }

                // add the Monster Object to the array
                listOfMonsters[i] = new Monster(_name, _offense, _defense);
            }
            
            // finally add the boss to listOfMonsters
            listOfMonsters[numOfMonsters-1] = new Monster("Dragon", 8, 6);
            
            return listOfMonsters;
        }

        // Do battle with monsters
        private void battle()
        {
            int attack;
            int defend;
            int damage;

            // keep battle going until one of participants dies
            if (turn % 2 == 0)
            {
                // Player's turn
                attack = newPlayer.attack();
                defend = monster.defend(); ;
                damage = System.Math.Abs(attack - defend);
                monster.Health -= damage;
                announce(newPlayer.Name + " has caused " + damage.ToString() + " damage to " + monster.Name + "!! \r\n");
            }
            else
            {
                // Monster's turn
                attack = monster.attack();
                defend = newPlayer.defend();
                damage = System.Math.Abs(attack - defend);
                newPlayer.Health -= damage;
                announce(monster.Name + " has caused " + damage.ToString() + " damage to " + newPlayer.Name + "!! \r\n");
            }

            // refresh health stats
            refreshStats();
            
            // next turn
            turn++;
        }

        private void announce(string msg) 
        {
            // output msg to form textbox
            txtOutput.Text += msg + "\r\n";

            // keep scrolling to the bottom of textbox
            txtOutput.SelectionStart = txtOutput.Text.Length;
            txtOutput.ScrollToCaret();
        }

        private void refreshStats()
        {
            // refresh health stats each time when function is called
            lblHeroHealthOutput.Text = newPlayer.Health.ToString() + " / 100";
            lblMonsterHealthOutput.Text = monster.Health.ToString() + " / 100";
        }

        private void btnStartBattle_Click(object sender, EventArgs e)
        { 
            if (monster.Health > 0)
            {
                // battle when monster is still alive
                btnStartBattle.Text = "Fight!";
                battle();
                btnNext.Enabled = false;

                if (newPlayer.Health <= 0)
                {
                    // game over
                    announce(newPlayer.Name + " has been killed by " + monster.Name + "! Drakenton is lost!");
                    MessageBox.Show("Game Over!");
                    btnStartBattle.Enabled = false;
                    btnHeal.Enabled = false;
                    btnRun.Enabled = false;
                }
                else if (monster.Health <= 0)
                {
                    // announce death of monster
                    announce(newPlayer.Name + " has killed " + monster.Name + "!");
                }

            }
            else
            {
                // monsters are extinct in this room
                announce("No monster in this room... go to next room.");
                btnStartBattle.Text = "Start Battle!";
                btnNext.Enabled = true;
            }
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            // will heal the player once per room
            newPlayer.Health += 20;
            announce(newPlayer.Name + " has healed himself!");
            refreshStats();
            btnHeal.Enabled = false;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // let's see if we can run away or not
            Random runRand = new Random();
            int luck = runRand.Next(1, 10);

            if (count - 1 <= 0)
            {
                // can't run from the first room
                MessageBox.Show("There's nowhere to run!");
            }
            else if (luck % 5 == 0)
            {
                // run back to previous room
                count--;
                monster = _monsters[count];
                btnHeal.Enabled = true;
                announce(newPlayer.Name + " escaped to the previous room!");
            }
            else
            {
                // we can only run once
                announce("You couldn't escape! " + monster.Name + " is too fast for you!");
                btnRun.Enabled = false;
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (count <= countMonsters)
            {
                // go to next room until we've exhausted all of the rooms
                count++;
                monster = _monsters[count];
                btnHeal.Enabled = true;
                refreshMonsterStats();
                announce("You explored the next room... What lurks here?!");
            }
            else
            {
                // game is won
                announce("You've defeated all of the monsters in the mountain!");
                MessageBox.Show("You win the game!");
                btnStartBattle.Enabled = false;
                btnHeal.Enabled = false;
                btnNext.Enabled = false;
                btnRun.Enabled = false;

            }
        }

        private void refreshMonsterStats()
        {
            lblMonsterNameOutput.Text = monster.Name;
            lblMonsterHealthOutput.Text = monster.Health.ToString();
            lblMonsterOffenseOutput.Text = monster.Offense.ToString();
            lblMonsterDefenseOutput.Text = monster.Defense.ToString();
        }

    }
}
