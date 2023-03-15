using System.Windows.Markup;

namespace Lab2Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonEng_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
            textBox2.Text = null;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            double value;
            double val1 = 0.4;
            if (textBox1.Text != null & double.TryParse(textBox1.Text, out value))
            {
                if (radioButtonFunt.Checked)
                {
                    if (ButtonOther.Checked | radioButtonDeutch.Checked | ButtonOther.Checked | radioButtonDat.Checked | radioButtonIsl.Checked | radioButtonEng.Checked | radioButtonRus.Checked)
                    { 
                        if (radioButtonDeutch.Checked | radioButtonIsl.Checked  | radioButtonDat.Checked)
                        value = value / 0.5;
                    else if (radioButtonEng.Checked)
                        value = value / 0.4536;
                    else if (radioButtonRus.Checked)
                        value = value / 0.4095;
                    else if ((ButtonOther.Checked) & !(textBox3.Text == null) & (double.TryParse(textBox3.Text, out val1)))
                        value = value / val1;
                    }
                    else
                    {
                        textBox2.Text = "Пожалуйста, укажите страну";
                        return;
                    }
               
                    textBox2.Text = "Вес в фунтах: ";
                }
                else if (radioButtonKg.Checked)
                {
                    if (radioButtonDeutch.Checked | ButtonOther.Checked | radioButtonDat.Checked | radioButtonIsl.Checked  | radioButtonEng.Checked | radioButtonRus.Checked)
                    {
                        if (radioButtonDeutch.Checked | radioButtonDat.Checked  | radioButtonIsl.Checked)
                            value = value * 0.5;
                        else if (radioButtonEng.Checked)
                            value = value * 0.4536;
                        else if (radioButtonRus.Checked)
                            value = value * 0.4095;
                        else if ((ButtonOther.Checked) & !(textBox3.Text == null) & (double.TryParse(textBox3.Text, out val1)))
                            value = value * val1;
                    }
                    else
                        {
                            textBox2.Text = "Пожалуйста, укажите страну";
                            return;
                        }
                    
                    textBox2.Text = "Вес в кг: ";
                }
                else
                {
                    textBox2.Text = "Пожалуйста, укажите выводимую величину";
                    return;
                }
                textBox2.Text = textBox2.Text + value.ToString();
            }
            else textBox2.Text = "Введите корректное значение!";
        }

        private void radioButtonFunt_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonKg.Checked = false;
        }

        private void radioButtonKg_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFunt.Checked = false;
        }

        private void ButtonOther_CheckedChanged(object sender, EventArgs e)
        {
            if (ButtonOther.Checked)
                textBox3.Visible = true;
            else textBox3.Visible = false;  
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void действиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}