using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDGame
{
    public class Player : Character
    {
        private int experience;
        private int level;
        private Weapon weapon;
        private string charClass;
        private Armor armor;
        private bool created = false;

        public Player()
        {
            Health = 100;
            Level = 1;
            Exp = 0;
            weapon = null;
            armor = null;
        }

        public int Exp
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        public Weapon Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public Armor Armor
        {
            get
            {
                return armor;
            }
            set
            {
                armor = value;
            }
        }

        public string Class
        {
            get
            {
                return charClass;
            }
            set
            {
                charClass = value;
            }
        }

        public bool Created
        {
            get
            {
                return created;
            }
            set
            {
                created = value;
            }

        }

        public void levelUp()
        {
            //figure out exp stuff here
        }

        public void getLoot()
        {
            //figure out how to get loots here
        }

        public int attack()
        {
            if (weapon != null)
            {
                // if player has a weapon, add weapon offense to attack
                return Offense + weapon.Offense;
            }
            else
            {
                return Offense;
            }
        }

        public int defend()
        {
            if (armor != null)
            {
                // if player has an armor, add armor defense to defend
                return Defense + armor.Defense;
            }
            else
            {
                return Defense;
            }
        }
    }
}
