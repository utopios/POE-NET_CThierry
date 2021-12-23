﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLePendu.Classes
{
    internal class GenerateurDeMots
    {
        private string[] mots = new string[] {"amazon","google","facebook","microsoft","macintosh","instagram","statix","idefix"};

        public string Generer()
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, mots.Length);
            return mots[randomIndex];
        }
    }
}
