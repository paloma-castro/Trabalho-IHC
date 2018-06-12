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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox2.GetItemText(comboBox2.SelectedItem);
            if (selected == "Sim")
            {

                dateTimePicker1.Enabled = false;
                
            }else
                dateTimePicker1.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox3.GetItemText(comboBox3.SelectedItem);
            if (selected == "Sim")
            {

                dateTimePicker2.Enabled = false;
                dateTimePicker3.Enabled = false;

            }
            else
            {
                dateTimePicker2.Enabled = true;
                dateTimePicker3.Enabled = true;
            }
                
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
            dateTimePicker2.MinDate = DateTime.Now;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.MinDate = dateTimePicker2.Value;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 novaform = new Form1();
            novaform.Show();
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            bool valid=false;
            if (txtbCadNomeAnim.Text != "")
            {
                valid = true;
                
            }
            if(txtbCadRacaAnim.Text != "")
            {
                
                
            }else valid = false;
            if(comboBox1.GetItemText(comboBox1.SelectedItem) != "")
            {
                
                
            }else valid = false;
            if (comboBox2.GetItemText(comboBox2.SelectedItem) != "")
            {
                          
            }else valid = false;
            if (comboBox3.GetItemText(comboBox3.SelectedItem) != "")
            {
                if (valid == false) { }
                
            }else valid = false;
            if(valid == true)
            {
                Form5 novaform = new Form5();
                novaform.Show();               
                novaform.label6.Text = txtbCadNomeAnim.Text;
                novaform.label7.Text = txtbCadRacaAnim.Text;
                novaform.label8.Text = comboBox1.Text;
                novaform.label15.Text = comboBox2.Text;
                novaform.label4.Text = dateTimePicker1.Text;
                novaform.label17.Text = comboBox3.Text;
                novaform.label20.Text = dateTimePicker2.Text;
                novaform.label21.Text = dateTimePicker3.Text;
                novaform.label22.Text = dateTimePicker4.Text;
                this.Close();
            }
            else
                MessageBox.Show("Animal não pode ser cadastrado, preencha todas as informações!");
            
        }

    }
}
