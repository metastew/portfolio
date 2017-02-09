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
    public partial class frmPointAllocation : Form
    {
        private int points = 2;
        Player newPlayer = null;
        private int ClassOffenseStat = 0;
        private int ClassDefenseStat = 0;

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public frmPointAllocation(Player player)
        {
            InitializeComponent();
            newPlayer = player;
            ClassOffenseStat = newPlayer.Offense;
            ClassDefenseStat = newPlayer.Defense;
            lblDefenseStat.Text = newPlayer.Defense.ToString();
            lblOffenseStat.Text = newPlayer.Offense.ToString();
            lblPointClass.Text = newPlayer.Class + " class.";
            lblHowManyPoints.Text = this.points.ToString() + " pts to allocate.";
        }

        private void btnOffenseAdd_Click(object sender, EventArgs e)
        {
            if (points > 0)
            {
                newPlayer.Offense += 1;
                this.points = this.points - 1;
                lblOffenseStat.Text = newPlayer.Offense.ToString();
                lblHowManyPoints.Text = this.points.ToString() + " pts to allocate.";

            }
            else
            {
                MessageBox.Show("No more points to allocate!");
            }
        }

        private void btnOffenseSub_Click(object sender, EventArgs e)
        {
            if (points < 2)
            {
                if (newPlayer.Offense > ClassOffenseStat)
                {
                    newPlayer.Offense -= 1;
                    this.points = this.points + 1;
                    lblOffenseStat.Text = newPlayer.Offense.ToString();
                    lblHowManyPoints.Text = this.points.ToString() + " pts to allocate.";
                }
                else
                {
                    MessageBox.Show("You can't deallocate your Class's default offense stat!");
                }
            }
            else
            {
                MessageBox.Show("Points are not allocated yet!");
            }
        }

        private void btnDefenseAdd_Click(object sender, EventArgs e)
        {
            if (points > 0)
            {
                newPlayer.Defense += 1;
                this.points = this.points - 1;
                lblDefenseStat.Text = newPlayer.Defense.ToString();
                lblHowManyPoints.Text = this.points.ToString() + " pts to allocate.";

            }
            else
            {
                MessageBox.Show("No more points to allocate!");
            }
        }

        private void btnDefenseSub_Click(object sender, EventArgs e)
        {
            if (points < 2)
            {
                if (newPlayer.Defense > ClassDefenseStat)
                {
                    newPlayer.Defense -= 1;
                    this.points = this.points + 1;
                    lblDefenseStat.Text = newPlayer.Defense.ToString();
                    lblHowManyPoints.Text = this.points.ToString() + " pts to allocate.";
                }
                else
                {
                   MessageBox.Show("You can't deallocate your Class's default defense stat!");
                }
            }
            else
            {
                MessageBox.Show("Points are not allocated yet!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmFinalConfirmation final = new frmFinalConfirmation(newPlayer);

            final.Show();
            this.Close();
        }
    }
}
