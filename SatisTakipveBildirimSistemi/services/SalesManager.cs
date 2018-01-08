using SatisTakipveBildirimSistemi.interfaces;
using SatisTakipveBildirimSistemi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisTakipveBildirimSistemi.services
{
    public class SalesManager
    {
        Customer _customer;
        private decimal _price;


        public SalesManager(Customer customer)
        {
            _customer = customer;
        }

        public PaymentManager PaymentManager { get; set; }
        public MessageManager MessageManager { get; set; }


        public void Sale(decimal price)
        {
            PaymentManager.Pay(price);
            MessageManager.SendMessage("İşlem Başarılı");
        }


    }
}
