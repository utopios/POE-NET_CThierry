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

namespace CoursWPF
{
    /// <summary>
    /// Logique d'interaction pour ImageWindow.xaml
    /// </summary>
    public partial class ImageWindow : Window
    {
        public ImageWindow()
        {
            InitializeComponent();
        }

        private void Changer_Click(object sender, RoutedEventArgs e)
        {
            int index = -1;
            var images = ImagesDockPanel.Children.OfType<Image>();
            Image image = images.FirstOrDefault(img => img.Visibility == Visibility.Visible);
            image.Visibility = Visibility.Collapsed;
            Image[] imgTmp = images.ToArray();
            index = Array.IndexOf(imgTmp, image);
            string nameTmp;
            if (index <2)
            {
                index++;
                nameTmp = "Img" + index;
            }
            else
            {
                nameTmp = "Img0";
            }
            Image tmp = images.FirstOrDefault(img => img.Name == nameTmp);
            tmp.Visibility = Visibility.Visible;
        }
    }
}
