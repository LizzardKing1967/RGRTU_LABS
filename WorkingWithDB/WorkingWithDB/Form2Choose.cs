using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkingWithDB
{
    public partial class Form2Choose : Form
    {
        private Form1 _form1;
        public Form2Choose(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void Form2Choose_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numb = 0;
            if(textBox1.Text != null && int.TryParse(textBox1.Text, out numb))
            {
                _form1.ShopSearch(textBox1.Text);
                Close();
            }
            else
            {
                label1.Text = "Введите корректное число";
            }

        }
    }
}
