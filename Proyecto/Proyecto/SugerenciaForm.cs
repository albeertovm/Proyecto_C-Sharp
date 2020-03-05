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
    public partial class SugerenciaForm : Form
    {
        public SugerenciaForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xd = Directory.GetCurrentDirectory() + "\\sugerencias.txt";
            try
            {
                string contenido = File.ReadAllText(xd, Encoding.UTF8);
                var cadena = contenido + "Comentario - Fecha: " + DateTime.Now + "\n" + textBox1.Text + "\n" + comboBox1.SelectedItem + "\n";
                File.WriteAllText(xd, cadena);
            }
            catch (FileNotFoundException fe)
            {
                var cadena = "Comentario - Fecha: " + DateTime.Now + "\n" + textBox1.Text + "\n" + comboBox1.SelectedItem + "\n";
                File.WriteAllText(xd, cadena);
            }
            this.Close();
        }
    }
}
