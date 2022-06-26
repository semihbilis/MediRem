using System;

namespace MediRem.Models.Entitys
{
    public class IlacKullanimi : BaseEntity
    {
        public DateTime KullanimSaati { get; set; }

        public Guid IlacId { get; set; }
        public Ilac Ilac { get; set; }
    }
}
