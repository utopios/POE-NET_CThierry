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
using TpCompteBancaireAdoWPF.View;

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
            CreateWindow c = new CreateWindow();
            c.Show();
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
                    TBxIdCompte.Text = "";
                }
                if (id > 0)
                {
                    compte = Compte.RechercherCompte(id);
                    DisplayCompte(compte);
                }
            }
            else
                MessageBox.Show("Veuillez saisir l'id d'un compte", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void DisplayCompte(Compte c)
        {
            TBxIdCompte.Text = "";
            TbNom.Text = c.Client.Nom;
            TbPrenom.Text = c.Client.Prenom;
            TbTelephone.Text = c.Client.Telephone;
            TBIdCompte.Text = c.Id.ToString();
            TBSolde.Text = c.Solde.ToString();
            ListeWiewOperation.ItemsSource = c.Operations;
        }

        private void FaireDepot_Click(object sender, RoutedEventArgs e)
        {
            if (TBIdCompte.Text != "")
            {
                DepotOperationWindow d = new DepotOperationWindow(Convert.ToInt32(TBIdCompte.Text),this);
                d.Show();
            }
            else
                MessageBox.Show("Veuillez séléctionner un compte", "Erreur Compte", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void FaireRetrait_Click(object sender, RoutedEventArgs e)
        {
            if (TBIdCompte.Text != "")
            {
                RetraitOperationWindow r = new RetraitOperationWindow(Convert.ToInt32(TBIdCompte.Text), this);
                r.Show();
            }
            else
                MessageBox.Show("Veuillez séléctionner un compte", "Erreur Compte", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        public void ActualiserCompte(int numCompte)
        {
            compte = Compte.RechercherCompte(numCompte);
            if (compte!= null)
            {
                DisplayCompte(compte);
            }
            else
                MessageBox.Show("Aucun compte trouvé avec cet Id", "Erreur Compte non trouvé", MessageBoxButton.OK, MessageBoxImage.Warning);

        }
    }
}
