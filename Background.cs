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
using System.IO;

namespace Duck_Hunt_1._1
{
    class Background
    {
        public Background(Canvas canvas)
        {
            BitmapImage GrassURI = new BitmapImage(new Uri
                ("https://raw.githubusercontent.com/drmikeh/duck-hunt/master/app/images/grass.png"));
           Image Grass = new Image();
            Grass.Source = GrassURI;
            Grass.Height = 201;
            Grass.Width = 1000;
            Canvas.SetTop  (Grass, 599);
            ///Grass.Fill = Brushes.LimeGreen;
            canvas.Background = Brushes.LightBlue;
            canvas.Children.Add(Grass);
            canvas.UpdateLayout();
            
        }  
    }
}
