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

namespace TpCompteBancaireAdoWPF.View
{
    /// <summary>
    /// Logique d'interaction pour CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {
        public CreateWindow()
        {
            InitializeComponent();
        }

        private void Fermer_Click(object sender, RoutedEventArgs e)
        {           
            //MainWindow m = new MainWindow();
            //m.Show();
            this.Close();
        }

        private void AjouterCompte_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
