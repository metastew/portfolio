using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDGame
{
    public abstract class Armor
    {
        private int defense;
        private string name;

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
    }
}
