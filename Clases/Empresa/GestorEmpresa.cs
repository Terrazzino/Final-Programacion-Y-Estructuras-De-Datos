using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpFinal.Clases.Concecionaria;

namespace tpFinal.Clases.Empresa
{
    public class GestorEmpresa
    {
        string archivoTerminados = "StockTerminados.txt";
        string archivoPiezas = "StockPiezas.txt";
        string archivoComposicion = "ComposicionVehiculo.txt";

        public EmpresaStockTerminado[] leerStockTerminado()
        {
            EmpresaStockTerminado[] lista = new EmpresaStockTerminado[1];
            FileStream fs = new FileStream(archivoTerminados, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader br = new StreamReader(fs);

            string? linea = br.ReadLine();
            int i = 0;
            while (linea != null)
            {
                lista[i] = new EmpresaStockTerminado(linea);
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

        public EmpresaStockTerminado[] OrdenarStockTerminado()
        {
            EmpresaStockTerminado[] stockTerminados = leerStockTerminado();

            for (int i = 0; i < stockTerminados.Length; i++)
            {
                var temp = stockTerminados[i];
                for (int j = i + 1; j < stockTerminados.Length; j++)
                {
                    if (stockTerminados[i].NumeroModelo > stockTerminados[j].NumeroModelo)
                    {
                        stockTerminados[i] = stockTerminados[j];
                        stockTerminados[j] = temp;
                        temp = stockTerminados[j];

                        if (stockTerminados[i].NumeroModelo == stockTerminados[j].NumeroModelo)
                        {
                            stockTerminados[i] = stockTerminados[j];
                            stockTerminados[j] = temp;
                            temp = stockTerminados[j];
                        }
                    }
                }

            }
            return stockTerminados;
        }

        public void GuardarStockTerminado(EmpresaStockTerminado unPedido)
        {
            FileStream fs = new FileStream(archivoTerminados, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(unPedido.ObtenerRegistroStockTerminado());
            sw.Close();
        }

        public void BajaStockTerminado(int seleccionado)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(archivoTerminados, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string? linea = reader.ReadLine();
                int contador = 0;

                while (linea != null)
                {

                    if (seleccionado != contador)
                    {
                        output += linea + Environment.NewLine;
                    }
                    contador++;

                    linea = reader.ReadLine();
                }

            }

            fs.Close();

            fs = new FileStream(archivoTerminados, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();

        }

        public void ModificarStockTerminado(int numeroModelo, string descripcionModelo, int stockModelo, int seleccionado)
        {
            string archivoTemporal = "tempStockTerminados.txt";

            try
            {
                using (FileStream fs = new FileStream(archivoTerminados, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fs))
                using (FileStream fsTemp = new FileStream(archivoTemporal, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fsTemp))
                {
                    string linea;
                    int contador = 0;

                    while ((linea = reader.ReadLine()) != null)
                    {
                        EmpresaStockTerminado unStockTerminado = new EmpresaStockTerminado(linea);

                        if (seleccionado != contador)
                        {
                            writer.WriteLine(linea);
                        }
                        else
                        {

                            unStockTerminado.NumeroModelo = numeroModelo;
                            unStockTerminado.DescripcionModelo = descripcionModelo;
                            unStockTerminado.StockModelo = stockModelo;


                            writer.WriteLine(unStockTerminado.ObtenerRegistroStockTerminado());

                        }
                        contador++;
                    }
                }


                File.Delete(archivoTerminados);
                File.Move(archivoTemporal, archivoTerminados);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al modificar el archivo: {ex.Message}");
            }
        }
    }
}
