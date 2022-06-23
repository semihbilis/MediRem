using MediRem.Models.Dto;
using MediRem.ViewModels.Popups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MediRem.Views.Popups
{
    public partial class AddPillPopup : Popup
    {
        public AddPillPopup(AddPillDto addPillDto=null)
        {
            InitializeComponent();
            BindingContext = new AddPillViewModel(Navigation, addPillDto);
        }
    }
}