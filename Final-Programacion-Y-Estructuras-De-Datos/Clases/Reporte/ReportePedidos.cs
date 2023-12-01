using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpFinal.Clases.Reporte
{
    public class ReportePedidos
    {
        public int NumeroModelo { get; set; }
        public int StockInicial { get; set; }
        public int CantidadPedida { get; set; }
        public int StockFinal { get; set; }
        public int AFabricar { get; set; }

        public ReportePedidos(string linea)
        {
            var datos = linea.Split(',');
            NumeroModelo = int.Parse(datos[0]);
            StockInicial = int.Parse(datos[1]);
            CantidadPedida = int.Parse(datos[2]);
            StockFinal = int.Parse(datos[3]);
            AFabricar = int.Parse(datos[4]);
        }
        public ReportePedidos(int numeroModelo, int stockInicial, int cantidadPedida, int stockFinal,int aFabricar)
        {
            NumeroModelo = numeroModelo;
            StockInicial = stockInicial;
            CantidadPedida = cantidadPedida;
            StockFinal = stockFinal;
            AFabricar = aFabricar;

        }
        public string ObtenerRegistroReportePedidos()
        {
            return string.Format("{0},{1},{2},{3},{4}", NumeroModelo,StockInicial, CantidadPedida, StockFinal,AFabricar);
        }
    }
}
