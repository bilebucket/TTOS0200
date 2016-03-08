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

namespace Demo09
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

        private void calculate(object sender, RoutedEventArgs e)
        {
            try
            {
                double il = Double.Parse(text_il.Text);
                double ik = Double.Parse(text_ik.Text);
                double kl = Double.Parse(text_kl.Text);

                text_ia.Text = "" + (il * ik) + " cm^2";
                text_la.Text = "" + ((il-kl*2) * (ik-kl*2))/10 + " cm^2";
                text_kp.Text = "" + (2*(il+ik)/10) + " cm";
            }
            catch (Exception) { }
            
        }

        private void textBlock_Copy_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock_Copy1_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
