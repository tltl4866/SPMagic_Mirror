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
using FacialRecognitionDoor.Helpers;
using FacialRecognitionDoor.Objects;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FacialRecognitionDoor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        private string visitorName;

        public BlankPage1()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            visitorName = e.Parameter as string;
        }

        private void BlankPage1_Loaded(object sender, RoutedEventArgs e)
        {
            var welcometext = String.Format("Welcome, {0}!", visitorName);
            Greetings.Text = welcometext;
        }
    }
}
