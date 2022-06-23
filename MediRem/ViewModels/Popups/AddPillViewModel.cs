using MediRem.Models.Dto;
using MediRem.Views.Popups;
using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MediRem.ViewModels.Popups
{
    public class AddPillViewModel : BaseViewModel
    {
        private INavigation _navigation;
        public AddPillDto _addPillDto;

        public AddPillViewModel(INavigation navigation, AddPillDto addPillDto = null)
        {
            _navigation = navigation;
            AddPillDto = addPillDto ?? new AddPillDto();
        }

        public AddPillDto AddPillDto
        {
            get => _addPillDto;
            set => SetProperty(ref _addPillDto, value);
        }
        public Command NumberChanger => new Command<string>((param) => setCountValue(param));
        public Command ColorPicker => new Command(() => openColorPicker());
        public Command ChoosePicture => new Command(() => openChoosePicker());

        private async void openChoosePicker()
        {
            FileResult result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions()
            {
                Title = "İlacın resmini seçiniz"
            });
            string[] resultTypes = result.ContentType.Split('/');
            if (resultTypes[0].Equals("image"))
            {
                AddPillDto.Resim = result.FullPath;
            }
        }

        private async void openColorPicker()
        {
            string selectedColor = (string)await _navigation.ShowPopupAsync(new ColorPicker());
            if (!String.IsNullOrEmpty(selectedColor))
            {
                AddPillDto.Renk = selectedColor;
            }
        }

        private void setCountValue(string param)
        {
            string[] pars = param.Trim().Split(',');
            string proc = pars[1].ToLower();

            int amount = 1;
            if (!String.IsNullOrEmpty(pars[2]))
            {
                if (int.TryParse(pars[2], out int uselessResult))
                    amount = int.Parse(pars[2]);
            }
            switch (pars[0].ToLower())
            {
                case "kutuadet":
                    int countK = AddPillDto.KutuAdet; //Arkaplanda aynı değere ulaşmak için her seferinde değişkenin get metoduna gidip geliyor.
                    AddPillDto.KutuAdet = proc == "up" ? countK += amount : proc == "down" ? countK -= amount : 1;
                    break;
                case "plakaadet":
                    int countP = AddPillDto.PlakaAdet;
                    AddPillDto.PlakaAdet = proc == "up" ? countP += amount : proc == "down" ? countP -= amount : 1;
                    break;
                case "taneadet":
                    int countT = AddPillDto.TaneAdet;
                    AddPillDto.TaneAdet = proc == "up" ? countT += amount : proc == "down" ? countT -= amount : 1;
                    break;
                default:
                    break;
            }
        }
    }
}