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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            if(maskedTextBox1.Text != "")
            {
                valid = true;
            }
            if(maskedTextBox1.Text != "")
            {

            }else valid = false;
            if(textBox2.Text != "")
            {

            }else valid = false;
            if(richTextBox1.Text != "")
            {

            }else valid = false;
           
            if (textBox5.Text != "")
            {

            }else valid = false;
            if (richTextBox3.Text != "")
            {

            }else valid = false;
            if (valid == true)
            {
                Form6 novaform = new Form6();
                novaform.Show();
                novaform.label12.Text = maskedTextBox1.Text;
                novaform.label13.Text = maskedTextBox4.Text;
                novaform.label14.Text = textBox2.Text;
                novaform.richTextBox1.Text = richTextBox1.Text;
                novaform.label15.Text = dateTimePicker1.Text;
                novaform.label16.Text = maskedTextBox2.Text;
                novaform.label17.Text = maskedTextBox3.Text;
                novaform.label18.Text = textBox4.Text;
                novaform.label19.Text = textBox5.Text;
                novaform.richTextBox2.Text = richTextBox3.Text;
                novaform.label20.Text = dateTimePicker2.Text;
                this.Close();
            }
            else
                MessageBox.Show("Adoção não pode ser cadastrada, preencha todas as informações!");


        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
