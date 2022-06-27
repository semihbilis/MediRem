using MediRem.Helpers;
using System.Collections.Generic;

namespace MediRem.ViewModels.Popups
{
    public class ColorPickerViewModel : BaseViewModel
    {
        public ColorPickerViewModel()
        {
            Title = "Renk Seçiniz";
            Colors = HColor.ToStack();
        }

        private Stack<string> _colors;
        public Stack<string> Colors
        {
            get => _colors;
            set => SetProperty(ref _colors, value);
        }
    }
}