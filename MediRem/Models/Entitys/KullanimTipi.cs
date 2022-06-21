using MediRem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediRem.Models.Entitys
{
    public class KullanimTipi:BaseEntity
    {
        public SiklikTipi SiklikTipi { get; set; }
        public short? XGundeBir { get; set; }
        public string GunlukKullanimSaatleri { get; set; }
        public short HerKullanimdaKacAdet { get; set; }
        public AlimTavsiyesi AlimTavsiyesi { get; set; }

        public Guid IlacId { get; set; }
        public Ilac Ilac { get; set; }
    }
}
