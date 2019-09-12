using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_Cola
{
    public partial class Form1 : Form
    {
        // crear el objeto CCola a usar (pacientes)
        private CCola pacientes = new CCola();

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            CNodo nuevo = new CNodo();
            nuevo.NroHC = int.Parse(txtHC.Text);
            nuevo.Nombre = txtNombre.Text;
            pacientes.Insertar(nuevo);
            txtHC.Text = "";
            txtNombre.Text = "";
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            List<CNodo> nodos = pacientes.Listar();
            grdPacientes.Rows.Clear();
            foreach (CNodo n in nodos)
            {
                grdPacientes.Rows.Add(n.NroHC.ToString(), n.Nombre);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            CNodo nodo = pacientes.Eliminar();
            if(nodo != null)
            {
                MessageBox.Show("Eliminado: " + nodo.NroHC.ToString());
            }
            else
            {
                MessageBox.Show("No más hay pacientes");
            }
        }
    }
}
