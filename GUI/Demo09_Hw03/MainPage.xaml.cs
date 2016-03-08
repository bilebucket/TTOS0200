using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Demo09_Hw03
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Laske_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double ikkunaleveys = double.Parse(IkkunaLeveys.Text);
                double ikkunakorkeus = double.Parse(IkkunaKorkeus.Text);
                double karmileveys = double.Parse(KarmiLeveys.Text);

                LaskeIkkunaPintaAla.Text = "" + (ikkunaleveys * ikkunakorkeus) / 10 + " cm^2";
                LaskeLasiPintaAla.Text = "" + ((ikkunaleveys - karmileveys * 2) * (ikkunakorkeus - karmileveys * 2)) / 10 + " cm^2";
                LaskeKarmiPiiri.Text = "" + (2 * (ikkunaleveys + ikkunakorkeus) / 10) + " cm^2";
            }
            catch (Exception)
            {

            }
        }
    }
}
