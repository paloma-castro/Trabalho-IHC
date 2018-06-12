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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jaulas atualizadas.");
            this.Close();
            Form4 Denovo = new Form4();
            Denovo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 novaform = new Form4();
            novaform.Show();
            novaform.textBox1.Text = label3.Text;
            novaform.textBox5.Text = label4.Text;
            novaform.textBox2.Text = label7.Text;
            novaform.textBox3.Text = label9.Text;
            novaform.textBox4.Text = label11.Text;
            novaform.label8.Text = label13.Text;
            this.Close();            
        }
    }
}
