using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace opertor_overloaded_app
{
    class Kasiyer
    {
        int _satis_adet;
        string _calisan_adi;

        public Kasiyer(string calisan_adi, int satis_adet)
        {
            _calisan_adi = calisan_adi;
            _satis_adet = satis_adet;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} Adet Satış", _calisan_adi, _satis_adet);
        }


        public static Kasiyer operator +(Kasiyer Kasiyer1, Kasiyer Kasiyer2)
        {
            int toplam_Satis = Kasiyer1._satis_adet + Kasiyer2._satis_adet;
            return new Kasiyer("Toplam", toplam_Satis);
        }

        public static Kasiyer operator -(Kasiyer Kasiyer1, Kasiyer Kasiyer2)
        {
            int toplam_Satis = Kasiyer1._satis_adet - Kasiyer2._satis_adet;
            return new Kasiyer("Toplam", toplam_Satis);
        }
        public static Kasiyer operator *(Kasiyer Kasiyer1, Kasiyer Kasiyer2)
        {
            int toplam_Satis = Kasiyer1._satis_adet - Kasiyer2._satis_adet;
            return new Kasiyer("Toplam", toplam_Satis);
        }
        public static Kasiyer operator /(Kasiyer Kasiyer1, Kasiyer Kasiyer2)
        {
            int toplam_Satis = Kasiyer1._satis_adet - Kasiyer2._satis_adet;
            return new Kasiyer("Toplam", toplam_Satis);
        }
    }
}
