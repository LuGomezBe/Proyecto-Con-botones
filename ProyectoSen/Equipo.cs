using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSen
{
    public partial class Equipo : Form
    {
        public Equipo()
        {
            InitializeComponent();
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.SelecionEquipo(dgvEquipo, txtId, cmbTipoE, txtMarca, txtDescripcion);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.modificarEquipo(txtId, cmbTipoE, txtMarca, txtDescripcion);
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            Clases.CReporte objetoReporte = new Clases.CReporte();
            Form1 tecnico = new Form1();
            Cliente cliente = new Cliente();
            objetoEquipo.guardarEquipo(cmbTipoE, txtMarca, txtDescripcion);
            objetoReporte.guardarReporte(tecnico.txtDni, cliente.txtDni, txtMarca);
            
            
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.DeleteEquipo(txtId);
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal formularioP = new Principal();
            formularioP.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.ResetEquipo();
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

    }
}
