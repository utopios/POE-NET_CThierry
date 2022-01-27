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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TirageWPF.Classes;

namespace TirageWPF
{
    public partial class MainWindow : Window
    {
        private Draw draw;

        internal Draw Draw { get => draw; set => draw = value; }

        public MainWindow()
        {
            InitializeComponent();
            Draw = new Draw();            
            RefreshList();
        }

        private void MakeDraw(object sender, RoutedEventArgs e)
        {
            Person tmp = Draw.MakeDraw();

            if (tmp != null)
            {
                DrawingResult1.Text = "La personne tirée au sort est :";
                DrawingResult2.Text = tmp.ToString();
                MessageBoxResult messageBoxResult = MessageBox.Show($"Souhaitez-vous ajouter {tmp.Title} {tmp.LastName.ToUpper()} {tmp.FirstName.ToUpper()}  à la liste des utilisateurs déja tirés ?", "Confirmez l'ajout", MessageBoxButton.YesNo,MessageBoxImage.Question);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    Draw.SaveDraw(tmp);
                    RefreshList();
                }
                else
                {
                    resetText();
                    RefreshList();
                }

            }
            else
            {
                DrawingResult1.Text = "Veuillez créer une";
                DrawingResult2.Text = "liste de personnes";
            }
        }
        public void RefreshList()
        {
            OriginListView.ItemsSource = Draw.PersonList;
            AlreadyListView.ItemsSource = Draw.AlreadyList;
            NumPersonnesView.Text = $"Liste des {Draw.PersonList.Count} personnes à tirer";
            NumDrawedView.Text = $"{Draw.AlreadyList.Count} personnes ont déjà été tirées";
        }
        private void resetText()
        {
            DrawingResult1.Text = "";
            DrawingResult2.Text = "";
        }

        private void CreateList_Click(object sender, RoutedEventArgs e)
        {
            AddListePerson fenetre = new AddListePerson(this);
            fenetre.Show();
        }

        private void ClearDrawedList_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show($"Souhaitez-vous supprimer la liste des utilisateurs déja tirés ?", "Confirmez la suppréssion", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Draw.AlreadyList.Clear();
                Draw.Save();
                RefreshList();
                resetText();
                MessageBox.Show("Liste des personnes tirées vide!", "Informations nettoyage réussi", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }            
        }

    
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show($"Etes-vous sûr de vouloir quitter l'application?", "Confirmer la fermeture du programme", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                MessageBox.Show("A bientôt... !", "Quitter le programme", MessageBoxButton.OK, MessageBoxImage.Information);
                Environment.Exit(0);
            }            
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void LoadList_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
