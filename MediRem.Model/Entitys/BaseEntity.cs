using MediRem.Models.Interfaces;
using System;

namespace MediRem.Models.Entitys
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
    }
}