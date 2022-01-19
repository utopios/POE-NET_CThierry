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

namespace TpNombreMystereWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Attributs
        static Random aleatoire = new Random();
        int nbMystere;
        int nbCoups;        
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            int nbMystere = aleatoire.Next(1, 51);
            int nbCoups = 0;
            TextBoxResult1.Text = "test";
            TextBoxResult2.Text = nbMystere.ToString();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PlusGrand()
        {
            
        }

        private void PlusPetit()
        {

        }
        private void Win()
        {

        }
        void Comparer(int nbUser)
        {
            if (nbUser == nbMystere)
                Win();
            else if (nbUser < nbMystere)
                PlusGrand();
            else
                PlusPetit();
        }
    }
}
