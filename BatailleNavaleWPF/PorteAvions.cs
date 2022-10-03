using BatailleNavaleWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavaleWPF
{
    internal class PorteAvions : Navire
    {
        public static int Longueur { get; } = 5;
        public PorteAvions(Case[] carres) : base(carres)
        {
        }
    }
}
