using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DnDGame
{
    public abstract class Weapon
    {
        private string name;
        private int offense;

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
