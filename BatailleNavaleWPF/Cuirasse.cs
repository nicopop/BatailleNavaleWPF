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
        public static int Longueur { get; } = 4;
        public Cuirasse(Case[] carres) : base(carres)
        {
        }
    }
}
