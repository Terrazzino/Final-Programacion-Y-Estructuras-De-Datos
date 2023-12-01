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
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            
            int[] stockFinal = new int[5];
            int[] aFabricar = new int[5];
            int[] modelo = {1,2,3,4,5};

            gestorReportes.CantidadModelos();
            gestorReportes.CantidadStockIncial();

            for (int i=0; i<5; i++)
            {
                stockFinal[i] = gestorReportes.stockInicial[i] - gestorReportes.cantidad[i];
                if (stockFinal[i]<0)
                {
                    aFabricar[i] = stockFinal[i]*(-1);
                    stockFinal[i] = 0;
                }
                else
                {
                    aFabricar[i] = 0;
                }
            }
            for(int i=0; i<5; i++)
            {
                ReportePedidos unReporte = new ReportePedidos(modelo[i], gestorReportes.stockInicial[i], gestorReportes.cantidad[i], stockFinal[i], aFabricar[i]);
                gestorReportes.GuardarReportePedidos(unReporte); 
            }
            MostrarReportePedidos();
        }
        public void MostrarReportePedidos()
        {
            this.dgvReporte.DataSource = null;
            this.dgvReporte.DataSource = gestorReportes.leerReportePedidos();

        }
    }
}
