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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 4;
            newForm.radioButton1.Text = "Боль в проекции тазобедренного сустава, отдающая в пах";
            newForm.radioButton2.Text = "Ноющие, постоянные боли во всех суставах (боль в суставах)";
            newForm.radioButton3.Text = "Простые тики: мигание, подергивание шеи, пожимание плечом";
            newForm.radioButton4.Text = "Отек лучезапястного сустава";
            newForm.radioButton5.Text = "Боль в коленном суставе при движении";
            newForm.radioButton6.Text = "Местное повышение температуры кожи над пораженным суставом";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 5;
            newForm.radioButton1.Text = "Боль в проекции тазобедренного сустава, отдающая в пах";
            newForm.radioButton2.Text = "Боль в области ахиллова сухожилия";
            newForm.radioButton3.Text = "Боль в области запястья";
            newForm.radioButton4.Text = "Онемение одной, двух или всех конечностей";
            newForm.radioButton5.Text = "Побледнение пальцев";
            newForm.radioButton6.Text = "Местное повышение температуры кожи над пораженным суставом";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Tag = 6;
            newForm.radioButton1.Text = "Боль в локтевом суставе при нагрузке";
            newForm.radioButton2.Text = "Покраснение кожи над пораженным суставом";
            newForm.radioButton3.Text = "Боль в локтевом суставе при сжатии кисти";
            newForm.radioButton4.Text = "Онемение одной, двух или всех конечностей";
            newForm.radioButton5.Text = "Побледнение пальцев";
            newForm.radioButton6.Text = "Местное повышение температуры кожи над пораженным суставом";
            this.Close();
        }
    }
}
