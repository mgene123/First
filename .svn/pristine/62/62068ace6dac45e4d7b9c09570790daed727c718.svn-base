using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOp.AddOperationSoapClient client = new AddOp.AddOperationSoapClient();
           float res= client.Add((float)Convert.ToDouble(textBox1.Text), (float)Convert.ToDouble(textBox2.Text));
            textBox3.Text = Convert.ToString( res);
        }
    }
}
