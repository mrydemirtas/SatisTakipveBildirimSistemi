using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StaticSınıflarDevam.Models
{
    public enum Money
    {
        Euro,
        Dolar,
        Sterlin,
        Ruble
    }

    public static class ForexManager
    {
        
        public static decimal Exchange(double money,Money moneyCode)
        {
            XmlDocument xmlVerisi = new XmlDocument();
            xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            decimal result = 0;

            switch (moneyCode)
            {
                case Money.Euro:
                    result = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                    break;
                case Money.Dolar:
                    result = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                    break;
                case Money.Sterlin:
                    break;
                case Money.Ruble:
                    break;
                default:
                    break;
            }

            return result;

        }
    }
}
