using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MediRem.Models.MidEntity
{
    public class FirstStep : BaseMidEntity
    {
        private string _Ad;
        private string _Renk;
        private string _Resim;
        private int _KutuAdet;
        private int _PlakaAdet;
        private int _TaneAdet;
        private int _ToplamAdet;
        public string Ad
        {
            get => _Ad;
            set => SetProperty(ref _Ad, value);
        }
        public string Renk
        {
            get => _Renk;
            set => SetProperty(ref _Renk, value);
        }
        public string Resim
        {
            get => _Resim;
            set => SetProperty(ref _Resim, value);
        }
        public int KutuAdet
        {
            get => _KutuAdet;
            set
            {
                SetProperty(ref _KutuAdet, value);
                ToplamAdet = KutuAdet * PlakaAdet * TaneAdet;
            }
        }
        public int PlakaAdet
        {
            get => _PlakaAdet;
            set
            {
                SetProperty(ref _PlakaAdet, value);
                ToplamAdet = KutuAdet * PlakaAdet * TaneAdet;
            }
        }
        public int TaneAdet
        {
            get => _TaneAdet;
            set
            {
                SetProperty(ref _TaneAdet, value);
                ToplamAdet = KutuAdet * PlakaAdet * TaneAdet;
            }
        }
        public int ToplamAdet
        {
            get => _ToplamAdet;
            set => SetProperty(ref _ToplamAdet, KutuAdet * PlakaAdet * TaneAdet);
        }
    }
}