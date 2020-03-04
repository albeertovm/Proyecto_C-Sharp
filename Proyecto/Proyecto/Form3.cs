using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Proyecto
{
    public partial class Form3 : Form
    {
        public Form3(string id_productos)
        {
            InitializeComponent();
            RealizaConsulta(id_productos);
        }
        
        public void RealizaConsulta(string id_productos){
            IEnumerable<string> respuesta;
            var xd = Directory.GetCurrentDirectory() + "\\bdemperatriz.db";
            string cs = @"URI=file:" + xd;
            using (IDbConnection conexion = new SQLiteConnection(cs))
            {
                respuesta = conexion.Query<String>("SELECT nombre FROM Productos WHERE id in"+id_productos+";", new DynamicParameters());
            }
            foreach (var elemento in respuesta) {
                comboBox1.Items.Add(elemento);
            }
            comboBox1.SelectedIndex = 0;
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            IEnumerable<string> respuesta;
            string elementoSeleccionado = comboBox1.GetItemText(comboBox1.SelectedItem);
            var xd = Directory.GetCurrentDirectory() + "\\bdemperatriz.db";
            string cs = @"URI=file:" + xd;
            using (IDbConnection conexion = new SQLiteConnection(cs))
            {
                respuesta = conexion.Query<String>("SELECT precio FROM Productos WHERE nombre LIKE '" + elementoSeleccionado + "';", new DynamicParameters());
            }
            foreach (var elemento in respuesta)
            {
                label2.Text = "Precio: $";
                label1.Text = elemento;
                pictureBox1.Image = Image.FromFile(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()).ToString() + @"\Images\" + elementoSeleccionado.ToString().Trim() + ".jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal cantidad = numericUpDown1.Value;
            decimal precio = Convert.ToDecimal(label1.Text) * cantidad;
            string elementoSeleccionado = comboBox1.GetItemText(comboBox1.SelectedItem).ToString();
            MessageBox.Show("Se han agregado: " + cantidad + " unidades de " + elementoSeleccionado);
            Form1.modificaLista(precio, elementoSeleccionado, cantidad);
            numericUpDown1.Value = 1;
        }

        public static void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
