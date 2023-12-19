using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpFinal.Clases.Concecionaria
{
    public class Concesionaria
    {
        public int NumeroModelo { get; set; }
        public int NumeroConcesionaria { get; set; }
        public int Cantidad { get; set; }


        public Concesionaria(string linea)
        {
            var datos = linea.Split(',');
            NumeroModelo = int.Parse(datos[0]);
            NumeroConcesionaria = int.Parse(datos[1]);
            Cantidad = int.Parse(datos[2]);
        }
        public Concesionaria(int numeroModelo, int numeroConcecionaria, int cantidad)
        {
            NumeroModelo = numeroModelo;
            NumeroConcesionaria = numeroConcecionaria;
            Cantidad = cantidad;
        }
        public string ObtenerRegistro()
        {
            return string.Format("{0},{1},{2}", NumeroModelo, NumeroConcesionaria, Cantidad);
        }
    }


}
