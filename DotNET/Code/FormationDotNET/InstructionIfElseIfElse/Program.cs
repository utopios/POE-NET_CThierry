using System;

namespace InstructionIfElseIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exemple de structure conditionnelle If...Else If... Else avec block d'instructions
            double compteEnBanque = 300;
            if (compteEnBanque > 0)
            {
                Console.WriteLine("Votre compte est créditeur");
                Console.WriteLine("Le montant du compte est : " + compteEnBanque);
            }
            else if (compteEnBanque == 0)
            {
                Console.WriteLine("Votre solde est nul");
                Console.WriteLine("Le montant du compte est : " + compteEnBanque);
            }
            else
            {
                Console.WriteLine("Votre compte est débiteur");
                Console.WriteLine("Le montant du compte est : " + compteEnBanque);
            }
            #endregion

            #region Exemple de structure conditionnelle If...Else If... Else avec une seule instructions

            if (compteEnBanque > 0)
                Console.WriteLine("Votre compte est créditeur");
            else if (compteEnBanque == 0)
                Console.WriteLine("Votre solde est nul");
            else
                Console.WriteLine("Votre compte est débiteur");

            #endregion

        }
    }
}
