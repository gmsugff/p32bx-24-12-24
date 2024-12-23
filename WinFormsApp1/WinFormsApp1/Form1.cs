using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Random rand_x = new Random();
        public Random rand_y = new Random();
        public string userFIO = string.Empty;
        public DateTime date = DateTime.Now;
        public int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ФИО: {userFIO}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"время сейчас:{DateTime.Now}");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"дата рождения:{date}");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            button3_Click(sender, e);
            button2_Click(sender, e);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userFIO = textBox1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int sum = 0;
            while (true)
            {
                sum++;
                if (sum < 1000)
                {
                    button6.Location = new Point(rand_x.Next(50, 500), rand_y.Next(50, 500));
                }
                else if (sum >= 1000)
                {
                    MessageBox.Show("End of the game");
                    break;

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you won");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            button7.Navigate();
            Process.Start(@"https://tenor.com/ru/view/rickroll-roll-rick-never-gonna-give-you-up-never-gonna-gif-22954713");
            
        }
    }
}