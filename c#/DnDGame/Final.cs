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
    public partial class frmFinalConfirmation : Form
    {
        Player newPlayer = null;

        public frmFinalConfirmation(Player player)
        {
            InitializeComponent();
            newPlayer = player;
            
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            if (!txtName.Text.Equals(""))
            {
                if (txtName.Text.Length <= 25)
                {
                    newPlayer.Name = txtName.Text;
                    newPlayer.Created = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your name must be no greater than 25 characters!");
                }
            }
            else
            {
                MessageBox.Show("You haven't entered a name yet!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFinalConfirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
