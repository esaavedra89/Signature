/*
 Se descargó nuget Xam.Plugin.Media v 2.3.0 en la solucion

 */
using SignaturePad.Forms;
using System;
using System.IO;
using Xamarin.Forms;

namespace Signature
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {

            Stream image = await PadView.GetImageStreamAsync(SignatureImageFormat.Png);
            
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            PadView.Clear();
        }
    }
}
