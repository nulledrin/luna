using System;
using System.Net.NetworkInformation; //Include this
using System.Windows;


namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    /// 

    public partial class Window1 : Window
    {
        public string Ready { get; set; } = "Offline";

        public Window1()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        static void Ping(string[] args)
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send("192.168.1.3", 1);
                if (reply != null)
                {
                    Console.WriteLine("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address);
                    //Console.WriteLine(reply.ToString());

                }
            }
            catch
            {
                Console.WriteLine("ERROR: You have Some TIMEOUT issue");
            }
            Console.ReadKey();
        }

        private void opennext(object sender, RoutedEventArgs e)
        {
            Propertiess mnw = new Propertiess();
            mnw.Owner = this;
            this.Hide(); // not required if using the child events below
            mnw.ShowDialog();
        }

        private void lbiblankselected(object sender, RoutedEventArgs e)
        {
            serverip.IsEnabled = false;
            specialcheckbox.IsEnabled = false;
            otpbox.IsEnabled = false;
        }

        private void lbiserverselected(object sender, RoutedEventArgs e)
        {
            serverip.IsEnabled = false;
            specialcheckbox.IsEnabled = false;
            otpbox.IsEnabled = false;
        }

        private void lbiclientselected(object sender, RoutedEventArgs e)
        {
            serverip.IsEnabled = true;
            otpbox.IsEnabled = true;
            specialcheckbox.IsEnabled = true;
        }
    }
}
