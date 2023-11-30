using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpFinal.Clases.Empresa
{
    public class EmpresaStockPieza
    {
        public int NumeroPieza { get; set; }
        public string DescripcionPieza { get; set; }
        public int StockPieza { get; set; }

        public EmpresaStockPieza(string lineaStockPieza)
        {
            var datos = lineaStockPieza.Split(',');
            NumeroPieza = int.Parse(datos[0]);
            DescripcionPieza = datos[1];
            StockPieza = int.Parse(datos[2]);
        }
        public EmpresaStockPieza(int numeroPieza, string descripcionPieza, int stockPieza)
        {
            NumeroPieza = numeroPieza;
            DescripcionPieza = descripcionPieza;
            StockPieza = stockPieza;
        }
        public string ObtenerRegistroStockPieza()
        {
            return string.Format("{0},{1},{2}", NumeroPieza, DescripcionPieza, StockPieza);
        }
    }
}
