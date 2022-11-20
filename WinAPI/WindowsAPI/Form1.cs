using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConverterLib;

namespace WindowsAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Converter converter = new Converter();

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            listBox3.Items.AddRange(converter.GetPhysicValuesList().ToArray());
            listBox3.SelectedIndex = 0;
            string str = listBox3.SelectedItem.ToString();
            listBox1.Items.AddRange(converter.GetMeassureList(str).ToArray());
            listBox2.Items.AddRange(converter.GetMeassureList(str).ToArray());
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


            string str = listBox3.SelectedItem.ToString();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.AddRange(converter.GetMeassureList(str).ToArray());
            listBox2.Items.AddRange(converter.GetMeassureList(str).ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(textBox1.Text);
            string physicValue = listBox3.SelectedItem.ToString();
            string from = listBox1.SelectedItem.ToString();
            string to = listBox2.SelectedItem.ToString();
            textBox2.Text = converter.GetConvertedValue(physicValue, value, from, to).ToString();
        }
    }
}
