using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form4 : Form
    {
        private string Cadena;
        private string Total;
        public Form4(string cadena, List<decimal>listaPrecios)
        {
            InitializeComponent();
        Cadena = cadena;
        label1.Text = cadena;
            decimal total = 0;
            foreach (var p in listaPrecios) {
                total += p;
            }
            Total = total.ToString();
            label2.Text = "Total: $" + total.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.LimpiaListas();
            MessageBox.Show("Gracias por su compra! :D");
            creaArchivo(Cadena);
            this.Close();
        }
        public void creaArchivo(string cadena) {
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()).ToString() + @"\Ordenes\Ordenes.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(cadena);
                    sw.WriteLine("Total: $" + Total);
                    sw.WriteLine("Fecha: " + DateTime.Now);
                    sw.WriteLine("--------------------------------------------");
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(cadena);
                    sw.WriteLine("Total: $" + Total);
                    sw.WriteLine("Fecha: " + DateTime.Now);
                    sw.WriteLine("--------------------------------------------");
                }
            }
        }
    }
}
