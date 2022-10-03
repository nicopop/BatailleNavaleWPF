﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BatailleNavaleWPF
{
    class Position
    {
        public int Ligne { get; }
        public int Colonne { get; }

        public Position(int ligne = 0, int colonne = 0)
        {
            Ligne = ligne;
            Colonne = colonne;
        }
    }
}
