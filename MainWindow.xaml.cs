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

namespace Duck_Hunt_1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Duck duck = new Duck();
        Player player = new Player();
        MediaPlayer musicPlayer = new MediaPlayer();

        System.Windows.Threading.DispatcherTimer gameTimer = new System.Windows.Threading.DispatcherTimer();
        int counter = 0;

        public MainWindow()
        {
            InitializeComponent();

            Background background = new Background(Canvas);
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / 60);//fps
            gameTimer.Start();
            //start music
            //musicPlayer.Open(new Uri("tapperSong.mp3", UriKind.Relative));
            //musicPlayer.Play();
            duck.Spawn(Canvas);
            duck.Move(counter);
            //BitmapImage bitmapImage = new BitmapImage(new Uri("Image1.png"));
            //ImageBrush img = new ImageBrush(bitmapImage);
            //Canvas.Background = img;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (player.MouseClicked())
            {
                this.Title = Mouse.GetPosition(this).ToString();
                Console.WriteLine(Mouse.GetPosition(this).ToString());
                double Shot_X;
                double Shot_Y;
                Shot_X = Mouse.GetPosition(this).X;
                Shot_Y = Mouse.GetPosition(this).Y;
                duck.Shoot(Shot_X, Shot_Y, Canvas, counter);
            }
            if (Keyboard.IsKeyDown(Key.Enter))
            {
                duck.Spawn(Canvas);
            }
            else { this.Title = "no click"; }
            counter++;
            //this.Title = counter.ToString();
            duck.Move(counter);
        }
    }
}
