using BatailleNavaleWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavaleWPF
{
    internal class Patrouilleur : Navire
    {
        public static int Longueur { get; } = 3;
        public Patrouilleur(Case[] carres) : base(carres)
        {
        }
    }
}
