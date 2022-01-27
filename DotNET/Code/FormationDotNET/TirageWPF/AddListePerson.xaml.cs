using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TirageWPF.Classes;

namespace TirageWPF
{
    /// <summary>
    /// Logique d'interaction pour AddListePerson.xaml
    /// </summary>
    public partial class AddListePerson : Window
    {
        ObservableCollection<Person> newList;
        MainWindow w;
        public AddListePerson(MainWindow window)
        {
            InitializeComponent();
            newList = new ObservableCollection<Person>();
            ListeViewPerson.ItemsSource = newList;
            w = window;
        }
        private void AddToList_Click(object sender, RoutedEventArgs e)
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
            if (titre != null && Nom.Text != "" && Prenom.Text != "")
            {
                Person p = new Person(titre, Nom.Text, Prenom.Text);
                newList.Add(p);
                Nom.Text = "";
                Prenom.Text = "";
            }
            else
                MessageBox.Show("Veuillez remplir tous les champs avant de valider", "Erreur de saisie...", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        private void ValiderList_Click(object sender, RoutedEventArgs e)
        {
            if (newList.Count > 1)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show($"Etes-vous sûr de vouloir valider la liste pour le tirage ?", "Confirmez la création", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    w.Draw.PersonList = newList;
                    MessageBox.Show("La liste à été ajoutée", "Sauvegarde de la liste", MessageBoxButton.OK, MessageBoxImage.Information);
                    w.RefreshList();
                    w.Draw.SaveNewList();
                    this.Close();
                }
            }
            else
                MessageBox.Show("La liste doit contenir au moins deux personnes", "Liste incomplète", MessageBoxButton.OK, MessageBoxImage.Warning);


        }
        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            if (ListeViewPerson.SelectedItem != null)
            {
                Person p = (Person)ListeViewPerson.SelectedItem;
                MessageBoxResult messageBoxResult = MessageBox.Show($"Etes-vous sûr de vouloir supprimer {p.Title} {p.LastName.ToUpper()} {p.FirstName.ToUpper()} de la liste ?", "Confirmez la création", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (messageBoxResult == MessageBoxResult.Yes)
                    newList.Remove(p);
            }
            else
                MessageBox.Show("Merci de sélectionner une personne dans la liste!", "Aucune personne séléctionné", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        private void ClearList_Click(object sender, RoutedEventArgs e)
        {
            if (newList.Count>0)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show($"Etes-vous sûr de vouloir vider totalement la liste ?", "Confirmez la suppression", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (messageBoxResult == MessageBoxResult.Yes)
                    newList.Clear();                
            }
            else
                MessageBox.Show("La liste est vide!", "Liste Vide", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        private void LoadPersonList_Click(object sender, RoutedEventArgs e)
        {
            newList = w.Draw.PersonList;
            ListeViewPerson.ItemsSource = newList;
        }

        private void SaveList_Click(object sender, RoutedEventArgs e)
        {
            string fileName = UserFileName.Text;
            MessageBoxResult messageBoxResult = MessageBox.Show($"Etes-vous sûr de sauvegarder la liste {fileName}.txt ?", "Confirmez la sauvegarde", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                w.Draw.SaveUserList(fileName,newList);

                MessageBox.Show("La liste à été sauvegardée", "Sauvegarde de la liste", MessageBoxButton.OK, MessageBoxImage.Information);
                w.RefreshList();
                this.Close();
            }
        }
    }
}
