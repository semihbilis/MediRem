using MediRem.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MediRem.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}