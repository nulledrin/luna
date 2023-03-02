using ActiproSoftware.Windows.Themes;
using ActiproSoftware.Windows.Themes.Generation;
using System.Windows;
using System.Windows.Media;
using RestSharp;
using Newtonsoft.Json;
using System;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Media.Imaging;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

        

    public partial class MainWindow : Window
    {

        private int colorIndex = 0;
        public string FullName;
        public string status { get; set; }
        public string pfp { get; set; }



        public MainWindow()
        {
            
            ThemeManager.BeginUpdate();
            try
            {
                // Register the theme definitions for your application
                ThemeManager.RegisterThemeDefinition(new ThemeDefinition("Custom")
                {
                    Intent = ThemeIntent.Black,
                    ButtonPadding = new Thickness(2),
                    ButtonBackgroundGradientKind = GradientKind.None,
                    ButtonCornerRadius = 0,
                    CheckBoxCornerRadius = 0,
                    TabCornerRadius = 0,
                    ToolBarButtonCornerRadius = 0,
                });

                // Use the Actipro styles for native WPF controls that look great with Actipro's control products
                ThemeManager.AreNativeThemesEnabled = true;

                // Set the current app theme via a registered theme definition name
                ThemeManager.CurrentTheme = "Custom";
            }
            finally
            {
                ThemeManager.EndUpdate();
            }

            status = "1";
            InitializeComponent();
            checkconnection();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += timer_Tick;
            timer.Start();

        }
        void timer_Tick(object sender, EventArgs e)
        {
            checkconnection();
        }

        private void OnStatusBarColorButtonClick(object sender, RoutedEventArgs e)
        {
            var barColors = new Color[] {
                Color.FromRgb(1, 119, 206),
                Color.FromRgb(14, 99, 156),
                Color.FromRgb(104, 33, 122),
                Color.FromRgb(202, 81, 0),
                Color.FromRgb(159, 239, 0)
            };

            StatusBar1.Background = new SolidColorBrush(barColors[++colorIndex % 5]);
            if (barColors[++colorIndex % 5] == Color.FromRgb(159, 239, 0)) messagePanel.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#141d2b"));
            this.BorderBrush = StatusBar1.Background;
        }


        private void RankingDetails(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Heres gon b somth");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("abrakadabra");
        }

        public void checkconnection()
        {
            HackTheBox.Connection.Connect();
            if (HackTheBox.Connection.status == "0")
            {
                connectimage.Source = new BitmapImage(new Uri("C:\\Users\\Antonio La Cokos\\source\\repos\\WpfApp3\\WpfApp3\\images\\connectionfalse.png"));
                connecttxtblock.Text = "Not connected";
            } else if (HackTheBox.Connection.status == "Down")
            {
                connectimage.Source = new BitmapImage(new Uri("C:\\Users\\Antonio La Cokos\\source\\repos\\WpfApp3\\WpfApp3\\images\\connectionfalse.png"));
                connecttxtblock.Text = "Server Down";
            }
            else 
            {
                connectimage.Source = new BitmapImage(new Uri("C:\\Users\\Antonio La Cokos\\source\\repos\\WpfApp3\\WpfApp3\\images\\connections.png"));
                connecttxtblock.Text = HackTheBox.Connection.ip4;
            }
        }
    }
}
