using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(textBox1.Text);
            var a = new bird[n * 2];
            for (int i = 0; i < a.Length; i = i + 2)
            {
                a[i] = new Leleka(i + 1);
                a[i + 1] = new Vorona(i + 2);
            }
            var maxV = 0.0;
            var maxL = 0.0; 
            listBox1.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                listBox1.Items.Add(a[i].Show());
                if (a[i].name == "Leleka")
                {
                    maxL += a[i].CountEat();
                }
                else
                {
                    maxV += a[i].CountEat();
                }
            }
            label2.Text = maxL.ToString();
            label3.Text = maxV.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
