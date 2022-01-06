using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethodes.Classes
{
    static class ExtentionMethode
    {
        public static void Shuffle<T>(this List<T> liste)
        {
            
            for (int i = 0; i < liste.Count; i++)
            {
                Random random = new Random();
                int index = random.Next(liste.Count);
                var tmp = liste[i];
                liste[i] = liste[index];
                liste[index] = tmp;
            }
        }
    }
}
