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
using TpListePersonneWPF.Classes;
using TpListePersonneWPF.Data;

namespace TpListePersonneWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Person> contacts;
        public MainWindow()
        {
            InitializeComponent();
            AfficherListeContact();
        }

        private void AfficherListeContact()
        {
            contacts = Person.GetList();
            ListeViewContact.ItemsSource = contacts;
        }
        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            string titre = null;
            var radios = radioBtn.Children.OfType<RadioButton>();
            RadioButton checkedRadio = radios.FirstOrDefault(rb => rb.GroupName == "Titre" && rb.IsChecked == true);
            try
            {
                titre = checkedRadio.Content.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur a été levée : " + ex.Message, "Exception Levée", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (titre != null && Nom.Text != "" && Prenom.Text != "" && Email.Text != "" && Telephone.Text != "")
            {
                Person p = new Person(titre, Nom.Text, Prenom.Text, Email.Text, Telephone.Text);
                p.Id = p.Add();
                if (p.Id>0)
                {
                    AfficherListeContact();
                    Nom.Text = "";
                    Prenom.Text = "";
                    Email.Text = "";
                    Telephone.Text = "";                    
                    MessageBox.Show($"Contact Ajouté avec l'id : {p.Id}", "Contact Ajouté ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du contact ", "Erreur lors de l'ajout", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                
            }
            else
                MessageBox.Show("Veuillez remplir tous les champs avant de valider", "Erreur de saisie...", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void ValMod_Click(object sender, RoutedEventArgs e)
        {
            int id;
            string titre = "";
            var radios = radioBtnMod.Children.OfType<RadioButton>();
            RadioButton checkedButton = radios.FirstOrDefault(rb => rb.GroupName == "TitreMod" && rb.IsChecked == true);
            titre = checkedButton.Content.ToString();
            id = Convert.ToInt32(IdMod.Text);
            Person p = new Person(titre, NomMod.Text, PrenomMod.Text, EmailMod.Text, TelephoneMod.Text);
            p.Id = id;
            MessageBoxResult result = MessageBox.Show("Etes-vous sur de vouloir modifier le contact? ?", "Confirmation de modification", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    if (p.Update())
                    {
                        AfficherListeContact();
                        IdMod.Text = "";
                        NomMod.Text = "";
                        PrenomMod.Text = "";
                        EmailMod.Text = "";
                        TelephoneMod.Text = "";
                        checkedButton.IsChecked = false;
                        ModifierGroup.Visibility = Visibility.Collapsed;
                        AjouterGroup.Visibility = Visibility.Visible;
                        MessageBox.Show("Contact modifié : \n" + p.ToString(), "Confirmation de modification", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                        MessageBox.Show("Erreur lors de la modification du contact", "Erreur de modification", MessageBoxButton.OK, MessageBoxImage.Warning);
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Modification refusée", "Information de modification", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Modification annulée", "Information de modification", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
            }            
            
        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            if (ListeViewContact.SelectedItem != null)
            {
                Person p = (Person)ListeViewContact.SelectedItem;
                var radios = radioBtnMod.Children.OfType<RadioButton>();
                RadioButton checkedRadio = radios.FirstOrDefault(rb => rb.GroupName == "TitreMod" && (string)rb.Content == p.Title);
                checkedRadio.IsChecked = true;
                IdMod.Text = p.Id.ToString();
                NomMod.Text = p.LastName;
                PrenomMod.Text = p.FirstName;
                EmailMod.Text = p.Email;
                TelephoneMod.Text = p.Phone;
                AjouterGroup.Visibility = Visibility.Collapsed;
                ModifierGroup.Visibility = Visibility.Visible;
            }
            else
                MessageBox.Show("Veuillez séléctionner une entrée de la liste", "Erreur de séléction...", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            if (ListeViewContact.SelectedItem != null)
            {
                Person p = (Person)ListeViewContact.SelectedItem;
                MessageBoxResult result = MessageBox.Show("Etes-vous sur de vouloir supprimer le contact? ?", "Confirmation de modification", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        if (p.Delete())
                        {
                            AfficherListeContact();
                            MessageBox.Show("Contact Supprimé..", "Confirmation de suppression", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                            MessageBox.Show("Erreur lors de la suppression du contact", "Erreur de modification", MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show("Suppression refusée", "Information de modification", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    case MessageBoxResult.Cancel:
                        MessageBox.Show("Suppression annulée", "Information de modification", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                }                
            }
            else
                MessageBox.Show("Merci de sélectionner un contact!", "Aucun contact séléctionné", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
