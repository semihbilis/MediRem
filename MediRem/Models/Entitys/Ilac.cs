using System;
using System.Collections.Generic;
using System.Text;

namespace MediRem.Models.Entitys
{
    public class Ilac:BaseEntity
    {
        public string Ad { get; set; }
        public string Renk { get; set; }
        public string Resim { get; set; }
        public short PaketSayisi { get; set; }
        public short PlakSayisi { get; set; }
        public short TaneSayisi { get; set; }

        public int KullanimTipiId { get; set; }
        public KullanimTipi KullanimTipi { get; set; }
    }
}
