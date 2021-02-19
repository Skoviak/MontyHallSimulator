using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHallRecreate
{
    public class Door
    {
        public int number { get; set; }
        public bool isCosmicForge { get; set; }
        public bool isSelected { get; set; }
        public bool isRevealed { get; set; }
        public string imagePath { get; set; }

        public Door()
        {
            isCosmicForge = false;
            isSelected = false;
            isRevealed = false;
        }
    }
}