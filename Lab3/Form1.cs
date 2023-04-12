using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        //Form InformationForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void действияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.AppendText("Введите значение расстояния в метрах и значение времени в секундах через Enter..." + "\r\n");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "Введите значение расстояния в метрах и значение времени в секундах через Enter...";
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
        bool b = false;
        private void button1_Click(object sender, EventArgs e)
        {
            double Distance,Time;
            textBox1.AppendText("\r\n");
            if (textBox1.Lines[1].ToString() == "" || textBox1.Lines[2].ToString() == "")
            {
                MessageBox.Show("Введите значение!");
            }
            else
            {
                Distance = Convert.ToDouble(textBox1.Lines[1]);
                Time = Convert.ToDouble(textBox1.Lines[2]);
                if (radioButton1.Checked)
                {
                    double result = Distance/Time;
                    textBox1.AppendText("Скорость ветра:" + result + " м/сек");
                }
                else
                {
                    double result = (Distance / 1000) / (Time * 3600);
                    textBox1.AppendText("Скорость ветра:" + result + " км/час");
                }
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
