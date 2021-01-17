using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rastgele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(1, 7);
            int b = rastgele.Next(1, 7);
            label1.Text = a.ToString();
            label2.Text = b.ToString();
        }
    }
}
