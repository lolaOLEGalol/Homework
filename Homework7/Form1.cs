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
    public partial class Form1 : Form
    {
        private int _k;
        public int countClick;
        private int _lastNumber;
        private int _Rnd;
        private Random rnd = new Random();

        public void Check()
        {
            if (_k == _Rnd)
            {
                Form3 finish = new Form3();
                finish.Show(this);
                this.Hide();
            }
        }
        public Form1()
        {
            InitializeComponent();
            _k = 1;
            _Rnd = rnd.Next(2, 50);
            LBL.Text = Convert.ToString(1);
            LBL3.Text = Convert.ToString(_Rnd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _lastNumber = _k;
            _k++;
            countClick++;
            

            LBL.Text = Convert.ToString(_k);
            LBL2.Text = Convert.ToString(countClick);

            Check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _lastNumber = _k;
            _k *= 2;
            countClick++;

            LBL.Text = Convert.ToString(_k);
            LBL2.Text = Convert.ToString(countClick);

            Check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _k = 1;
            countClick++;

            LBL.Text = Convert.ToString(_k);
            LBL2.Text = Convert.ToString(countClick);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _k = _lastNumber;
            countClick++;
            LBL.Text = Convert.ToString(_k);
            LBL2.Text = Convert.ToString(countClick);
        }
    }
}
