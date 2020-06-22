using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Indecs : Form
    {
        public Indecs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m;
            double h;
            if (!double.TryParse(textBox1.Text, out m) && !double.TryParse(textBox1.Text, out h)) ;

            else
            {
                m = Convert.ToDouble(textBox1.Text);
                h = Convert.ToDouble(textBox2.Text);
              
                
                if (m / (h * h) > 100);
                MessageBox.Show("Ожирение");
                if (m / (h * h) < 100) ;
                MessageBox.Show("Пизда");






            }
        }
    }
}