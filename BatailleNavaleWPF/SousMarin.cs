using BatailleNavaleWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavaleWPF
{
    internal class SousMarin : Navire
    {
        public static int Longueur { get; } = 1;
        public SousMarin(Case[] carres) : base(carres, 'S')
        {
        }
    }
}
