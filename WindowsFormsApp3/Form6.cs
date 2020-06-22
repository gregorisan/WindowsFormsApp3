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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 10;
            newForm.radioButton1.Text = "Местное повышение температуры кожи\n над пораженным суставом";
            newForm.radioButton2.Text = "Боль в поясничной области различной интенсивности,\n распространяющаяся на ноги";
            newForm.radioButton3.Text = "Отек мягких тканей в области больного сустава";
            newForm.radioButton4.Text = "Ограничение подвижности тазобедренного сустава из-за боли";
            newForm.radioButton5.Text = "Боль в проекции тазобедренного сустава, отдающая в пах";
            newForm.radioButton6.Text = "Онемение стопы (гипестезия стопы)";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 11;
            newForm.radioButton1.Text = "Отек коленных, голеностопных суставов";
            newForm.radioButton2.Text = "Гнойные выделения на голени";
            newForm.radioButton3.Text = "Хруст в коленном суставе";
            newForm.radioButton4.Text = "Приступы интенсивных болей в суставах ног";
            newForm.radioButton5.Text = "Боль в коленном суставе при движении";
            newForm.radioButton6.Text = "Отек всего коленного сустава";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 12;
            newForm.radioButton1.Text = "Боль в ногах, усиливающаяся при ходьбе";
            newForm.radioButton2.Text = "Боль в подошве стопы";
            newForm.radioButton3.Text = "Похоладание, зябкость пальцев кисти";
            newForm.radioButton4.Text = "Жгучая боль в ноге";
            newForm.radioButton5.Text = "Боль в спине после физической нагрузки";
            newForm.radioButton6.Text = "Онемение стопы (гипестезия стопы)";
            this.Close();
        }
    }
}
