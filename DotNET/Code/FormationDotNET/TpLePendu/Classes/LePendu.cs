using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLePendu.Classes
{
    internal class LePendu
    {
        #region Attributs
        GenerateurDeMots motGenere;
        private string motATrouver;
        private int nbreEssai;
        private string masque;
        #endregion

        #region Constructeurs
        public LePendu(GenerateurDeMots g)
        {
            motGenere = g;
            MotATrouver = g.Generer();
            GenerateurMasque();
            nbreEssai = 10;
        }
        public LePendu(GenerateurDeMots g, int nbreEssai)
        {
            motGenere = g;
            MotATrouver = g.Generer();
            GenerateurMasque();
            NbreEssai = nbreEssai;
        }

        #endregion

        #region Propriétés
        public string MotATrouver { get => motATrouver; set => motATrouver=value; }
        public int NbreEssai { get => nbreEssai; set => nbreEssai=value; }
        public string Masque { get => masque; set => masque=value; }
        #endregion

        #region Méthodes
        public bool TestChar(char c)
        {
            // Console.WriteLine(c);
            bool found= false;
            string masqueTmp="";
            for (int i = 0; i < MotATrouver.Length; i++)
            {
                //Console.WriteLine(MotATrouver[i]);
                if (MotATrouver[i] == c)
                {
                    found = true;
                    masqueTmp += c;
                }
                else
                {
                    masqueTmp += masque[i];
                }
                //Console.WriteLine(masqueTmp);
            }
            masque = masqueTmp;
            //Console.WriteLine(masque);

            if (found == false)
            {
                NbreEssai--;
            }
            return found;
        }

        public bool TestWin()
        {
            if (MotATrouver == Masque && NbreEssai >0)
                return true;            
            else
                return false;            
        }

        public void GenerateurMasque()
        {
            masque = "";

            //Console.WriteLine(motATrouver);

            for (int i = 0; i < motATrouver.Length; i++)
            {
                masque += "*";
            }

            //Console.WriteLine(masque);

        }
        #endregion
    }
}
