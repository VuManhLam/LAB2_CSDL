using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Demo : Form
    {
        private object cboMaHV;
        private object lblTienTHA;

        public Demo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (checkBox1.Checked)
                s += int.Parse(label6.Text.Split('.')[0]);
            if (checkBox2.Checked)
                s += int.Parse(label7.Text.Split('.')[0]);
            if (checkBox3.Checked)
                s += int.Parse(label8.Text.Split('.')[0]);
            if (checkBox4.Checked)
                s += int.Parse(label9.Text.Split('.')[0]);
            this.textBox2.Text = s + ".000 đồng";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ReSet();
        }
        private void ReSet()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.dateTimePicker1.Value = DateTime.Now;
            this.radioButton1.Checked = true;
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.button1.Text = "";
        }    

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
