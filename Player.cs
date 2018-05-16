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

namespace Duck_Hunt
{
    class Player
    {
        MouseButtonState Previousmbs = MouseButtonState.Released;
        public bool MouseClicked()
        {
            //Console.WriteLine(Mouse.LeftButton.ToString() + "\t" + Previousmbs.ToString());
            FileStream fileStream = new FileStream("crossHairbyPeter.cur", FileMode.Open);
            Cursor crossHair = new Cursor(fileStream);
            Mouse.SetCursor(crossHair);


            if (Mouse.LeftButton == MouseButtonState.Pressed && Previousmbs == MouseButtonState.Released)
            {
                Previousmbs = Mouse.LeftButton;
                return true;
            }
            else
            {
                Previousmbs = Mouse.LeftButton;
                return false;
            }
            
        }
    }
}
