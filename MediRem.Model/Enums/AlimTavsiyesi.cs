using MediRem.Models.CustomAttributes;

namespace MediRem.Models.Enums
{
    public enum AlimTavsiyesi
    {
        [CAEnumToString("Yok")]
        Yok = 0,
        [CAEnumToString("Yemekten Önce")]
        YemektenOnce = 1,
        [CAEnumToString("Yemekten Sonra")]
        YemektenSonra = 2
    }
}