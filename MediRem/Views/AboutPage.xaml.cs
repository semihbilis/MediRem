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
            //FirstStep firstStep = new FirstStep()
            //{
            //    Ad = "TestAspirin",
            //    KutuAdet = 1,
            //    PlakaAdet = 3,
            //    TaneAdet = 5,
            //    Renk = "Purple",
            //    Resim = ""
            //};
            Navigation.ShowPopup(new IlacEkleFirstStepPopup());
        }
    }
}