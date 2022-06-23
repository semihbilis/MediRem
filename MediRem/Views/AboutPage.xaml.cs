using MediRem.Models.Dto;
using MediRem.Models.MidEntity;
using MediRem.Views.Popups;
using System;
using System.ComponentModel;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
                KutuAdet = 1,
                PlakaAdet = 3,
                TaneAdet = 5,
                Renk = "Purple",
                Resim = "/storage/emulated/0/Android/data/com.companyname.medirem/cache/2203693cc04e0be7f4f024d5f9499e13/a5a559c5a84b4b1abd2420136a63f3b1/pill.jpeg"
            };
            Navigation.ShowPopup(new AddPillPopup(addPillDto));
        }
    }
}