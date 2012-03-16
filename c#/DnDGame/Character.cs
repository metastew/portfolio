using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDGame
{
    public abstract class Character
    {
        private string name;
        private int offense;
        private int defense;
        private int health;
        private Random r = new Random();

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Offense
        {
            get
            {
                return offense;
            }
            set
            {
                offense = value;
            }
        }

        public int Defense
        {
            get
            {
                return defense;
            }
            set
            {
                defense = value;
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public int attack()
        {
            return Offense;
        }

        public int defend()
        {
            return Defense;
        }

    }
}
