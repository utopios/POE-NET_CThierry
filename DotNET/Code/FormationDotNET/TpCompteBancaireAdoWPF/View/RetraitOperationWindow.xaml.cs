using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TpCompteBancaireAdoWPF.Classes;

namespace TpCompteBancaireAdoWPF.View
{
    public partial class RetraitOperationWindow : Window
    {
        Compte cTmp;
        MainWindow w;
        public RetraitOperationWindow( int numCompte , MainWindow windows)
        {
            InitializeComponent();
            cTmp = Compte.RechercherCompte(numCompte);
            TbIdCompte.Text = cTmp.Id.ToString();
            w = windows;
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            decimal montant;
            if (decimal.TryParse(TbxMontant.Text, out montant))
            {
                montant *= -1;
                Operation o = new Operation(montant);
                cTmp.Retrait(o);
                MessageBox.Show($"Le Retrait de {montant} € a été effectué", "Retrait Effectué", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            w.ActualiserCompte(cTmp.Id);
            this.Close();
        }

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
