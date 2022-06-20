using MediRem.ViewModels.Popups;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace MediRem.Views.Popups
{
    public partial class ColorPicker : Popup
    {
        private string _previousSelectedItem;

        public ColorPicker()
        {
            InitializeComponent();
            BindingContext = new ColorPickerModel();
        }

        private void lstColor_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.ItemIndex == -1)
                return;

            if (_previousSelectedItem == e.Item.ToString())
                Dismiss(_previousSelectedItem);

            _previousSelectedItem = (string)e.Item;
        }
    }
}