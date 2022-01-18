using CoursWPF.Classes;
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

namespace CoursWPF
{
    /// <summary>
    /// Logique d'interaction pour ListViewWindow.xaml
    /// </summary>
    public partial class ListViewWindow : Window
    {
        internal ObservableCollection<Person> personList;
        public ListViewWindow()
        {
            InitializeComponent();
            personList = new ObservableCollection<Person>();
            FillListPerson();
            RefreshLisBoxView();
        }

        private void FillListPerson()
        {
            Person p1 = new Person("Di Persio", "Anthony", 25);
            Person p2 = new Person("Toto", "Titi", 15);
            Person p3 = new Person("Foo", "Bar", 35);
            Person p4 = new Person("Doe", "John", 45);
            personList.Add(p1);
            personList.Add(p2);
            personList.Add(p3);
            personList.Add(p4);
        }

        private void RefreshLisBoxView()
        {
            ListBoxView.ItemsSource = personList;
        }

        private void Afficher_Click(object sender, RoutedEventArgs e)
        {
            string tmp = UserInput.Text;
            AfficherMessage.Text = tmp;
        }

        private void Effacer_Click(object sender, RoutedEventArgs e)
        {
            UserInput.Text="";
            AfficherMessage.Text = "";
        }
    }
}
