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
        //************************************************** REPORTE PEDIDOS ****************************************
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

        //Unifica la cantidad pedida de cada modelo por las concesionarias
        public void CantidadModelos()
        {
            string archivo = "Pedidos.txt";

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string? linea = reader.ReadLine();

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

        //Unifica la cantidad de cada modelo que posee la empresa
        public void CantidadStockIncial()
        {
            string archivo = "StockTerminados.txt";

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string? linea = reader.ReadLine();

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

        public void LimpiarReporte()
        {
            File.Delete(archivoReportePedidos);
        }

        

        //******************************************** REPORTE VEHICULOS ******************************************************************



        string archivoReporteVehiculos = "archivoReporteVehiculos.txt";

        public int[] cantidadPiezasNecesarias = new int[5];
        public int[] stockInicialPiezas = new int[5];

        public ReporteVehiculos[] leerReporteVehiculos()
        {
            ReporteVehiculos[] lista = new ReporteVehiculos[1];
            FileStream fs = new FileStream(archivoReporteVehiculos, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader br = new StreamReader(fs);

            string? linea = br.ReadLine();
            int i = 0;
            while (linea != null)
            {
                lista[i] = new ReporteVehiculos(linea);
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
    
        public void GuardarReporteVehiculos(ReporteVehiculos unReporte)
        {
            FileStream fs = new FileStream(archivoReporteVehiculos, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(unReporte.ObtenerRegistroReportePedidos());
            sw.Close();
        }

        //Unifica la cantidad de piezas necesarias
        public void CantidadPiezasNecesarias()
        {
            string archivo = "archivoReportePedidos.txt";

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string? linea = reader.ReadLine();

                while (linea != null)
                {
                    ReportePedidos piezas = new ReportePedidos(linea);

                    EmpresaComposicionVehiculos composicion = new EmpresaComposicionVehiculos(linea);

                    if (piezas.NumeroModelo==1)
                    {
                        if(composicion.NumeroModeloComposicion == 1)
                        {
                            cantidadPiezasNecesarias[0] =piezas.CantidadPedida*composicion.CantidadUsarComposicion;
                        }
                        if(composicion.NumeroModeloComposicion == 2)
                        {
                            cantidadPiezasNecesarias[1] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 3)
                        {
                            cantidadPiezasNecesarias[2] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 4)
                        {
                            cantidadPiezasNecesarias[3] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 5)
                        {
                            cantidadPiezasNecesarias[4] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                    }
                    if (piezas.NumeroModelo == 2)
                    {
                        if (composicion.NumeroModeloComposicion == 1)
                        {
                            cantidadPiezasNecesarias[0] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 2)
                        {
                            cantidadPiezasNecesarias[1] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 3)
                        {
                            cantidadPiezasNecesarias[2] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 4)
                        {
                            cantidadPiezasNecesarias[3] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 5)
                        {
                            cantidadPiezasNecesarias[4] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                    }
                    if (piezas.NumeroModelo == 3)
                    {
                        if (composicion.NumeroModeloComposicion == 1)
                        {
                            cantidadPiezasNecesarias[0] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 2)
                        {
                            cantidadPiezasNecesarias[1] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 3)
                        {
                            cantidadPiezasNecesarias[2] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 4)
                        {
                            cantidadPiezasNecesarias[3] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 5)
                        {
                            cantidadPiezasNecesarias[4] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                    }
                    if (piezas.NumeroModelo == 4)
                    {
                        if (composicion.NumeroModeloComposicion == 1)
                        {
                            cantidadPiezasNecesarias[0] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 2)
                        {
                            cantidadPiezasNecesarias[1] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 3)
                        {
                            cantidadPiezasNecesarias[2] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 4)
                        {
                            cantidadPiezasNecesarias[3] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 5)
                        {
                            cantidadPiezasNecesarias[4] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                    }
                    if (piezas.NumeroModelo == 5)
                    {
                        if (composicion.NumeroModeloComposicion == 1)
                        {
                            cantidadPiezasNecesarias[0] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 2)
                        {
                            cantidadPiezasNecesarias[1] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 3)
                        {
                            cantidadPiezasNecesarias[2] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 4)
                        {
                            cantidadPiezasNecesarias[3] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                        if (composicion.NumeroModeloComposicion == 5)
                        {
                            cantidadPiezasNecesarias[4] = piezas.CantidadPedida * composicion.CantidadUsarComposicion;
                        }
                    }

                    linea = reader.ReadLine();
                }

            }

            fs.Close();
        }

        //Unifica la cantidad del stock inicial
        public void CantidadStock()
        {
            string archivo = "StockPiezas.txt";

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string? linea = reader.ReadLine();

                while (linea != null)
                {
                    EmpresaStockPieza piezas = new EmpresaStockPieza(linea);

                    switch (piezas.NumeroPieza)
                    {
                        case 1:
                            stockInicialPiezas[0] += piezas.StockPieza;
                            break;
                        case 2:
                            stockInicialPiezas[1] += piezas.StockPieza;
                            break;
                        case 3:
                            stockInicialPiezas[2] += piezas.StockPieza;
                            break;
                        case 4:
                            stockInicialPiezas[3] += piezas.StockPieza;
                            break;
                        case 5:
                            stockInicialPiezas[4] += piezas.StockPieza;
                            break;
                    }

                    linea = reader.ReadLine();
                }

            }

            fs.Close();
        }
        public void LimpiarReporteVehiculos()
        {
            File.Delete(archivoReporteVehiculos);
        }
    }
}
