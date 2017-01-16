using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoveCalculator
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string person1;
        string lover;
        int check;
        double d_sum1,d_sum2,ans;
        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(ToString.check);
            int sum1 = 0;
            int sum2 = 0;
            foreach ( char c in person1 )
            {
                sum1 += Char.ToUpper(c) - 'A' + 1;
            }
            foreach (char c in lover)
            {
                sum2 += Char.ToUpper(c) - 'A' + 1;
            }
            sum1 %= 9;
            sum2 %= 9;
            if (sum1 == 0) sum1 = 9;
            if (sum2 == 0) sum2 = 9;
            d_sum1 = Convert.ToDouble(sum1);
            d_sum2 = Convert.ToDouble(sum2);
            if ( sum1 <= sum2 )
            {
                ans = (d_sum1 / d_sum2) * 100.0;
            }
            else
            {
                ans = (d_sum2 / d_sum1) * 100.0;
            }
            MessageBox.Show(Convert.ToString(ans) + "%");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            person1 = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lover = textBox2.Text;
        }
        /*public void result()
        {
            int result = person1.Length+ lover.Length;
            check = result / 2;
            check.ToString(); 
        }*/

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
