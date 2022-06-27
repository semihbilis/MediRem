using MediRem.Models.CustomAttributes;

namespace MediRem.Models.Enums
{
    public enum SiklikTipi
    {
        [CAEnumToString("Günlük")]
        Gunluk = 0,
        [CAEnumToString("Haftalık")]
        Haftalik = 1,
        [CAEnumToString("Aylık")]
        Aylik = 2,
    }
}