﻿using BatailleNavaleWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavaleWPF
{
    internal class SousMarin : Navire
    {
        public SousMarin(Case[] carres) : base(carres, 1)
        {
        }
    }
}
