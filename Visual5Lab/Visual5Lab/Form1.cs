namespace Visual5Lab
{
    public partial class Form1 : Form
    {
        Image[] images = new Image[130];
        private int frames = 0;
        private int timerCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ”величиваем счетчик кадров
            // увеличиваем счетчик на 1 при каждом тике таймера
            timerCounter++;
            int hours = timerCounter / 3600;
            int minutes = (timerCounter % 3600) / 60;
            int seconds = timerCounter % 60;
            label1.Text = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
            label1.Tag = timerCounter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();    
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            // создаем массив дл€ хранени€ изображений
            for (int i = 0; i < 130; i++)
            {
                string filename = string.Format(@"A:\visual\Visual5Lab\Visual5Lab\Frames\{0}.jpg", i);
                images[i] = Image.FromFile(filename); // загружаем изображение
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // —брасываем счетчик и останавливаем таймер
   
            timer1.Stop();
            timer2.Stop();
            // —брасываем текст на Label
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // увеличиваем счетчик на 1 при каждом тике таймера
            frames++;
            if (frames > 129)
            {
                frames = 0;
                timer2.Interval = 200;
            }
            else if (frames > 88)
            {
                timer2.Interval = 50;
            }
            pictureBox1.Image = images[frames];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            frames = 0;
            timerCounter = 0;
            label1.Text = "00:00:00";
            pictureBox1.Image = images[frames];

        }
    }
}