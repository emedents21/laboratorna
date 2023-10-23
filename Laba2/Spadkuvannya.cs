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
    public partial class Spadkuvannya : Form
    {
        public Spadkuvannya()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void синToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Text = Convert.ToString(синToolStripMenuItem);

        }

        private void бiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Text = Convert.ToString(бiToolStripMenuItem);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vidrizok = new Vidrizok(
                textBox1.Text,
                Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox2.Text));

            var колірЛінії = toolStripMenuItem1.Text;
            var n = Convert.ToDouble(textBox4.Text);

            var linie = new Line(
                textBox1.Text,  // Передаємо назву
                Convert.ToInt32(textBox3.Text), // Передаємо початкову координату
                Convert.ToInt32(textBox2.Text), // Передаємо кінцеву координату
                колірЛінії, // Передаємо колір
                n // Передаємо n
            );

            label6.Text = vidrizok.Lenght().ToString();
            label8.Text = linie.addLenght(n).ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void червонийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Text = Convert.ToString(червонийToolStripMenuItem);

        }

        private void зеленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Text = Convert.ToString(зеленийToolStripMenuItem);

        }

        private void чорнийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Text = Convert.ToString(чорнийToolStripMenuItem);

        }
    }
}
