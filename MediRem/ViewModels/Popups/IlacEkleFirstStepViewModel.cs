using MediRem.Models.MidEntity;
using MediRem.Views.Popups;
using System;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MediRem.ViewModels.Popups
{
    public class IlacEkleFirstStepViewModel : BaseViewModel
    {
        public IlacEkleFirstStepViewModel(INavigation navigation, FirstStep firstStep = null)
        {
            FirstStep = firstStep == null ? new FirstStep() : firstStep;
            _navigation = navigation;
        }
        private INavigation _navigation;

        private FirstStep _firstStep;
        public FirstStep FirstStep
        {
            get => _firstStep;
            set => SetProperty(ref _firstStep, value);
        }

        public ICommand NumberChanger => new Command<string>((param) => helperCommandProcess(param));
        public ICommand ColorPicker => new Command(() => openColorPicker());
        public ICommand ChoosePicture => new Command(() => openChoosePicture());




        private async void openChoosePicture()
        {
            FileResult result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions()
            {
                Title = "İlacın resmini seçiniz"
            });
            string[] resultTypes = result.ContentType.Split('/');
            if (result != null && resultTypes[0].Equals("image"))
            {
                FirstStep.Resim = result.FullPath;
            }
        }

        private async void openColorPicker()
        {
            string selectedColor = (string)await _navigation.ShowPopupAsync(new ColorPicker());
            if (!String.IsNullOrEmpty(selectedColor))
            {
                FirstStep.Renk = selectedColor;
            }
        }


        private void helperCommandProcess(string param)
        {
            string[] parameters = param.Trim().Split(',');
            if (!int.TryParse(parameters[2], out int uselessParameter))
                return;
            setCountValue(parameters[0], parameters[1], int.Parse(parameters[2]));
        }

        private void setCountValue(string variable, string process, int amount = 1)
        {
            int proc = process.ToLower() == "up" ? 2 : process.ToLower() == "down" ? 1 : 0;
            switch (variable.ToLower())
            {
                case "kutuadet":
                    int countK = FirstStep.KutuAdet;
                    FirstStep.KutuAdet = proc == 2 ? countK += amount : proc == 1 ? countK -= amount : 0;
                    if (FirstStep.KutuAdet <= 0)
                        FirstStep.KutuAdet = 1;
                    break;
                case "plakaadet":
                    int countP = FirstStep.PlakaAdet;
                    FirstStep.PlakaAdet = proc == 2 ? countP += amount : proc == 1 ? countP -= amount : 0;
                    if (FirstStep.PlakaAdet <= 0)
                        FirstStep.PlakaAdet = 1;
                    break;
                case "taneadet":
                    int countT = FirstStep.TaneAdet;
                    FirstStep.TaneAdet = proc == 2 ? countT += amount : proc == 1 ? countT -= amount : 0;
                    if (FirstStep.TaneAdet <= 0)
                        FirstStep.TaneAdet = 1;
                    break;
                default:
                    break;
            }
        }
    }
}