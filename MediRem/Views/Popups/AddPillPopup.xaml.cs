using MediRem.Models.Dto;
using MediRem.ViewModels.Popups;
using Xamarin.CommunityToolkit.UI.Views;

namespace MediRem.Views.Popups
{
    public partial class AddPillPopup : Popup
    {
        public AddPillPopup(AddPillDto addPillDto = null)
        {
            InitializeComponent();
            BindingContext = new AddPillViewModel(Navigation, addPillDto);
        }
    }
}