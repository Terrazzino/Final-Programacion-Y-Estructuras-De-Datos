﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpFinal
{
    public class Concesionaria
    {
        public int NumeroModelo { get; set; }
        public int NumeroConcecionaria { get; set; }
        public int Cantidad { get; set; }


        public Concesionaria(string linea)
        {
            var datos = linea.Split(',');
            NumeroModelo = int.Parse(datos[0]);
            NumeroConcecionaria = int.Parse(datos[1]);
            Cantidad = int.Parse(datos[2]);
        }
        public Concesionaria(int numeroModelo, int numeroConcecionaria, int cantidad)
        {
            NumeroModelo = numeroModelo;
            NumeroConcecionaria = numeroConcecionaria;
            Cantidad = cantidad;
        }
        public string ObtenerRegistro()
        {
            return String.Format("{0},{1},{2}", NumeroModelo, NumeroConcecionaria, Cantidad);
        }
    }


}
