using BatailleNavaleWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavaleWPF
{
    internal class Cuirasse : Navire
    {
        public Cuirasse(Case[] carres) : base(carres, 4)
        {
        }
    }
}
