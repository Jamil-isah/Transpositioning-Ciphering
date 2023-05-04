using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
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

        private void button1_Click(object sender, EventArgs e)
        {
            string encryptedtext = "";
            string plaintext = textBox1.Text;
            char[] plainletters = plaintext.ToCharArray();

            int rows = (int)(plaintext.Length / 5);
            char[,] encryptedletters = new char [rows, 5];
            int c = 0;
            for (int i =0; i< rows; i ++)
            {
                for (int j = 0; j<5; j++)
                {
                    encryptedletters[i, j] = plainletters[c];
                    c++;
                }

            }
            for (int j =0; j<5; j++)
            {
                for (int i =0; i <rows; i++)
                {
                    encryptedtext += encryptedletters[i, j];
                }
                
            }
            textBox2.Text = encryptedtext;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string plaintext = " ";
            string encryptedtext = textBox2.Text;
            char[] encryptedletters = encryptedtext.ToCharArray();
            int rows = (int)(encryptedtext.Length / 5);
            char[,] plainletters = new char[rows, 5];
            int c = 0;
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    plainletters[i, j] = encryptedletters[c];
                    c++;
                }
            }
            for (int i =0; i < rows; i++)
            {
                for (int j =0; j < 5; j++)
                {
                    plaintext += plainletters [i , j];
                }
                textBox1.Text = plaintext;
            }
        }
    }
}
