using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSınıflarDevam.Models
{
    public static class ExtentionManager
    {
        public static string Buyut(this string text)
        {
            return text.ToUpper();
        }
    }
}
