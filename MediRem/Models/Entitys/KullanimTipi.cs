using MediRem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediRem.Models.Entitys
{
    public class KullanimTipi:BaseEntity
    {
        public SiklikTipi SiklikTipi { get; set; }
        public short SiklikTipiAraligi { get; set; } = 1;
        public string GunlukKullanimSaatleri { get; set; }
        public short HerKullanimdaKacAdet { get; set; } = 1;
        public AlimTavsiyesi AlimTavsiyesi { get; set; }

        public Guid IlacId { get; set; }
        public Ilac Ilac { get; set; }
    }
}
