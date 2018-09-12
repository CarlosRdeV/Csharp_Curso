using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String password = textBox2.Text;
            int intento = 0;
            label3.Text = "Tu nombre es "+nombre+" y tu password es "+password;
            label3.Show();

            if (nombre == "carlos" && password == "14050500")
            {
                Form4 fr4 = new Form4();
                Close();
                fr4.Show();
                

                



                
            }
            else {
                MessageBox.Show("Datos incorrectos");
                intento++;
                if (intento > 3)
                {
                    MessageBox.Show("Error max");
                    Close();

                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            

        }
    }
}
