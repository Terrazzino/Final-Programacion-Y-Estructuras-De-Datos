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
        int seleccionadoStockTerminados = -1;
        int seleccionadoStockPiezas = -1;
        int seleccionadoComposicion = -1;
        public FormConcecionaria()
        {
            InitializeComponent();
            gestorEmpresa = new GestorEmpresa();
            MostrarStockTerminado();
            MostrarStockPieza();
            MostrarComposicion();
        }

        //********************************************** TERMINADOS ***********************************************
        private void btnAltaTerminado_Click(object sender, EventArgs e)
        {
            if (cmbModeloTerminado.Text != "" && txtDescripcionTerminado.Text != "" && nudStockTerminado.Value > 0)
            {
                int numeroModelo = Convert.ToInt32(cmbModeloTerminado.Text);
                string descripcionModelo = txtDescripcionTerminado.Text;
                int stockModelo = Convert.ToInt32(nudStockTerminado.Value);

                EmpresaStockTerminado nuevoStockTerminado = new EmpresaStockTerminado(numeroModelo, descripcionModelo, stockModelo);
                gestorEmpresa.GuardarStockTerminado(nuevoStockTerminado);
                gestorEmpresa.OrdenarStockTerminado();
                MostrarStockTerminado();
                seleccionadoStockTerminados = -1;
            }
            else
            {
                MessageBox.Show("Falta rellenar los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void MostrarStockTerminado()
        {
            this.dgvTerminadosEmpresa.DataSource = null;
            this.dgvTerminadosEmpresa.DataSource = gestorEmpresa.leerStockTerminado();
        }

        private void dgvTerminadosEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionadoStockTerminados = e.RowIndex;

            if (seleccionadoStockTerminados != -1)
            {
                cmbModeloTerminado.Text = dgvTerminadosEmpresa.Rows[seleccionadoStockTerminados].Cells[0].Value.ToString();
                txtDescripcionTerminado.Text = dgvTerminadosEmpresa.Rows[seleccionadoStockTerminados].Cells[1].Value.ToString();
                nudStockTerminado.Text = dgvTerminadosEmpresa.Rows[seleccionadoStockTerminados].Cells[2].Value.ToString();
            }

        }

        private void btnBajaTerminado_Click(object sender, EventArgs e)
        {
            if (seleccionadoStockTerminados != -1)
            {
                gestorEmpresa.BajaStockTerminado(seleccionadoStockTerminados);

                MostrarStockTerminado();
                seleccionadoStockTerminados = -1;
            }
            else
            {
                MessageBox.Show("Seleccione un campo para eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnModificarTerminado_Click(object sender, EventArgs e)
        {
            if (seleccionadoStockTerminados != -1 && cmbModeloTerminado.Text != "" && txtDescripcionTerminado.Text != "" && nudStockTerminado.Value > 0)
            {
                int numeroModelo = Convert.ToInt32(cmbModeloTerminado.Text);
                string descripcionModelo = txtDescripcionTerminado.Text;
                int stockTerminado = Convert.ToInt32(nudStockTerminado.Value);


                gestorEmpresa.ModificarStockTerminado(numeroModelo, descripcionModelo, stockTerminado, seleccionadoStockTerminados);
                gestorEmpresa.OrdenarStockTerminado();
                MostrarStockTerminado();
                seleccionadoStockTerminados = -1;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo y todos los campos deben estar completos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //********************************************** PIEZAS *********************************************
        private void btnAltaPiezas_Click(object sender, EventArgs e)
        {
            if (cmbNumeroPieza.Text != "" && txtDescripcionPieza.Text != "" && nudStockPiezas.Value > 0)
            {
                int numeroPieza = Convert.ToInt32(cmbNumeroPieza.SelectedIndex + 1);
                string descripcionPieza = txtDescripcionPieza.Text;
                int stockPieza = Convert.ToInt32(nudStockPiezas.Value);

                EmpresaStockPieza nuevoStockPieza = new EmpresaStockPieza(numeroPieza, descripcionPieza, stockPieza);
                gestorEmpresa.GuardarStockPieza(nuevoStockPieza);
                gestorEmpresa.OrdenarStockPieza();
                MostrarStockPieza();
                seleccionadoStockPiezas = -1;
            }
            else
            {
                MessageBox.Show("Falta rellenar los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBajaPiezas_Click(object sender, EventArgs e)
        {
            if (seleccionadoStockPiezas != -1)
            {
                gestorEmpresa.BajaStockPieza(seleccionadoStockPiezas);

                MostrarStockPieza();
                seleccionadoStockPiezas = -1;
            }
            else
            {
                MessageBox.Show("Seleccione un campo para eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificarPiezas_Click(object sender, EventArgs e)
        {
            if (seleccionadoStockPiezas != -1 && cmbNumeroPieza.Text != "" && txtDescripcionPieza.Text != "" && nudStockPiezas.Value > 0)
            {
                int numeroPieza = int.Parse(cmbNumeroPieza.SelectedIndex.ToString()) + 1;
                string descripcionPieza = txtDescripcionPieza.Text;
                int stockPieza = Convert.ToInt32(nudStockPiezas.Value);


                gestorEmpresa.ModificarStockPieza(numeroPieza, descripcionPieza, stockPieza, seleccionadoStockPiezas);
                gestorEmpresa.OrdenarStockPieza();
                MostrarStockPieza();
                seleccionadoStockPiezas = -1;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo y todos los campos deben estar completos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }

        public void MostrarStockPieza()
        {
            this.dgvPiezasEmpresa.DataSource = null;
            this.dgvPiezasEmpresa.DataSource = gestorEmpresa.leerStockPieza();
        }

        private void dgvPiezasEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionadoStockPiezas = e.RowIndex;

            if (seleccionadoStockPiezas != -1)
            {
                cmbNumeroPieza.Text = dgvPiezasEmpresa.Rows[seleccionadoStockPiezas].Cells[0].Value.ToString();
                txtDescripcionPieza.Text = dgvPiezasEmpresa.Rows[seleccionadoStockPiezas].Cells[1].Value.ToString();
                nudStockPiezas.Text = dgvPiezasEmpresa.Rows[seleccionadoStockPiezas].Cells[2].Value.ToString();
            }

        }

        //******************************************** COMPOSICION **********************************************
        private void dgvComposicionEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionadoComposicion = e.RowIndex;

            if (seleccionadoComposicion!=-1)
            {
                cmbModeloComposicion.Text = dgvComposicionEmpresa.Rows[seleccionadoComposicion].Cells[0].Value.ToString();
                cmbNumPiezasComposición.Text = dgvComposicionEmpresa.Rows[seleccionadoComposicion].Cells[1].Value.ToString();
                nudCantidadComposicion.Text = dgvComposicionEmpresa.Rows[seleccionadoComposicion].Cells[2].Value.ToString();
            }
        }

        private void btnAltaComposicion_Click(object sender, EventArgs e)
        {
            if (cmbModeloComposicion.Text != "" && cmbNumPiezasComposición.Text != "" && nudCantidadComposicion.Value > 0)
            {
                int numeroModelo = Convert.ToInt32(cmbModeloComposicion.SelectedIndex + 1);
                int numeroPiezas = Convert.ToInt32(cmbNumPiezasComposición.SelectedIndex + 1);
                int cantidadUsar = Convert.ToInt32(nudCantidadComposicion.Value);

                EmpresaComposicionVehiculos nuevaComposicion = new EmpresaComposicionVehiculos(numeroModelo, numeroPiezas, cantidadUsar);
                gestorEmpresa.GuardarComposicionVehi(nuevaComposicion);
                gestorEmpresa.OrdenarComposicionVehiculo();
                MostrarComposicion();
                seleccionadoComposicion = -1;
            }
            else
            {
                MessageBox.Show("Falta rellenar los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnBajaComposicion_Click(object sender, EventArgs e)
        {
            if (seleccionadoComposicion != -1)
            {
                gestorEmpresa.BajaComposicion(seleccionadoComposicion);

                MostrarComposicion();
                seleccionadoComposicion = -1;
            }
            else
            {
                MessageBox.Show("Seleccione un campo para eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificarComposicion_Click(object sender, EventArgs e)
        {
            if (seleccionadoComposicion != -1 && cmbModeloComposicion.Text != "" && cmbNumPiezasComposición.Text != "" && nudCantidadComposicion.Value > 0)
            {
                int numeroModelo = Convert.ToInt32(cmbModeloComposicion.SelectedIndex + 1);
                int numeroPiezas = Convert.ToInt32(cmbNumPiezasComposición.SelectedIndex + 1);
                int cantidadUsar = Convert.ToInt32(nudCantidadComposicion.Value);


                gestorEmpresa.ModificarComposicion(numeroModelo, numeroPiezas, cantidadUsar, seleccionadoComposicion);
                gestorEmpresa.OrdenarComposicionVehiculo();
                MostrarComposicion();
                seleccionadoComposicion = -1;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un campo y todos los campos deben estar completos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }
        public void MostrarComposicion()
        {
            this.dgvComposicionEmpresa.DataSource = null;
            this.dgvComposicionEmpresa.DataSource = gestorEmpresa.leerComposicionVehiculos();
        }
    }
}
