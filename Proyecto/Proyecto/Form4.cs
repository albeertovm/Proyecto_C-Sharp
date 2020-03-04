using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form4 : Form
    {
        public Form4(string cadena, List<decimal>listaPrecios)
        {
            InitializeComponent();
            label1.Text = cadena;
            decimal total = 0;
            foreach (var p in listaPrecios) {
                total += p;
            }
            label2.Text = "Total: $" + total.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.LimpiaListas();
            MessageBox.Show("Gracias por su compra! :D");
            this.Close();

        }
    }
}
