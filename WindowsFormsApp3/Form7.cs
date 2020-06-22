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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 13;
            newForm.radioButton1.Text = "Кровь в моче (гематурия)";
            newForm.radioButton2.Text = "Боль в тазобедренном суставе при движении";
            newForm.radioButton3.Text = "Ограничение подвижности тазобедренного\n сустава из-за боли";
            newForm.radioButton4.Text = "Скованность мышц бедра";
            newForm.radioButton5.Text = "Ноющие, постоянные боли во всех суставах";
            newForm.radioButton6.Text = "Сильная боль в поясничной области";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 14;
            newForm.radioButton1.Text = "Боль разной интенсивности в шейном,\n грудном или поясничном отделах позвоночника";
            newForm.radioButton2.Text = "Онемение нижней части тела";
            newForm.radioButton3.Text = "Приступообразные боли в поясничной области";
            newForm.radioButton4.Text = "Учащенное мочеиспускание";
            newForm.radioButton5.Text = "Боль в спине после физической нагрузки";
            newForm.radioButton6.Text = "Боль в поясничной области справа или слева";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 15;
            newForm.radioButton1.Text = "Гнойное отделяемое из области копчика,\n заднего прохода";
            newForm.radioButton2.Text = "Приступообразные боли в поясничной области";
            newForm.radioButton3.Text = "Учащенное мочеиспускание";
            newForm.radioButton4.Text = "Онемение наружной поверхности бедра";
            newForm.radioButton5.Text = "Боль разной интенсивности в\n поясничном отделах позвоночника";
            newForm.radioButton6.Text = "Отек в области копчика";
            this.Close();
        }
    }
}
