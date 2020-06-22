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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 7;
            newForm.radioButton1.Text = "Постоянная или периодическая одышка без связи\n с положением тела, нагрузками";
            newForm.radioButton2.Text = "Кашель с выделением мокроты зеленого, ржавого,\n серого или светло-желтого цвета";
            newForm.radioButton3.Text = "Сухой грубый «лающий» кашель";
            newForm.radioButton4.Text = "Приступ удушья";
            newForm.radioButton5.Text = "Ощущение инородного тела в горле";
            newForm.radioButton6.Text = "Резкая боль в грудной клетке, даже в покое";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 8;
            newForm.radioButton1.Text = "Частый жидкий стул (понос, диарея)";
            newForm.radioButton2.Text = "Тянущие, давящие боли по всему животу";
            newForm.radioButton3.Text = "Опухолевидное выпячивание на брюшной стенке";
            newForm.radioButton4.Text = "Боль в левой половине живота";
            newForm.radioButton5.Text = "Общее повышение температуры тела \n(высокая температура, повышенная температура)";
            newForm.radioButton6.Text = "Увеличение размеров живота на фоне снижения массы тела";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 9;
            newForm.radioButton1.Text = "Нарушение ритма работы сердца различного характера\n (аритмия) (нарушение сердечного ритма, перебои в сердце)";
            newForm.radioButton2.Text = "Усиление боли в верхней части живота после приема\n жирной пищи, алкоголя";
            newForm.radioButton3.Text = "Пузырьковые высыпания вдоль ребер";
            newForm.radioButton4.Text = "Интенсивная боль в подложечной области,\n иррадиирующая в левое подреберье";
            newForm.radioButton5.Text = "Боль в груди при дыхании и кашле (боли в грудной клетке)";
            newForm.radioButton6.Text = "Отечность всего тела (отек тела)";
            this.Close();
        }
    }
}
