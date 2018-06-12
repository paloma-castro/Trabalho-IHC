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
    public partial class Form5 : Form
    {
        
        
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados salvos com sucesso.");
            this.Close();
            Form2 Denovo = new Form2();
            Denovo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 novaform = new Form2();
            novaform.Show();
            novaform.txtbCadNomeAnim.Text = label6.Text;
            novaform.txtbCadRacaAnim.Text = label7.Text;
            novaform.comboBox1.Text = label8.Text;
            novaform.comboBox2.Text = label15.Text;
            novaform.dateTimePicker1.Text = label4.Text;
            novaform.comboBox3.Text = label17.Text;
            novaform.dateTimePicker2.Text = label20.Text;
            novaform.dateTimePicker3.Text = label21.Text;
            novaform.dateTimePicker4.Text = label22.Text;
            this.Close();
        }
    }
}
