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
        //public LePendu(string motATrouver, int nbreEssai, string masque)
        //{
        //    MotATrouver=motATrouver;
        //    NbreEssai=nbreEssai;
        //    Masque=masque;
        //}
        #endregion

        #region Propriétés
        public string MotATrouver { get => motATrouver; set => motATrouver=value; }
        public int NbreEssai { get => nbreEssai; set => nbreEssai=value; }
        public string Masque { get => masque; set => masque=value; }
        #endregion

        #region Méthodes
        public bool TestChar()
        {
            return true;
        }

        public bool TestWin()
        {
            return true;
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
