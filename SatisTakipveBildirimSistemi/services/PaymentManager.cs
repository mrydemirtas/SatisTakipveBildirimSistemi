using SatisTakipveBildirimSistemi.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisTakipveBildirimSistemi.services
{
    public class PaymentManager
    {
        IPaymentProvider _provider;

        public PaymentManager(IPaymentProvider provider)
        {
            _provider = provider;
        }

        public void Pay(decimal money)
        {
            _provider.Pay(money);
        }
    }
}
