using Common;
using StaticSınıflarDevam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace StaticSınıflarDevam
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public object XMLWriter { get; private set; }

        private void Form3_Load(object sender, EventArgs e)
        {

            string a = "adasdasd".Buyut();
            string b = "adasdasd".Buyut();

            CultureInfo language = new CultureInfo("fr-FR");

           string r1 = DateTime.Now.GetHumanizeDate(language);

           //string dd =  DateTimeExtention.GetHumanizeDate(DateTime.Now, language);
            
        }
    }
}
