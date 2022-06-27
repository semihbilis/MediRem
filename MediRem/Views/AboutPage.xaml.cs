using MediRem.Models.Dto;
using MediRem.Views.Popups;
using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace MediRem.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void btnIlacEkle_Clicked(object sender, EventArgs e)
        {
            AddPillDto addPillDto = new AddPillDto()
            {
                Ad = "TestAspirin",
                Aciklama = "TestAciklamaTestAs\npirin TestAspirin TestAs\npirin Fggtyifdtjgh Fgjre\ngjyfghvhjj Nkfdtuggh",
                KutuAdet = 1,
                PlakaAdet = 3,
                TaneAdet = 5,
                Renk = "Purple",
                Resim = "/storage/emulated/0/Android/data/com.companyname.medirem/cache/2203693cc04e0be7f4f024d5f9499e13/a5a559c5a84b4b1abd2420136a63f3b1/pill.jpeg",
                SiklikTipi = Models.Enums.SiklikTipi.Gunluk,
                SiklikTipiAraligi = 2,
                GunlukKullanimSaatleri = "08:00,20:00",
                HerKullanimdaKacAdet = 3,
                AlimTavsiyesi = Models.Enums.AlimTavsiyesi.YemektenOnce
            };
            Navigation.ShowPopup(new AddPillPopup(addPillDto));
        }
    }
}