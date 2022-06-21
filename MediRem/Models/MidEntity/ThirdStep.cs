using MediRem.Models.Enums;

namespace MediRem.Models.MidEntity
{
    public class ThirdStep
    {
        public ThirdStep(SecondStep secondStep)
        {
            Ad = secondStep.Ad;
            Renk=secondStep.Renk;
            Resim = secondStep.Resim;
            KutuAdet = secondStep.KutuAdet;
            PlakaAdet = secondStep.PlakaAdet;
            TaneAdet = secondStep.TaneAdet;

            SiklikTipi = secondStep.SiklikTipi;
            XGundeBir = secondStep.XGundeBir;
            GunlukKullanimSaatleri = secondStep.GunlukKullanimSaatleri;
        }
        public string Ad { get; set; }
        public string Renk { get; set; }
        public string Resim { get; set; }
        public short KutuAdet { get; set; }
        public short PlakaAdet { get; set; }
        public short TaneAdet { get; set; }

        public SiklikTipi SiklikTipi { get; set; }
        public short? XGundeBir { get; set; }
        public string GunlukKullanimSaatleri { get; set; }

        public short HerKullanimdaKacAdet { get; set; }
        public AlimTavsiyesi AlimTavsiyesi { get; set; }
    }
}