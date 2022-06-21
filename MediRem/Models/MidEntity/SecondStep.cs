using MediRem.Models.Enums;

namespace MediRem.Models.MidEntity
{
    public class SecondStep
    {
        public SecondStep(FirstStep firstStep)
        {
            Ad = firstStep.Ad;
            Renk = firstStep.Renk;
            Resim = firstStep.Resim;
            KutuAdet = firstStep.KutuAdet;
            PlakaAdet = firstStep.PlakaAdet;
            TaneAdet = firstStep.TaneAdet;
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
    }
}