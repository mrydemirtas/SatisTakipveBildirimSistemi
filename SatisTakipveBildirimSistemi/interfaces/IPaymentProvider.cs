using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisTakipveBildirimSistemi.interfaces
{
    public interface IPaymentProvider
    {
        void Pay(decimal payment);
    }
}
