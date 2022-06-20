using MediRem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediRem.Models.Entitys
{
    public class KullanimTipi:BaseEntity
    {
        public SiklikTipi SiklikTipi { get; set; }
        public int? XGundeBir { get; set; }
        public int HerKullanimdaKacAdet { get; set; }
        public string GunlukKullanimSaati { get; set; }
        public AlimTavsiyesi AlimTavsiyesi { get; set; }

        public int IlacId { get; set; }
        public Ilac Ilac { get; set; }
    }
}
