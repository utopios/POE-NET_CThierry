using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLePendu.Classes
{
    internal class GenerateurDeMots
    {
        #region Création d'une collection de mots
        private string[] mots = new string[] { "amazon", "google", "facebook", "microsoft", "macintosh", "instagram", "statix", "idefix" };
        #endregion

        #region Méthode Générer (retourne un mot)
        public string Generer()
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, mots.Length);
            return mots[randomIndex];
        }

        #endregion
    }
}
