using StaticSınıflarDevam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticSınıflarDevam
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string test)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DistanceManager.FeetToMetre(5);
            // double a = DistanceManager.ConvertMileToKM(15);

            //decimal d =  ForexManager.Exchange(15, Money.Dolar);
            //decimal c =  ForexManager.Exchange(20, Money.Euro);

            MYBUTTON benimki = new MYBUTTON();
            this.Controls.Add(benimki);
        }

        public int counter = 5;
        public static int _counter = 10;

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            counter = 0;
            _counter++;
            Form2 frm = new Form2();
            frm.Show();
           

            Hide();
        }
    }
}
