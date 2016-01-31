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
using Windows.Media.SpeechSynthesis;
using Windows.Media;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace knowplay
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class mainpage : Page
    {



        SpeechSynthesizer synth;
        MediaElement media;


        public mainpage()
        {
            this.InitializeComponent();
            synth = new SpeechSynthesizer();
            media = new MediaElement();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(navp1));
        }

        private async void textBlock2_Loaded(object sender, RoutedEventArgs e)
        {
            SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(textBlock2.Text.ToString());
            media.SetSource(stream, stream.ContentType);
            media.Play();
        }
    }
}
