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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            List<String> lista = new List<String>();
            lista = SqliteAccesoDatos.datos();


            foreach (var elemento in lista) {
                MessageBox.Show(elemento.ToString());
            }
            
        }
    }
}
