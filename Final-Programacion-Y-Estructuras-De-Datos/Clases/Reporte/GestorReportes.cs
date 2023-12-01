using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpFinal.Clases.Concecionaria;
using tpFinal.Clases.Empresa;

namespace tpFinal.Clases.Reporte
{

    public class GestorReportes
    {


        string archivoReportePedidos = "archivoReportePedidos.txt";
        


        public int[]cantidad =new int[5];
        public int[] stockInicial = new int[5];

        public ReportePedidos[] leerReportePedidos()
        {
            ReportePedidos[] lista = new ReportePedidos[1];
            FileStream fs = new FileStream(archivoReportePedidos, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader br = new StreamReader(fs);

            string? linea = br.ReadLine();
            int i = 0;
            while (linea != null)
            {
                lista[i] = new ReportePedidos(linea);
                linea = br.ReadLine();
                if (linea != null)
                {
                    Array.Resize(ref lista, lista.Length + 1);
                }
                i++;
            }
            br.Close();
            return lista;
        }





        public void GuardarReportePedidos(ReportePedidos unReporte)
        {
            FileStream fs = new FileStream(archivoReportePedidos, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(unReporte.ObtenerRegistroReportePedidos());
            sw.Close();
        }


        public void CantidadModelos()
        {
            string archivo = "Pedidos.txt";

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();

                while (linea != null)
                {
                    Concesionaria unPedido = new Concesionaria(linea);

                    switch (unPedido.NumeroModelo)
                    {
                        case 1:
                            cantidad[0] += unPedido.Cantidad;
                            break;
                        case 2:
                            cantidad[1] += unPedido.Cantidad;
                            break;
                        case 3:
                            cantidad[2] += unPedido.Cantidad;
                            break;
                        case 4:
                            cantidad[3] += unPedido.Cantidad;
                            break;
                        case 5:
                            cantidad[4] += unPedido.Cantidad;
                            break;
                    }

                    linea = reader.ReadLine();
                }

            }

            fs.Close();

        }

        public void CantidadStockIncial()
        {
            string archivo = "StockTerminados.txt";

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();

                while (linea != null)
                {
                    EmpresaStockTerminado unPedido = new EmpresaStockTerminado(linea);

                    switch (unPedido.NumeroModelo)
                    {
                        case 1:
                            stockInicial[0] += unPedido.StockModelo;
                            break;
                        case 2:
                            stockInicial[1] += unPedido.StockModelo;
                            break;
                        case 3:
                            stockInicial[2] += unPedido.StockModelo;
                            break;
                        case 4:
                            stockInicial[3] += unPedido.StockModelo;
                            break;
                        case 5:
                            stockInicial[4] += unPedido.StockModelo;
                            break;
                    }

                    linea = reader.ReadLine();
                }

            }

            fs.Close();

        }
    }
}
