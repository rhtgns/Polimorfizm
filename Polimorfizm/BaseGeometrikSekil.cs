using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public class BaseGeometrikSekil
    {

        // Genişlik ve Yükseklik propertyleri tanımlıyoruz
        public double Width { get; set; }
        public double Height { get; set; }

        // Sanal (virtual) AlanHesapla  burda alanı hesaplayan method tanımlıyoruz
        public virtual double CalculateField()
        {
            return Width * Height;
        }


        public class Square : BaseGeometrikSekil
        {

            public override double CalculateField()
            {
                return Width * Height;
            }

        }
        public class Dikdortgen : BaseGeometrikSekil
        {
            // Alan hesaplama, BaseGeometrikSekil'deki aynı yontemi kullandık
            public override double CalculateField()
            {
                return base.CalculateField();
            }
        }

        public class Dikucgen : BaseGeometrikSekil
        {

            public override double CalculateField()
            {
                return (Width * Height) / 2;
            }
        }

    }
}