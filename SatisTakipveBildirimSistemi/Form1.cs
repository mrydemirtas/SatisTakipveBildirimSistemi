using SatisTakipveBildirimSistemi.interfaces;
using SatisTakipveBildirimSistemi.models;
using SatisTakipveBildirimSistemi.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisTakipveBildirimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.AccountNumber = "8754545";
            c.Name = "Ali";
            c.SurName = "Can";

            Customer c1 = new Customer();
            c1.AccountNumber = "8754545";
            c1.Name = "Ali";
            c1.SurName = "Can";

            listBox1.Items.Add(c);
            listBox1.Items.Add(c1);

            IPaymentProvider paymentProvider = new EFTPayment();

            PaymentManager pmanager = new PaymentManager(paymentProvider);

            List<IMessageProvider> mproviders = new List<IMessageProvider>();

            mproviders.Add(new SMSMessage());
            mproviders.Add(new NotificationMessage());
            mproviders.Add(new MailMessage());

            MessageManager mmanager = new MessageManager(mproviders);

            SalesManager sales = new SalesManager(c);
            sales.PaymentManager = pmanager;
            sales.MessageManager = mmanager;
            sales.Sale(789);
        }
    }
}
