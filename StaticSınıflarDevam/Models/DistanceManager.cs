using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSınıflarDevam.Models
{
    //const static sınıflarda kullanabilir.
    public static class DistanceManager
    {
        private const double _oneMile = 1.609344;
        private const double _feet = 0.3048;
        private const double _cm = 2.54;

        public static double ConvertMileToKM(double mile)
        {
            return _oneMile * mile;
        }

        public static double FeetToMetre(double metre)
        {
            return _feet * metre;
        }

        public static double ConvertKMToMile(double km)
        {
            return km / _oneMile;
        }

        public static double ConvertInchToSantiMetre(double inch)
        {
            return _cm * inch;
        }



    }
}
