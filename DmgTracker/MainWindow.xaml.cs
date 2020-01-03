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

namespace DmgTracker
{
    public partial class MainWindow : Window
    {
        public Button ammo;

        public List<Button> buttons;

        public SolidColorBrush brush;

        public MainWindow()
        {
            InitializeComponent();

            buttons = new List<Button>() {
                mm9, acp45, mm10, ae50,
                mag357, mag44, mag500,
                mm556, grendel, mm762, blackout,
                winmag, lapmag, bmg};

            brush = new SolidColorBrush(Color.FromRgb(221, 221, 221));

           
        }

        private void CheckShort_Checked(object sender, RoutedEventArgs e)
        {
            CheckMedium.IsChecked = false;
            CheckLong.IsChecked = false;
        }

        private void CheckMedium_Checked(object sender, RoutedEventArgs e)
        {
            CheckShort.IsChecked = false;
            CheckLong.IsChecked = false;
        }

        private void CheckLong_Checked(object sender, RoutedEventArgs e)
        {
            CheckShort.IsChecked = false;
            CheckMedium.IsChecked = false;
        }

        private void OnAmmoClick(Button button)
        {
            foreach (Button tempButton in buttons)
            {
                tempButton.Background = brush;
            }

            button.Background = Brushes.Gray;

            ammo = button;
        }

        private void mm9_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(mm9);
        }

        
        private void acp45_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(acp45);
        }      

        private void mm10_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(mm10);
        }

        private void ae50_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(ae50);
        }

        private void mag357_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(mag357);
        }

        private void mag44_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(mag44);
        }

        private void mag500_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(mag500);
        }

        private void mm556_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(mm556);
        }

        private void grendel_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(grendel);
        }

        private void mm762_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(mm762);
        }

        private void blackout_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(blackout);
        }

        private void winmag_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(winmag);
        }

        private void lapmag_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(lapmag);
        }

        private void bmg_Click(object sender, RoutedEventArgs e)
        {
            OnAmmoClick(bmg);
        }
    }
}
