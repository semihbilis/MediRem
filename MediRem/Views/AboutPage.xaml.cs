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
                Resim = "/data/user/0/com.companyname.medirem/files/Pictures/pill.jpeg",
                SiklikTipi = Models.Enums.SiklikTipi.Gunluk,
                SiklikTipiAraligi = 2,
                GunlukKullanimSaatleri = "08:00,20:00",
                HerKullanimdaKacAdet = 3,
                AlimTavsiyesi = Models.Enums.AlimTavsiyesi.YemektenOnce
            };
            Navigation.ShowPopup(new AddPillPopup(addPillDto));
            AddPillDto addPillDto1 = new AddPillDto()
            {
                Ad = "TestAspirin1",
                Aciklama = "TestAciklamaTestAs\npirin TestAspirin",
                KutuAdet = 3,
                PlakaAdet = 5,
                TaneAdet = 7,
                Renk = "Blue",
                Resim = "/data/user/0/com.companyname.medirem/files/Pictures/3df6b2ef425346f0974990b9b30c3ba0.jpg",
                SiklikTipi = Models.Enums.SiklikTipi.Haftalik,
                SiklikTipiAraligi = 1,
                GunlukKullanimSaatleri = "09:00,21:00",
                HerKullanimdaKacAdet = 5,
                AlimTavsiyesi = Models.Enums.AlimTavsiyesi.YemektenSonra
            };
        }
    }
}