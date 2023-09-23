using System.Windows.Forms.VisualStyles;

namespace lockscreen_pad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.txt1.Text == "5")
            {
                this.txt2.Text = "WELCOME LUCIFER";
                this.txt2.BackColor = Color.Green;
            }
            else
            {
                this.txt2.Text = "INCORRECT CODE";
                this.txt2.BackColor = Color.Red;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "0";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.txt1.Clear();
            this.txt2.Clear();
            this.txt2.BackColor = Color.White;
        }
    }
}