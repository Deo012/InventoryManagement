using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        //Random for color
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gradientPanel1.BottomColor = Color.FromArgb(random.Next(180, 255), random.Next(180, 255), random.Next(180, 255));
            gradientPanel1.Invalidate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void customTextBox12__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour Monde");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                PasswordBox.PasswordChar = true;
            else
                PasswordBox.PasswordChar = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UsernameBox.Texts = "";
            PasswordBox.Texts = "";
        }
    }
}
