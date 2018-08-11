using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Top_Football_Clubs.Resources;
using GoogleAds;
using System.Diagnostics;

namespace Top_Football_Clubs
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void OnAdReceived(object sender, GoogleAds.AdEventArgs e)
        {
            Debug.WriteLine("Received ad successfully");
        }

        private void OnFailedToReceiveAd(object sender, GoogleAds.AdErrorEventArgs errorCode)
        {
            Debug.WriteLine("Failed to receive ad with error " + errorCode.ErrorCode);
        }



        private void Chelsea_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=0", UriKind.Relative));
        }

        private void Manchester_City_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=1", UriKind.Relative));
        }

        private void Arsenal_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=2", UriKind.Relative));
        }

        private void Manchester_United_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=3", UriKind.Relative));
        }

        private void Liverpool_FC_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=4", UriKind.Relative));
        }

        private void FC_Barcelona_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=5", UriKind.Relative));
        }

        private void Real_Madrid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=6", UriKind.Relative));
        }

        private void Athletico_Madrid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=7", UriKind.Relative));
        }

        private void Valencia_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=8", UriKind.Relative));
        }

        private void Sevilla_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=9", UriKind.Relative));
        }

        private void Bayern_Munich_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=10", UriKind.Relative));
        }

        private void Wolfsburg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=11", UriKind.Relative));
        }

        private void Borrusia_Monchengladbach_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=12", UriKind.Relative));
        }

        private void Bayer_Leverkusen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=13", UriKind.Relative));
        }

        private void FC_Augsburg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=14", UriKind.Relative));
        }

        private void Juventus_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=15", UriKind.Relative));
        }

        private void Roma_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=16", UriKind.Relative));
        }

        private void Lazio_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=17", UriKind.Relative));
        }

        private void Fiorentina_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=18", UriKind.Relative));
        }

        private void Napoli_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=19", UriKind.Relative));
        }

        private void PSG_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=20", UriKind.Relative));
        }

        private void Lyon_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=21", UriKind.Relative));
        }

        private void Monaco_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=22", UriKind.Relative));
        }

        private void Marseille_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=23", UriKind.Relative));
        }

        private void Saint_Etienne_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailsPage.xaml?msg=24", UriKind.Relative));
        }

        
    }
}