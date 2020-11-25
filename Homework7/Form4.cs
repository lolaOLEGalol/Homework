using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form4 : Form
    {
        private Random rnd = new Random();
        private int _answer;
        private string _text;
        public Form4()
        {
            InitializeComponent();
            _answer = rnd.Next(1, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _text = textBox1.Text;
            int temp = 0;

            temp = int.Parse(_text);

            if (temp < _answer)
            {
                label1.Text = "Загаданное число больше :)";
            }
            else if (temp > _answer)
            {
                label1.Text = "Загаданное число меньше :)";
            }
            else
            {
                label1.Text = "Ты угадал, красава!";
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
