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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

          

            Form1 frm = new Form1("test");
            frm.Show();
            

            string a = Form1._counter.ToString();
            

            //lblForm2.Text = frm.lblForm1.Text;

            //MessageBox.Show(frm.counter.ToString());
        }
    }
}
