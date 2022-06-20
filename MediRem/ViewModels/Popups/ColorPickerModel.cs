using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace MediRem.ViewModels.Popups
{
    public class ColorPickerModel : BaseViewModel
    {
        private Stack<string> _colors;
        public Stack<string> Colors
        {
            get => _colors;
            set => SetProperty(ref _colors, value);
        }

        public ColorPickerModel()
        {
            Title = "Renk Seçiniz";
            Colors = getColors();
        }

        private Stack<string> getColors()
        {
            Stack<string> colors = new Stack<string>();
            foreach (PropertyInfo item in typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.Public))
                colors.Push(item.Name);
            return colors;
        }
    }
}