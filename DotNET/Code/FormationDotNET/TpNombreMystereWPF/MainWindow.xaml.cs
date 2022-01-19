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
            nbMystere = aleatoire.Next(1, 51);
            nbCoups = 0;
            TextBoxResult1.Text = "";
            TextBoxResult2.Text = "Veuillez saisir un chiffre/Nombre";
            UpdateNbCoups();
            TBoxNbUser.Focus();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            int nbUser = TryRead(TBoxNbUser.Text);
            if(nbUser != -1)
                Comparer(nbUser);            
        }
        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            Start();
        }

        private int TryRead(string text)
        {
            int tmp=-1;
            try
            {
                tmp = Convert.ToInt32(text);
            }
            catch (Exception)
            {
                TextBoxResult1.Text = "Erreur de saisie...";
                TBoxNbUser.Text = ""; 
            }
            return tmp;
        }       


        private void DisplayResult(string result)
        {
            TextBoxResult1.Text = $"C'est {result}...!";
            TBoxNbUser.Text = "";
            UpdateNbCoups();
        }

        private void UpdateNbCoups()
        {            
            TBNbEssais.Text = $"Nombre d'essais : {nbCoups} ";
        }

        private void Win()
        {
            UpdateNbCoups();
            TBoxNbUser.Text = "";
            TextBoxResult1.Text = $"Bravo !!! Vous avez trouvé en {nbCoups} coups!";
            TextBoxResult2.Text = $"Le nombre mystère était {nbMystere}";
        }

        void Comparer(int nbUser)
        {
            nbCoups++;
            if (nbUser == nbMystere)
                Win();
            else if (nbUser < nbMystere)
                DisplayResult("plus");
            else
                DisplayResult("moins");
        }

        private void TextBoxNbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Valider_Click(sender, e);
            }
        }
    }
}
