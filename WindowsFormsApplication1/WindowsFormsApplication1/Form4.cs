using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
            label8.Text = DateTime.Now.ToShortDateString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 novaform = new Form1();
            novaform.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = false;
            if (textBox1.Text != "")
            {
                valid = true;

            }
            if (textBox2.Text != "")
            {


            }
            else valid = false;
            if (textBox3.Text != "")
            {

            }else valid = false;

            if (textBox4.Text != "")
            {

            }
            else valid = false;
            if (textBox4.Text != "")
            {

            }
            else valid = false;
            if (valid == true)
            {
                Form7 novaform = new Form7();
                novaform.Show();
                novaform.label3.Text = textBox1.Text;
                novaform.label4.Text = textBox5.Text;
                novaform.label7.Text = textBox2.Text;
                novaform.label9.Text = textBox3.Text;
                novaform.label11.Text = textBox4.Text;
                novaform.label13.Text = label8.Text;
                this.Close();
            }
            else
                MessageBox.Show("Jaulas não atualizadas, preencha todas as informações!");
        }
        
        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
