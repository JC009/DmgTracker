using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
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

        public SolidColorBrush brush;

        public List<Button> buttons;

        public List<List<int>> stats;

        public List<TextBlock> blocks;

        public List<TextBlock> blocks2;

        public int ammoType;

        public MainWindow()
        {
            InitializeComponent();

            buttons = new List<Button>() {
                mm9Button, acp45Button, mm10Button, ae50Button,
                mag357Button, mag44Button, mag500Button,
                mm556Button, grendelButton, mm762Button, blackoutButton,
                winmagButton, lapmagButton, bmgButton,
                leadButton, steelButton, slugButton, dragonButton, birdshotButton};

            blocks = new List<TextBlock>() {
                prcShort, prcMedium, prcLong,
                apShort, apMedium, apLong,
                dmgShort, dmgMedium, dmgLong};

            blocks2 = new List<TextBlock>() {
                prcShort2, prcMedium2, prcLong2,
                apShort2, apMedium2, apLong2,
                dmgShort2, dmgMedium2, dmgLong2,
                numShort2, numMedium2, numLong2 };
        

            stats = new List<List<int>>() {
                MM9.stats, ACP45.stats, MM10.stats, AE50.stats,
                MAG357.stats, MAG44.stats, MAG500.stats,
                MM556.stats, GRENDEL.stats, MM762.stats, BLACKOUT.stats,
                WINMAG.stats, LAPMAG.stats, BMG.stats,
                GAUGE12LEAD.stats, GAUGE12STEEL.stats, GAUGE12SLUG.stats, GAUGE12DRAGON.stats, GAUGE12BIRDSHOT.stats};

            brush = new SolidColorBrush(Color.FromRgb(221, 221, 221));

            CheckShort.IsChecked = true;

            ButtonAutomationPeer peer =  new ButtonAutomationPeer(mm9Button);

            ButtonAutomationPeer peer2 = new ButtonAutomationPeer(leadButton);

            IInvokeProvider invokeProv = peer.GetPattern(PatternInterface.Invoke) as IInvokeProvider;

            IInvokeProvider invokeProv2 = peer2.GetPattern(PatternInterface.Invoke) as IInvokeProvider;

            invokeProv2.Invoke();

            invokeProv.Invoke();
        }

        private void CheckShort_Checked(object sender, RoutedEventArgs e)
        {
            CheckMedium.IsChecked = false;
            CheckLong.IsChecked = false;
            CalculateHit();
            CalculateDamage();
        }

        private void CheckMedium_Checked(object sender, RoutedEventArgs e)
        {
            CheckShort.IsChecked = false;
            CheckLong.IsChecked = false;
            CalculateHit();
            CalculateDamage();
        }

        private void CheckLong_Checked(object sender, RoutedEventArgs e)
        {
            CheckShort.IsChecked = false;
            CheckMedium.IsChecked = false;
            CalculateHit();
            CalculateDamage();
        }

        private void CheckShort2_Checked(object sender, RoutedEventArgs e)
        {
            CheckMedium2.IsChecked = false;
            CheckLong2.IsChecked = false;
            CalculateHit();
            CalculateDamage();
        }

        private void CheckMedium2_Checked(object sender, RoutedEventArgs e)
        {
            CheckShort2.IsChecked = false;
            CheckLong2.IsChecked = false;
            CalculateHit();
            CalculateDamage();
        }

        private void CheckLong2_Checked(object sender, RoutedEventArgs e)
        {
            CheckShort2.IsChecked = false;
            CheckMedium2.IsChecked = false;
            CalculateHit();
            CalculateDamage();
        }

        private void OnAmmoClick(object sender, RoutedEventArgs e)
        {
            Button button = mm9Button;

            if (sender == mm9Button)
            {
                ammoType = 0;
                button = mm9Button;
            } else if (sender == acp45Button)
            {
                ammoType = 1;
                button = acp45Button;
            } else if (sender == mm10Button)
            {
                ammoType = 2;
                button = mm10Button;
            } else if (sender == ae50Button)
            {
                ammoType = 3;
                button = ae50Button;
            } else if (sender == mag357Button)
            {
                ammoType = 4;
                button = mag357Button;
            } else if (sender == mag44Button)
            {
                ammoType = 5;
                button = mag44Button;
            } else if (sender == mag500Button)
            {
                ammoType = 6;
                button = mag500Button;
            } else if (sender == mm556Button)
            {
                ammoType = 7;
                button = mm556Button;
            } else if (sender == grendelButton)
            {
                ammoType = 8;
                button = grendelButton;
            } else if (sender == mm762Button)
            {
                ammoType = 9;
                button = mm762Button;
            } else if (sender == blackoutButton)
            {
                ammoType = 10;
                button = blackoutButton;
            } else if (sender == winmagButton)
            {
                ammoType = 11;
                button = winmagButton;
            } else if (sender == lapmagButton)
            {
                ammoType = 12;
                button = lapmagButton;
            } else if (sender == bmgButton)
            {
                ammoType = 13;
                button = bmgButton;
            } else if (sender == leadButton)
            {
                ammoType = 14;
                button = leadButton;
            } else if (sender == steelButton)
            {
                ammoType = 15;
                button = steelButton;
            } else if (sender == slugButton)
            {
                ammoType = 16;
                button = slugButton;
            } else if (sender == dragonButton)
            {
                ammoType = 17;
                button = dragonButton;
            } else if (sender == birdshotButton)
            {
                ammoType = 18;
                button = birdshotButton;
            }

            foreach (Button tempButton in buttons)
            {
                tempButton.Background = brush;
            }

            button.Background = Brushes.Gray;

            ammo = button;

            if (ammoType <= 13)
                for (int i = 0; i < blocks.Count; i++)
                {
                    blocks[i].Text = stats[ammoType][i].ToString();
                }

            if (ammoType > 13)
                for (int i = 0; i < blocks2.Count; i++)
                {
                    blocks2[i].Text = stats[ammoType][i].ToString();
                }

            CalculateHit();
            CalculateDamage();
        }

        private void EnemyArmorCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CalculateHit();
            CalculateDamage();
        }

        private void RoundsOnTargetCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CalculateDamage();
        }

        private void CalculateHit()
        {
            if (CheckShort.IsChecked == true)
            {
                ShotsHit.Content = ChanceToHit(3);

            }
            else if (CheckMedium.IsChecked == true)
            {
                ShotsHit.Content = ChanceToHit(4);
            }
            else if (CheckLong.IsChecked == true)
            {
                ShotsHit.Content = ChanceToHit(5);
            }
        }

        private string ChanceToHit(int range)
        {
            int shot = stats[ammoType][range];
            int armor = Int32.Parse(EnemyArmorCombo.Text);

            int result = armor - shot;

            if (result <= 1)
                return "All";

            if (result > 6)
                return "None";

            return result.ToString();
        }

        private void CalculateDamage()
        {
            if (CheckShort.IsChecked == true)
            {
                Damage.Content = RawDamage(6);

            }
            else if (CheckMedium.IsChecked == true)
            {
                Damage.Content = RawDamage(7);
            }
            else if (CheckLong.IsChecked == true)
            {
                Damage.Content = RawDamage(8);
            }
        }

        private double RawDamage(int singleShotDamage)
        {
            double singleDamage = stats[ammoType][singleShotDamage];
            double rateOfFire = Double.Parse(RoundsOnTargetCombo.Text);
            string shotsHit = ShotsHit.Content.ToString();

            if (shotsHit == "None")
                return 0;

            if (shotsHit == "All")
                return singleDamage * rateOfFire;

            return Math.Round(((singleDamage * rateOfFire) / Double.Parse(shotsHit)), 2);
        }

    }
}
