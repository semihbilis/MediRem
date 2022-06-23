using MediRem.Models.Enums;

namespace MediRem.Models.Dto
{
    public class AddPillDto : BaseDtoEntity
    {
        private string _Ad;
        private string _Renk;
        private string _Resim;
        private int _KutuAdet;
        private int _PlakaAdet;
        private int _TaneAdet;
        private int _ToplamAdet;
        private SiklikTipi _SiklikTipi;
        private int? _XgundeBir;
        private string _GunlukKullanimSaatleri;
        private int _HerKullanimdaKacAdet;
        private AlimTavsiyesi _AlimTavsiyesi;

        public string Ad
        {
            get => _Ad;
            set => SetProperty(ref _Ad, value);
        }
        public string Renk
        {
            get => _Renk;
            set => SetProperty(ref _Renk, value);
        }
        public string Resim
        {
            get => _Resim;
            set => SetProperty(ref _Resim, value);
        }
        public int KutuAdet
        {
            get => _KutuAdet;
            set
            {
                SetProperty(ref _KutuAdet, value <= 0 ? 1 : value);
                ToplamAdet *= value;
            }
        }
        public int PlakaAdet
        {
            get => _PlakaAdet;
            set
            {
                SetProperty(ref _PlakaAdet, value <= 0 ? 1 : value);
                ToplamAdet *= value;
            }
        }
        public int TaneAdet
        {
            get => _TaneAdet;
            set
            {
                SetProperty(ref _TaneAdet, value <= 0 ? 1 : value);
                ToplamAdet *= value;
            }
        }
        public int ToplamAdet
        {
            get => _ToplamAdet;
            set => SetProperty(ref _ToplamAdet, _KutuAdet * _PlakaAdet * _TaneAdet);
        }

        public SiklikTipi SiklikTipi
        {
            get => _SiklikTipi;
            set => SetProperty(ref _SiklikTipi, value);
        }
        public int? XGundeBir
        {
            get => _XgundeBir;
            set => SetProperty(ref _XgundeBir, value);
        }
        public string GunlukKullanimSaatleri
        {
            get => _GunlukKullanimSaatleri;
            set => SetProperty(ref _GunlukKullanimSaatleri, value);
        }
        public int HerKullanimdaKacAdet
        {
            get => _HerKullanimdaKacAdet;
            set => SetProperty(ref _HerKullanimdaKacAdet, value);
        }
        public AlimTavsiyesi AlimTavsiyesi
        {
            get => _AlimTavsiyesi;
            set => SetProperty(ref _AlimTavsiyesi, value);
        }
    }
}
