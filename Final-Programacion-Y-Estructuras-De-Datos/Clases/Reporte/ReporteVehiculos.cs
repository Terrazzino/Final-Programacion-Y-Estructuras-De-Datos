using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpFinal.Clases.Reporte
{
    public class ReporteVehiculos
    {
        public int NumeroPieza { get; set; }
        public int PiezasNecesarias { get; set; }
        public int StockInicial { get; set; }
        public int StockFinal { get; set; }
        public int AComprar { get; set; }

        public ReporteVehiculos(string linea)
        {
            var datos = linea.Split(',');
            NumeroPieza = int.Parse(datos[0]);
            PiezasNecesarias = int.Parse(datos[1]);
            StockInicial = int.Parse(datos[2]);
            StockFinal = int.Parse(datos[3]);
            AComprar= int.Parse(datos[4]);
        }
        public ReporteVehiculos(int numeroPieza, int piezasNecesarias, int stockInicial, int stockFinal, int aComprar)
        {
            NumeroPieza = numeroPieza;
            PiezasNecesarias = piezasNecesarias;
            StockInicial = stockInicial;
            StockFinal = stockFinal;
            AComprar = aComprar;

        }
        public string ObtenerRegistroReportePedidos()
        {
            return string.Format("{0},{1},{2},{3},{4}", NumeroPieza, PiezasNecesarias, StockInicial, StockFinal, AComprar);
        }
    }
}
