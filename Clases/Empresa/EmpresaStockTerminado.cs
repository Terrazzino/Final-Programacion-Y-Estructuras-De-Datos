using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpFinal.Clases.Empresa
{
    public class EmpresaStockTerminado
    {
        public int NumeroModelo { get; set; }
        public string DescripcionModelo { get; set; }
        public int StockModelo { get; set; }

        public EmpresaStockTerminado(string lineaStockTerminado)
        {
            var datos = lineaStockTerminado.Split(',');
            NumeroModelo = int.Parse(datos[0]);
            DescripcionModelo = datos[1];
            StockModelo = int.Parse(datos[2]);
        }
        public EmpresaStockTerminado(int numeroModelo, string descripcionModelo, int stockModelo)
        {
            NumeroModelo = numeroModelo;
            DescripcionModelo = descripcionModelo;
            StockModelo = stockModelo;
        }
        public string ObtenerRegistroStockTerminado()
        {
            return string.Format("{0},{1},{2}", NumeroModelo, DescripcionModelo, StockModelo);
        }

    }
}
