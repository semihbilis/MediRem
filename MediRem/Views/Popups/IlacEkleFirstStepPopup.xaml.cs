using MediRem.Models.MidEntity;
using MediRem.ViewModels.Popups;
using System;
using Xamarin.CommunityToolkit.UI.Views;

namespace MediRem.Views.Popups
{
    public partial class IlacEkleFirstStepPopup : Popup
    {

        public IlacEkleFirstStepPopup(FirstStep firstStep = null)
        {
            InitializeComponent();
            BindingContext = new IlacEkleFirstStepViewModel(Navigation, firstStep);
        }

        private void btnPopupClose_Clicked(object sender, EventArgs e)
        {
            Dismiss("");
        }
    }
}