using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpFinal.Clases.Empresa
{
    public class EmpresaComposicionVehiculos
    {
        public int NumeroModeloComposicion { get; set; }
        public int NumeroPiezaComposicion { get; set; }
        public int CantidadUsarComposicion { get; set; }

        public EmpresaComposicionVehiculos(string lineaComposicionVehiculo)
        {
            var datos = lineaComposicionVehiculo.Split(',');
            NumeroModeloComposicion = int.Parse(datos[0]);
            NumeroPiezaComposicion = int.Parse(datos[1]);
            CantidadUsarComposicion = int.Parse(datos[2]);
        }
        public EmpresaComposicionVehiculos(int numeroModeloComposicion, int numeroPiezaComposicion, int cantidadUsarComposicion)
        {
            NumeroModeloComposicion = numeroModeloComposicion;
            NumeroPiezaComposicion = numeroPiezaComposicion;
            CantidadUsarComposicion = cantidadUsarComposicion;
        }
        public string ObtenerRegistroComposicionVehiculos()
        {
            return string.Format("{0},{1},{2}", NumeroModeloComposicion, NumeroPiezaComposicion, CantidadUsarComposicion);
        }
    }
}
