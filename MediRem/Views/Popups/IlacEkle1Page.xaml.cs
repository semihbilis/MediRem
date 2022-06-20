using System;
using System.IO;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MediRem.Views.Popups
{
    public partial class IlacEkle1 : Popup
    {
        public IlacEkle1()
        {
            InitializeComponent();
        }

        private async void imgbtnRenkSec_Clicked(object sender, EventArgs e)
        {
            string selectedColor = (string)await Navigation.ShowPopupAsync(new ColorPicker());
            if (!String.IsNullOrEmpty(selectedColor))
            {
                Color color = (Color)System.Drawing.Color.FromName(selectedColor);
                ImageButton imageButton = (ImageButton)sender;
                imageButton.BorderColor = color;
                if (imgPickedImage.Source != null)
                    frameBorderPickedImage.Background = color;
            }
        }

        private async void imgbtnResimSec_Clicked(object sender, EventArgs e)
        {
            FileResult result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions()
            {
                Title = "İlacın resmini seçiniz"
            });
            if (result != null)
            {
                Stream stream = await result.OpenReadAsync();
                ImageSource source = ImageSource.FromStream(() => stream);
                imgPickedImage.Source = source;
                //imgbtnRenkSec.Source = source;
                frameBorderPickedImage.Background = imgbtnRenkSec.BorderColor;
            }
        }

        private void imgbtnResimCek_Clicked(object sender, EventArgs e)
        {

        }
    }
}