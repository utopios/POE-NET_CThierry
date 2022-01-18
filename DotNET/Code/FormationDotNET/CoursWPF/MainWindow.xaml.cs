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

namespace CoursWPF
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            //Init();
            //MakeMenu();
        }

        private void Init()
        {
            Button a = new Button()
            {
                Content = "Click Me ! ! !",
                Foreground = Brushes.Black,
                Background = Brushes.OrangeRed,
                Width = 150,
                Height = 50
            };
            a.Click += Button_Click;
            MyStackPanel.Children.Add(a);
        }

        private void MakeMenu()
        {
            Button b = new Button()
            {
                Content = "Bouton 1",
                Foreground = Brushes.Black,
                Background = Brushes.Green
            };
            b.Click += BtnMenu_Click;
            MyStackPanel.Children.Add(b);

            Button c = new Button()
            {
                Content = "Bouton 2",
                Foreground = Brushes.Black,
                Background = Brushes.Purple
            };
            c.Click += BtnMenu_Click;
            MyStackPanel.Children.Add(c);

            Button d = new Button()
            {
                Content = "Bouton 3",
                Foreground = Brushes.Black,
                Background = Brushes.Blue
            };
            d.Click += BtnMenu_Click;
            MyStackPanel.Children.Add(d);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BoiteOutilBtn.Content = "Content changé";
        }
        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("MakeMenuBTn Clické", "Information Click", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Edition_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Nouveau_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Ouvrir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Etes-vous sur de vouloir quitter l'application?", "Quitter?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    Environment.Exit(0);
                    break;
                case MessageBoxResult.No:
                    break;
            }
            
        }

        private void Event_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(e.OriginalSource.ToString());
            object m = sender;
            MessageBox.Show(m.ToString());
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Salut Olive!");
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
