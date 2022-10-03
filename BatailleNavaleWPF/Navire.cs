using System;

namespace BatailleNavaleWPF
{
    class Navire : INavire
    {
        //public TypeNavire Type { get; }
        public bool Coule { get => EstCoule(); }
        public int Longueur { get; }

        private readonly Case[] cases;

        public Navire (Case[] carres, int longeur)
        {
            cases = carres;
            Longueur = longeur;
            foreach (Case carre in cases)
            {
                carre.Navire = this;
            }
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
