using BatailleNavaleWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavaleWPF
{
    internal class Destroyer : Navire
    {
        public static int Longueur { get; } = 2;
        public Destroyer(Case[] carres) : base(carres)
        {
        }
    }
}
