using Microsoft.VisualBasic.Logging;
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
using tpFinal.Clases.Reporte;

namespace tpFinal
{
    public partial class Reporte : Form
    {
        GestorReportes gestorReportes;
        public Reporte()
        {

            InitializeComponent();
            gestorReportes = new GestorReportes();

            gestorReportes.LimpiarReporte();
            gestorReportes.LimpiarReporteVehiculos();
        }
        private void Reporte_Load(object sender, EventArgs e)
        {
            //************************************** REPORTE PEDIDOS *********************************************

            //Declaracion de arreglos para guardar los valores de los calculos del archivo de Reporte Pedidos
            int[] stockFinal = new int[5];
            int[] aFabricar = new int[5];
            int[] modelo = { 1, 2, 3, 4, 5 };

            gestorReportes.CantidadModelos();
            gestorReportes.CantidadStockIncial();

            //Recorre para cargar valores en la variable stock final y a fabricar
            for (int i = 0; i < 5; i++)
            {
                stockFinal[i] = gestorReportes.stockInicial[i] - gestorReportes.cantidad[i];
                if (stockFinal[i] < 0)
                {
                    aFabricar[i] = stockFinal[i] * (-1);
                    stockFinal[i] = 0;
                }
                else
                {
                    aFabricar[i] = 0;
                }
            }
            //Creamos reportes con el constructor de la clase reporte pedido
            for (int i = 0; i < 5; i++)
            {
                ReportePedidos unReporte = new ReportePedidos(modelo[i], gestorReportes.stockInicial[i], gestorReportes.cantidad[i], stockFinal[i], aFabricar[i]);
                gestorReportes.GuardarReportePedidos(unReporte);
            }
            MostrarReportePedidos();


            //************************************** REPORTE VEHICULO **********************************************

            //Declaracion de arreglos para guardar los valores de los calculos del archivo de Reporte Vehiculos
            int[] stockFinalPiezas = new int[5];
            int[] aComprar = new int[5];
            int[] numeroPieza = { 1, 2, 3, 4, 5 };

            gestorReportes.CantidadPiezasNecesarias();
            gestorReportes.CantidadStock();

            //Recorre para cargar valores en la variable stock final y a comprar
            for (int i = 0; i < 5; i++)
            {
                stockFinalPiezas[i] = gestorReportes.stockInicialPiezas[i] - gestorReportes.cantidadPiezasNecesarias[i];
                if (stockFinalPiezas[i] < 0)
                {
                    aComprar[i] = stockFinalPiezas[i] * (-1);
                    stockFinalPiezas[i] = 0;
                }
                else
                {
                    aComprar[i] = 0;
                }
            }
            //Creamos reportes con el constructor de la clase reporte vehiculos
            for (int i = 0; i < 5; i++)
            {
                ReporteVehiculos unReporte = new ReporteVehiculos(numeroPieza[i], gestorReportes.cantidadPiezasNecesarias[i], gestorReportes.stockInicialPiezas[i], stockFinalPiezas[i], aComprar[i]);
                gestorReportes.GuardarReporteVehiculos(unReporte);
            }
            MostrarReporteVehiculos();
        }

        //Metododos para llenar la grilla
        public void MostrarReportePedidos()
        {
            this.dgvReporte.DataSource = null;
            this.dgvReporte.DataSource = gestorReportes.leerReportePedidos();
        }
        public void MostrarReporteVehiculos()
        {
            this.dgvReporteVehiculos.DataSource = null;
            this.dgvReporteVehiculos.DataSource = gestorReportes.leerReporteVehiculos();
        }
    }
}
