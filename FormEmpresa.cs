using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpFinal.Clases.Concecionaria;
using tpFinal.Clases.Empresa;

namespace tpFinal
{
    public partial class FormConcecionaria : Form
    {
        GestorEmpresa gestorEmpresa;
        int seleccionadoStockTerminados = 0;
        int seleccionadoStockPiezas = 0;
        int seleccionadoComposicion = 0;
        public FormConcecionaria()
        {
            InitializeComponent();
            gestorEmpresa = new GestorEmpresa();
            MostrarStockTerminado();
            MostrarStockPieza();
            MostrarComposicion();
        }

        // STOCK TERMINADO

        private void btnAltaTerminado_Click(object sender, EventArgs e)
        {
            int numeroModelo = Convert.ToInt32(cmbModeloTerminado.Text);
            string descripcionModelo = txtDescripcionTerminado.Text;
            int stockModelo = Convert.ToInt32(nudStockTerminado.Value);

            EmpresaStockTerminado nuevoStockTerminado = new EmpresaStockTerminado(numeroModelo, descripcionModelo, stockModelo);
            gestorEmpresa.GuardarStockTerminado(nuevoStockTerminado);
            MostrarStockTerminado();
        }
        public void MostrarStockTerminado()
        {
            this.dgvTerminadosEmpresa.DataSource = null;
            this.dgvTerminadosEmpresa.DataSource = gestorEmpresa.leerStockTerminado();
        }

        private void dgvTerminadosEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionadoStockTerminados = e.RowIndex;

            cmbModeloTerminado.Text = dgvTerminadosEmpresa.Rows[seleccionadoStockTerminados].Cells[0].Value.ToString();
            txtDescripcionTerminado.Text = dgvTerminadosEmpresa.Rows[seleccionadoStockTerminados].Cells[1].Value.ToString();
            nudStockTerminado.Text = dgvTerminadosEmpresa.Rows[seleccionadoStockTerminados].Cells[2].Value.ToString();
        }

        private void btnBajaTerminado_Click(object sender, EventArgs e)
        {
            if (seleccionadoStockTerminados != -1)
            {
                gestorEmpresa.BajaStockTerminado(seleccionadoStockTerminados);

                MostrarStockTerminado();
            }
        }

        private void btnModificarTerminado_Click(object sender, EventArgs e)
        {
            if (seleccionadoStockTerminados != -1)
            {
                int numeroModelo = Convert.ToInt32(cmbModeloTerminado.Text);
                string descripcionModelo = txtDescripcionTerminado.Text;
                int stockTerminado = Convert.ToInt32(nudStockTerminado.Value);


                gestorEmpresa.ModificarStockTerminado(numeroModelo, descripcionModelo, stockTerminado, seleccionadoStockTerminados);
                MostrarStockTerminado();
            }
        }

        // PIEZAS 
        private void dgvPiezasEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionadoStockPiezas = e.RowIndex;

            cmbNumeroPieza.Text = dgvPiezasEmpresa.Rows[seleccionadoStockPiezas].Cells[0].Value.ToString();
            txtDescripcionPieza.Text = dgvPiezasEmpresa.Rows[seleccionadoStockPiezas].Cells[1].Value.ToString();
            nudStockPiezas.Text = dgvPiezasEmpresa.Rows[seleccionadoStockPiezas].Cells[2].Value.ToString();
        }

        private void btnAltaPiezas_Click(object sender, EventArgs e)
        {
            int numeroPieza = Convert.ToInt32(cmbNumeroPieza.SelectedIndex + 1);
            string descripcionPieza = txtDescripcionPieza.Text;
            int stockPieza = Convert.ToInt32(nudStockPiezas.Value);

            EmpresaStockPieza nuevoStockPieza = new EmpresaStockPieza(numeroPieza, descripcionPieza, stockPieza);
            gestorEmpresa.GuardarStockPieza(nuevoStockPieza);
            MostrarStockPieza();
        }

        private void btnBajaPiezas_Click(object sender, EventArgs e)
        {
            if (seleccionadoStockPiezas != -1)
            {
                gestorEmpresa.BajaStockPieza(seleccionadoStockPiezas);

                MostrarStockPieza();
            }
        }

        private void btnModificarPiezas_Click(object sender, EventArgs e)
        {
            if (seleccionadoStockPiezas != -1)
            {
                int numeroPieza = int.Parse(cmbNumeroPieza.SelectedIndex.ToString()) + 1;
                string descripcionPieza = txtDescripcionPieza.Text;
                int stockPieza = Convert.ToInt32(nudStockPiezas.Value);


                gestorEmpresa.ModificarStockPieza(numeroPieza, descripcionPieza, stockPieza, seleccionadoStockPiezas);
                MostrarStockPieza();
            }
        }

        public void MostrarStockPieza()
        {
            this.dgvPiezasEmpresa.DataSource = null;
            this.dgvPiezasEmpresa.DataSource = gestorEmpresa.leerStockPieza();
        }


        // COMPOSICION
        private void dgvComposicionEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionadoComposicion = e.RowIndex;

            cmbModeloComposicion.Text = dgvComposicionEmpresa.Rows[seleccionadoComposicion].Cells[0].Value.ToString();
            cmbNumPiezasComposición.Text = dgvComposicionEmpresa.Rows[seleccionadoComposicion].Cells[1].Value.ToString();
            nudCantidadComposicion.Text = dgvComposicionEmpresa.Rows[seleccionadoComposicion].Cells[2].Value.ToString();
        }

        private void btnAltaComposicion_Click(object sender, EventArgs e)
        {
            int numeroModelo = Convert.ToInt32(cmbModeloComposicion.SelectedIndex + 1);
            int numeroPiezas = Convert.ToInt32(cmbNumPiezasComposición.SelectedIndex + 1);
            int cantidadUsar = Convert.ToInt32(nudCantidadComposicion.Value);

            EmpresaComposicionVehiculos nuevaComposicion = new EmpresaComposicionVehiculos(numeroModelo, numeroPiezas, cantidadUsar);
            gestorEmpresa.GuardarComposicionVehi(nuevaComposicion);
            MostrarComposicion();
        }

        private void btnBajaComposicion_Click(object sender, EventArgs e)
        {
            if (seleccionadoComposicion != -1)
            {
                gestorEmpresa.BajaComposicion(seleccionadoComposicion);

                MostrarComposicion();
            }
        }

        private void btnModificarComposicion_Click(object sender, EventArgs e)
        {
            if (seleccionadoComposicion != -1)
            {
                int numeroModelo = Convert.ToInt32(cmbModeloComposicion.SelectedIndex + 1);
                int numeroPiezas = Convert.ToInt32(cmbNumPiezasComposición.SelectedIndex + 1);
                int cantidadUsar = Convert.ToInt32(nudCantidadComposicion.Value);


                gestorEmpresa.ModificarComposicion(numeroModelo,numeroPiezas,cantidadUsar, seleccionadoComposicion);
                MostrarComposicion();
            }
        }

        public void MostrarComposicion()
        {
            this.dgvComposicionEmpresa.DataSource = null;
            this.dgvComposicionEmpresa.DataSource = gestorEmpresa.leerComposicionVehiculos();
        }
    }
}
