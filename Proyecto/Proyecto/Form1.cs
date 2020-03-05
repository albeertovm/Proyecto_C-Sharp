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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cartaToolStripMenuItem.Enabled = false;
            DeshabilitarItem(nosotrosToolStripMenuItem);
        }

        public static List<decimal> listaPrecios = new List<decimal>();
        public static List<decimal> listaCantidad = new List<decimal>();
        public static List<string> listaUnidad = new List<string>();

        public static void modificaLista(decimal precio, string producto, decimal cantidad) {
            listaUnidad.Add(producto);
            listaPrecios.Add(precio);
            listaCantidad.Add(cantidad);
        }
        public static void LimpiaListas()
        {
            listaPrecios.Clear();
            listaUnidad.Clear();
        }
        public void ConsultaLista(List<decimal> listaPrecios, List<string> listaUnidad, List<decimal> listaCantidad) {
            string cadena = "";
            for (int contador = 0; contador < listaUnidad.Count; contador++)
            {
                cadena += ("Unidad: " + listaUnidad[contador] + " Precio: $" + (listaPrecios[contador]/listaCantidad[contador]) + " Cantidad: " + listaCantidad[contador] + " Total: $" + listaPrecios[contador] + "\n");
            }
            Form4 f4 = new Form4(cadena, listaPrecios);
            f4.ShowDialog();
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            checaOrden();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Visible = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void ubicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeshabilitarInicio();
            HabilitarItem(ordenToolStripMenuItem);
            unCheck(entradasToolStripMenuItem1);
            HabilitarItem(créditosToolStripMenuItem1);
            unCheck(entradasToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
            checaOrden();
        }

        private void cartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.Visible = true;
            cartaToolStripMenuItem.Enabled = false;
            HabilitarItem(ordenToolStripMenuItem);
            unCheck(entradasToolStripMenuItem1);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
            checaOrden();
        }

        internal static void modificaLista(decimal precio, string elementoSeleccionado, List<decimal> listaPrecios, object listaProducto)
        {
            throw new NotImplementedException();
        }

        internal static void modificaLista(decimal precio, string elementoSeleccionado, object listaPrecios, object listaProducto)
        {
            throw new NotImplementedException();
        }

        private void ordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordenToolStripMenuItem.Enabled = false;
            DeshabilitarInicio();
            unCheck(entradasToolStripMenuItem1);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            DeshabilitarCreditos();
            pictureBox4.Visible = true;
            label3.Visible = true;
            checaOrden();
        }

        private void nosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeshabilitarInicio();
            HabilitarItem(ordenToolStripMenuItem);
            unCheck(entradasToolStripMenuItem1);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
            ConsultaLista(listaPrecios, listaUnidad, listaCantidad);
            checaOrden();

        }

        private void créditosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeshabilitarInicio();
            HabilitarItem(ordenToolStripMenuItem);
            HabilitarItem(sugerenciasToolStripMenuItem);
            unCheck(entradasToolStripMenuItem1);
            DeshabilitarItem(créditosToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            pictureBox3.Visible = true;
            label2.Visible = true;
            DeshabilitarNosotros();
            checaOrden();
        }

        private void entradasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeshabilitarInicio();
            HabilitarItem(ordenToolStripMenuItem);
            Check(entradasToolStripMenuItem1);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
            Form3 f3 = new Form3("(1,2,3,4)");
            f3.ShowDialog();
            checaOrden();

        }

        private void platillosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeshabilitarInicio();
            HabilitarItem(ordenToolStripMenuItem);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            Check(platillosToolStripMenuItem1);
            unCheck(entradasToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
            Form3 f3 = new Form3("(5,6,7,8,9)");
            f3.ShowDialog();
            checaOrden();
        }

        public void postresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeshabilitarInicio();
            HabilitarItem(ordenToolStripMenuItem);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            Check(postresToolStripMenuItem1);
            unCheck(entradasToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
            Form3 f3 = new Form3("(10,11,12)");
            f3.ShowDialog();
            checaOrden();
        }

        private void bebidasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeshabilitarInicio();
            HabilitarItem(ordenToolStripMenuItem);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            Check(bebidasToolStripMenuItem1);
            unCheck(entradasToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
            Form3 f3 = new Form3("(13,14,15,16)");
            f3.ShowDialog();
            checaOrden();
        }

        private void DeshabilitarNosotros()
        {
            pictureBox4.Visible = false;
            label3.Visible = false;
        }

        private void DeshabilitarCreditos()
        {
            pictureBox3.Visible = false;
            label2.Visible = false;
        }

        private void DeshabilitarInicio() {
            pictureBox1.Visible = false;
            label1.Visible = false;
            HabilitarItem(cartaToolStripMenuItem);
        }

        private void HabilitarItem(ToolStripMenuItem  opcion) {
            opcion.Enabled = true;
        }

        public void DeshabilitarItem(ToolStripMenuItem opcion)
        {
            opcion.Enabled = false;
        }

        private void unCheck(ToolStripMenuItem casilla) {
            casilla.Checked = false;
        }
        private void Check(ToolStripMenuItem casilla)
        {
            casilla.Checked = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static void cambiarImagenCarta()
        {
            
        }
        public void checaOrden()
        {
            if (listaUnidad.Count != 0)
            {
                HabilitarItem(nosotrosToolStripMenuItem);
            }
            else
            {
                DeshabilitarItem(nosotrosToolStripMenuItem);
            }
        }
    }
}
