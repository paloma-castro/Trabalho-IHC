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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados salvos com sucesso.");
            this.Close();
            Form3 Denovo = new Form3();
            Denovo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 novaform = new Form3();
            novaform.Show();
            novaform.maskedTextBox1.Text = label12.Text;
            novaform.maskedTextBox4.Text = label13.Text;
            novaform.textBox2.Text = label14.Text;
            novaform.richTextBox1.Text = richTextBox1.Text;
            novaform.dateTimePicker1.Text = label15.Text;
            novaform.maskedTextBox2.Text = label16.Text;
            novaform.maskedTextBox3.Text = label17.Text;
            novaform.textBox4.Text = label18.Text;
            novaform.textBox5.Text = label19.Text;
            novaform.richTextBox3.Text = richTextBox2.Text;
            novaform.dateTimePicker2.Text = label20.Text;
            this.Close();
        }
    }
}
