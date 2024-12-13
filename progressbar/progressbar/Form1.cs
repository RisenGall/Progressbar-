namespace progressbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize = Convert.ToInt32(textBox1.Text);
            int final = Convert.ToInt32(textBox2.Text);
            double sonuc;

            sonuc = (final * 60 / 100) + (vize * 40 / 100);

            label3.Text = sonuc.ToString();
            progressBar1.Style = ProgressBarStyle.Blocks;



            if (sonuc >= 0 && sonuc <= 10)
            {

                progressBar1.Value = 10;

            }
            if (sonuc > 10 && sonuc <= 20)
            {
                progressBar1.Value = 20;
            }
            if (sonuc > 20 && sonuc <= 30)
            {
                progressBar1.Value = 30;
            }
            if (sonuc > 30 && sonuc <= 40)
            {
                progressBar1.Value = 40;
            }
            if (sonuc > 40 && sonuc <= 50)
            {
                progressBar1.Value = 50;
            }
            if (sonuc > 50 && sonuc <= 60)
            {
                progressBar1.Value = 60;
            }
            if (sonuc > 60 && sonuc <= 70)
            {
                progressBar1.Value = 70;
            }
            if (sonuc > 70 && sonuc <= 80)
            {
                progressBar1.Value = 80;
            }
            if (sonuc > 80 && sonuc <= 90)
            {
                progressBar1.Value = 90;
            }
            if (sonuc > 90 && sonuc <= 100)
            {
                progressBar1.Value = 100;
            }
            if (sonuc > 0 && sonuc <= 49)
            {
                progressBar1.ForeColor = Color.Red;
            }
            if (sonuc > 49 && sonuc <= 74)
            {
                progressBar1.ForeColor = Color.Yellow;
            }
            if (sonuc > 74 && sonuc <= 100)
            {
                progressBar1.ForeColor = Color.Green;
            }
        }

    }
}