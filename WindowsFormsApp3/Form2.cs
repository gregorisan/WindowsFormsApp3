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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 1;
            newForm.radioButton1.Text = "Выраженная головная боль, распространяющаяся на всю голову";
            newForm.radioButton2.Text = "Повышение артериального давления";
            newForm.radioButton3.Text = "Общая слабость";
            newForm.radioButton4.Text = "Слуховые галлюцинации";
            newForm.radioButton5.Text = "Опущение верхнего века";
            newForm.radioButton6.Text = "Повышенная раздражительность";
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 2;
            newForm.radioButton1.Text = "Повышение артериального давления";
            newForm.radioButton2.Text = "Головокружение";
            newForm.radioButton3.Text = "Шум в голове";
            newForm.radioButton4.Text = "Головная боль пульсирующего, давящего характера";
            newForm.radioButton5.Text = "Рвота разного характера, в том числе неукротимая";
            newForm.radioButton6.Text = "Нарушение координации движений";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 3;
            newForm.radioButton1.Text = "Повышение артериального давления";
            newForm.radioButton2.Text = "Головокружение";
            newForm.radioButton3.Text = "Шум в голове";
            newForm.radioButton4.Text = "Головная боль пульсирующего, давящего характера";
            newForm.radioButton5.Text = "Онемение одной половины тела";
            newForm.radioButton6.Text = "Онемение лица";
            this.Close();
        }
    }
}
