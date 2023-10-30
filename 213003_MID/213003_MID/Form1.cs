namespace _213003_MID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int sum = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum = 0;

            if(starter1.Checked == true)
            {
                sum += int.Parse(textBox1.Text) * 150;
            }

            if(starter2.Checked == true)
            {
                sum += int.Parse(textBox2.Text) * 250;
            }

            if (starter3.Checked == true)
            {
                sum += int.Parse(textBox3.Text) * 100;
            }

            if (starter4.Checked == true)
            {
                sum += int.Parse(textBox4.Text) * 250;
            }

            if (starter5.Checked == true)
            {
                sum += int.Parse(textBox5.Text) * 150;
            }

            if (main1.Checked == true)
            {
                sum += int.Parse(textBox10.Text) * 1500;
            }

            if (main2.Checked == true)
            {
                sum += int.Parse(textBox9.Text) * 2500;
            }

            if (main3.Checked == true)
            {
                sum += int.Parse(textBox8.Text) * 1000;
            }

            if (main4.Checked == true)
            {
                sum += int.Parse(textBox7.Text) * 2500;
            }

            if (main5.Checked == true)
            {
                sum += int.Parse(textBox10.Text) * 1500;
            }

            if (sweet1.Checked == true)
            {
                sum += int.Parse(sweet_t1.Text) * 150;
            }

            if (sweet2.Checked == true)
            {
                sum += int.Parse(sweet_t2.Text) * 250;
            }

            if (sweet3.Checked == true)
            {
                sum += int.Parse(sweet_t3.Text) * 100;
            }

            if (sweet4.Checked == true)
            {
                sum += int.Parse(sweet_t4.Text) * 250;
            }

            if (sweet5.Checked == true)
            {
                sum += int.Parse(sweet_t5.Text) * 150;
            }

            textBox16.Text = sum.ToString();
        }
    }
}