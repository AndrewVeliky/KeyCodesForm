using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyCodesForm
{
    public partial class Form1 : Form
    {
        
    
        

        public Form1()
        {
            InitializeComponent();
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
     

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

           

        }

        private void button_click1(object sender, EventArgs e)
        {
            if(textBox1.Text.Length==1)
            {
                char k = Convert.ToChar(textBox1.Text);
                int i = Convert.ToInt32(k);
                textBox2.Text = Convert.ToString(i);
            }
            else if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Введите символ!");
            }
            else
            {
                MessageBox.Show("Введите только один символ!");
            }
            

        }
    }
}
