using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTehtava1
{
    public partial class Elokuvasovellus : Form
    {
        public Elokuvasovellus()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tietojaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Petri Nahkala!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vuosi = DateTime.Now.Year;
            string asd = vuosi.ToString();
            textBox1.Text = ("0");
            textBox1.ReadOnly = true;
            textBox2.Text = ("[Syötä elokuvan nimi]");
            textBox3.Text = (asd);
            textBox4.Text = ("0");
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
        private void textBox2leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "[Syötä elokuvan nimi]";
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
        private void textBox3leave(object sender, EventArgs e)
        {
            int vuosi = DateTime.Now.Year;
            string asd = vuosi.ToString();
            if (textBox3.Text == "")
            {
                textBox3.Text = asd;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
        private void textBox4leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int asd;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
            }
           else if (textBox2.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Täytä kaikki kentät");
            }
            else if (!int.TryParse(textBox1.Text, out asd  ))
            {
                MessageBox.Show("ID-kenttään kelpaa vain numerot");
            }
            else if (!int.TryParse(textBox3.Text, out asd))
            {
                MessageBox.Show("Julkaisuvuosi-kenttään kelpaa vain numerot");
            }
            else if (!int.TryParse(textBox4.Text, out asd))
            {
                MessageBox.Show("Kesto-kenttään kelpaa vain numerot");
            }
            else
            {
                MessageBox.Show("Tallennus onnistui!");
            }
        }
    }
}
