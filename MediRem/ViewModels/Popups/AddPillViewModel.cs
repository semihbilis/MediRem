using MediRem.Models.Dto;
using MediRem.Views.Popups;
using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MediRem.ViewModels.Popups
{
    public class AddPillViewModel : BaseViewModel
    {
        private INavigation _navigation;
        private AddPillDto _addPillDto;
        //public List<string> pickerSiklikTipiSource = Enum.GetValues(typeof(SiklikTipi)).Cast<SiklikTipi>().Select(x => x.EnumToDisplayName()).ToList();
        private string[] pickerSource = new string[5] { "wqe", "asd", "zxc", "wer", "sfd" };
        //Picker çalışmıyor bakılacak.

        public AddPillViewModel(INavigation navigation, AddPillDto addPillDto = null)
        {
            _navigation = navigation;
            AddPillDto = addPillDto ?? new AddPillDto();
            if (!string.IsNullOrEmpty(addPillDto.Resim))
                if (!File.Exists(addPillDto.Resim))
                    addPillDto.Resim = null;
        }

        public AddPillDto AddPillDto
        {
            get => _addPillDto;
            set => SetProperty(ref _addPillDto, value);
        }
        public Command NumberChanger => new Command<string>((param) => SetCountValue(param));
        public Command ColorPicker => new Command(() => openColorPicker());
        public Command ChoosePicture => new Command(async () => await OpenChoosePickerAsync());
        public Command TakePicture => new Command(async () => await OpenCameraForPictureAsync());

        private async Task OpenCameraForPictureAsync()
        {
            FileResult result = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions()
            {
                Title = "İlaç resimini çekiniz..."
            });
            await LoadPhotoAsync(result);
        }

        private async Task LoadPhotoAsync(FileResult fileResult)
        {
            string[] resultTypes = fileResult.ContentType.Split('/');
            if (fileResult == null || !resultTypes[0].Equals("image"))
            {
                AddPillDto.Resim = null;
                return;
            }
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures, Environment.SpecialFolderOption.Create);
            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);

            string newFile = Path.Combine(filePath, fileResult.FileName);

            if (!File.Exists(newFile))
            {
                using (Stream stream = await fileResult.OpenReadAsync())
                {
                    using (FileStream newStream = File.OpenWrite(newFile))
                    {
                        await stream.CopyToAsync(newStream);
                    }
                }
            }
            AddPillDto.Resim = newFile;
        }

        private async Task OpenChoosePickerAsync()
        {
            FileResult result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions()
            {
                Title = "İlacın resmini seçiniz..."
            });
            await LoadPhotoAsync(result);
        }

        private async void openColorPicker()
        {
            string selectedColor = (string)await _navigation.ShowPopupAsync(new ColorPicker());
            if (!String.IsNullOrEmpty(selectedColor))
            {
                AddPillDto.Renk = selectedColor;
            }
        }

        private void SetCountValue(string param)
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