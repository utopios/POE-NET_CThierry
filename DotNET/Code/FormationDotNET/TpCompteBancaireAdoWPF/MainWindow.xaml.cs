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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TpCompteBancaireAdoWPF.Classes;

namespace TpCompteBancaireAdoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Compte compte;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NouveauCompte_Click(object sender, RoutedEventArgs e)
        {           
            
        }

        private void RechercherCompte_Click(object sender, RoutedEventArgs e)
        {
            if (TBxIdCompte.Text != "")
            {
                int id = -1;
                try
                {
                    id = Convert.ToInt32(TBxIdCompte.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Veuillez saisir un chiffre/nombre", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if (id > 0)
                {
                    compte = Compte.RechercherCompte(id);
                }
            }
            else
                MessageBox.Show("Veuillez saisir l'id d'un compte", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void FaireDepot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FaireRetrait_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
