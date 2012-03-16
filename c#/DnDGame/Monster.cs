using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDGame
{
    public class Monster : Character
    {
        private Armor _armor;
        private Weapon _weapon;

        public Monster(string name, int offense, int defense)
        {
            Name = name;
            Offense = offense;
            Defense = defense;
            Health = 100;
        }

        public Armor Armor
        {
            get
            {
                return _armor;
            }
            set
            {
                _armor = value;
            }
        }

        public Weapon Weapon
        {
            get
            {
                return _weapon;
            }
            set
            {
                _weapon = value;
            }
        }
    }
}
