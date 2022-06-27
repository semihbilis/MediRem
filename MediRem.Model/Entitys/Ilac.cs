using System;

namespace MediRem.Models.Entitys
{
    public class Ilac : BaseEntity
    {
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string Renk { get; set; }
        public string Resim { get; set; }
        public short Adet { get; set; }

        public Guid KullanimTipiId { get; set; }
        public KullanimTipi KullanimTipi { get; set; }
    }
}
