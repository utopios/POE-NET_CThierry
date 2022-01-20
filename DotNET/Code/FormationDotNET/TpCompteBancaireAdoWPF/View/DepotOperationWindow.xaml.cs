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
    public partial class DepotOperationWindow : Window
    {
        Compte cTmp;
        MainWindow w;
        public DepotOperationWindow(int numCompte, MainWindow window)
        {
            InitializeComponent();
            cTmp = Compte.RechercherCompte(numCompte);
            TbIdCompte.Text = cTmp.Id.ToString();
            w = window;
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            decimal montant;
            if (decimal.TryParse(TbxMontant.Text, out montant))
            {
                Operation o = new Operation(montant);
                cTmp.Depot(o);
                MessageBox.Show($"Le dépot de {montant} € a été effectué", "Dépôt Effectué", MessageBoxButton.OK, MessageBoxImage.Information);
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
