using MediRem.Models.MidEntity;
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
        private FirstStep _FirstStep;
        public IlacEkle1()
        {
            FirstStep firstStep = new FirstStep()
            {
                Ad = "",
                Renk = "Black",
                KutuAdet = 0,
                PlakaAdet = 0,
                TaneAdet = 0,
                Resim = ""
            };
            InitializeComponent();
            BindingContext = firstStep;
            changerLblToplamAdet();
        }
        public IlacEkle1(FirstStep firstStep)
        {
            InitializeComponent();
            _FirstStep = firstStep;
            BindingContext = _FirstStep;
            if (!String.IsNullOrEmpty(_FirstStep.Resim))
                frameBorderPickedImage.IsVisible = true;

            changerLblToplamAdet();
        }

        private async void imgbtnRenkSec_Clicked(object sender, EventArgs e)
        {
            string selectedColor = (string)await Navigation.ShowPopupAsync(new ColorPicker());
            if (!String.IsNullOrEmpty(selectedColor))
            {
                Color color = (Color)System.Drawing.Color.FromName(selectedColor);
                ImageButton imageButton = (ImageButton)sender;
                imageButton.BorderColor = color;
                boxvHap.BackgroundColor = color;
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
                frameBorderPickedImage.Background = imgbtnRenkSec.BorderColor;
                frameBorderPickedImage.IsVisible = true;
            }
        }

        private void imgbtnResimCek_Clicked(object sender, EventArgs e)
        {

        }

        private void changerLblToplamAdet()
        {
            if (!int.TryParse(lblKutuAdet.Text, out int rKutuAdet) ||
                !int.TryParse(lblPlakaAdet.Text, out int rPlakaAdet) ||
                !int.TryParse(lblTaneAdet.Text, out int rTaneAdet))
                return;
            int sKutu = int.Parse(lblKutuAdet.Text);
            int sPlaka = int.Parse(lblPlakaAdet.Text);
            int sTane = int.Parse(lblTaneAdet.Text);
            int sToplam = sKutu * sPlaka * sTane;
            lblToplamAdet.Text = sToplam.ToString();
        }

        private void changerLblNumber(object sender, string process)
        {
            Label label = (Label)sender;
            if (!int.TryParse(label.Text, out int result))
                label.Text = "0";

            int count = int.Parse(label.Text);
            if (process == "Up")
                count++;
            else if (process == "Down")
                count--;
            else
                return;

            if (count <= 0)
                count = 1;

            label.Text = count.ToString();
            changerLblToplamAdet();
        }

        private void btnAzaltKutuAdet_Clicked(object sender, EventArgs e)
        {
            changerLblNumber(lblKutuAdet, "Down");
        }

        private void btnArtırKutuAdet_Clicked(object sender, EventArgs e)
        {
            changerLblNumber(lblKutuAdet, "Up");
        }

        private void btnAzaltPlakaAdet_Clicked(object sender, EventArgs e)
        {
            changerLblNumber(lblPlakaAdet, "Down");
        }

        private void btnArtırPlakaAdet_Clicked(object sender, EventArgs e)
        {
            changerLblNumber(lblPlakaAdet, "Up");
        }

        private void btnAzaltTaneAdet_Clicked(object sender, EventArgs e)
        {
            changerLblNumber(lblTaneAdet, "Down");
        }

        private void btnArtırTaneAdet_Clicked(object sender, EventArgs e)
        {
            changerLblNumber(lblTaneAdet, "Up");
        }

        private void btnPopupClose_Clicked(object sender, EventArgs e)
        {
            Dismiss("");
        }
    }
}