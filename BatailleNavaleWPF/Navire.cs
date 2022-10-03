using System;

namespace BatailleNavaleWPF
{
    class Navire : INavire
    {
        //public TypeNavire Type { get; }
        public bool Coule { get => EstCoule(); }

        public char Type { get; }

        private readonly Case[] cases;

        public Navire (Case[] carres, char type)
        {
            Type= type;
            cases = carres;
            foreach (Case carre in cases)
            {
                carre.Navire = this;
            }
            Type = type;
        }

        private bool EstCoule()
        {
            foreach (Case carre in cases)
            {
                if (!carre.Touche) return false;
            }
            return true;
        }
    }
}
