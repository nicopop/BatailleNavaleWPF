using BatailleNavaleWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavaleWPF
{
    internal class Cuirasse : INavire
    {
        public bool Coule { get => EstCoule(); }
        private readonly Case[] Cases;

        private bool EstCoule()
        {
            foreach (Case carre in Cases)
            {
                if (!carre.Touche) return false;
            }
            return true;
        }
    }
}
