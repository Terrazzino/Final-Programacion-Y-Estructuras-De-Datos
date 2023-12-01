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

        //COMIENZA GESTOR TERMINADO
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
            string archivoOrdenado = "terminadosStock.txt";

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
                    }
                }

            }
            File.Delete(archivoOrdenado);
            FileStream fs = new FileStream(archivoOrdenado, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            foreach (EmpresaStockTerminado item in stockTerminados)
            {
                sw.WriteLine(item.ObtenerRegistroStockTerminado());
            }
            sw.Close();
            File.Delete(archivoTerminados);
            File.Move(archivoOrdenado, archivoTerminados);

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
                    string? linea;
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

        //COMIENZA GESTOR PIEZAS
        public EmpresaStockPieza[] leerStockPieza()
        {
            EmpresaStockPieza[] lista = new EmpresaStockPieza[1];
            FileStream fs = new FileStream(archivoPiezas, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader br = new StreamReader(fs);

            string? linea = br.ReadLine();
            int i = 0;
            while (linea != null)
            {
                lista[i] = new EmpresaStockPieza(linea);
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

        public EmpresaStockPieza[] OrdenarStockPieza()
        {
            EmpresaStockPieza[] stockPieza = leerStockPieza();
            string archivoOrdenado = "piezasStock.txt";

            for (int i = 0; i < stockPieza.Length; i++)
            {
                var temp = stockPieza[i];
                for (int j = i + 1; j < stockPieza.Length; j++)
                {
                    if (stockPieza[i].NumeroPieza > stockPieza[j].NumeroPieza)
                    {
                        stockPieza[i] = stockPieza[j];
                        stockPieza[j] = temp;
                        temp = stockPieza[j];
                    }
                }

            }
            File.Delete(archivoOrdenado);
            FileStream fs = new FileStream(archivoOrdenado, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            foreach (EmpresaStockPieza item in stockPieza)
            {
                sw.WriteLine(item.ObtenerRegistroStockPieza());
            }
            sw.Close();
            File.Delete(archivoPiezas);
            File.Move(archivoOrdenado, archivoPiezas);

            return stockPieza;
        }

        public void GuardarStockPieza(EmpresaStockPieza unaPieza)
        {
            FileStream fs = new FileStream(archivoPiezas, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(unaPieza.ObtenerRegistroStockPieza());
            sw.Close();
        }

        public void BajaStockPieza(int seleccionado)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(archivoPiezas, FileMode.OpenOrCreate, FileAccess.Read);
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

            fs = new FileStream(archivoPiezas, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();

        }

        public void ModificarStockPieza(int numeroPieza, string descripcionPieza, int stockPieza, int seleccionado)
        {
            string archivoTemporal = "tempStockPieza.txt";

            try
            {
                using (FileStream fs = new FileStream(archivoPiezas, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fs))
                using (FileStream fsTemp = new FileStream(archivoTemporal, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fsTemp))
                {
                    string? linea;
                    int contador = 0;

                    while ((linea = reader.ReadLine()) != null)
                    {
                        EmpresaStockPieza unStockPieza = new EmpresaStockPieza(linea);

                        if (seleccionado != contador)
                        {
                            writer.WriteLine(linea);
                        }
                        else
                        {

                            unStockPieza.NumeroPieza = numeroPieza;
                            unStockPieza.DescripcionPieza = descripcionPieza;
                            unStockPieza.StockPieza = stockPieza;


                            writer.WriteLine(unStockPieza.ObtenerRegistroStockPieza());

                        }
                        contador++;
                    }
                }


                File.Delete(archivoPiezas);
                File.Move(archivoTemporal, archivoPiezas);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al modificar el archivo: {ex.Message}");
            }
        }


        // Comienzo de composicion vehiculo

        public EmpresaComposicionVehiculos[] leerComposicionVehiculos()
        {
            EmpresaComposicionVehiculos[] lista = new EmpresaComposicionVehiculos[1];
            FileStream fs = new FileStream(archivoComposicion, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader br = new StreamReader(fs);

            string? linea = br.ReadLine();
            int i = 0;
            while (linea != null)
            {
                lista[i] = new EmpresaComposicionVehiculos(linea);
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

        public void GuardarComposicionVehi(EmpresaComposicionVehiculos unaComposicion)
        {
            FileStream fs = new FileStream(archivoComposicion, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(unaComposicion.ObtenerRegistroComposicionVehiculos());
            sw.Close();
        }

        public void BajaComposicion(int seleccionado)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(archivoComposicion, FileMode.OpenOrCreate, FileAccess.Read);
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

            fs = new FileStream(archivoComposicion, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();

        }

        public EmpresaComposicionVehiculos[] OrdenarComposicionVehiculo()
        {
            EmpresaComposicionVehiculos[] composicionVehiculos = leerComposicionVehiculos();
            string archivoOrdenado = "composicionVehiculos.txt";

            for (int i = 0; i < composicionVehiculos.Length; i++)
            {
                var temp = composicionVehiculos[i];
                for (int j = i + 1; j < composicionVehiculos.Length; j++)
                {
                    if (composicionVehiculos[i].NumeroModeloComposicion > composicionVehiculos[j].NumeroModeloComposicion)
                    {
                        composicionVehiculos[i] = composicionVehiculos[j];
                        composicionVehiculos[j] = temp;
                        temp = composicionVehiculos[j];
                    }
                }

            }
            File.Delete(archivoOrdenado);
            FileStream fs = new FileStream(archivoOrdenado, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            foreach (EmpresaComposicionVehiculos item in composicionVehiculos)
            {
                sw.WriteLine(item.ObtenerRegistroComposicionVehiculos());
            }
            sw.Close();
            File.Delete(archivoComposicion);
            File.Move(archivoOrdenado, archivoComposicion);

            return composicionVehiculos;
        }

        public void ModificarComposicion(int numeroModelo, int numeroPiezas, int cantidadUsar, int seleccionado)
        {
            string archivoTemporal = "tempComposicion.txt";

            try
            {
                using (FileStream fs = new FileStream(archivoComposicion, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fs))
                using (FileStream fsTemp = new FileStream(archivoTemporal, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fsTemp))
                {
                    string? linea;
                    int contador = 0;

                    while ((linea = reader.ReadLine()) != null)
                    {
                        EmpresaComposicionVehiculos unaComposicion = new EmpresaComposicionVehiculos(linea);

                        if (seleccionado != contador)
                        {
                            writer.WriteLine(linea);
                        }
                        else
                        {

                            unaComposicion.NumeroModeloComposicion = numeroModelo;
                            unaComposicion.NumeroPiezaComposicion = numeroPiezas;
                            unaComposicion.CantidadUsarComposicion = cantidadUsar;


                            writer.WriteLine(unaComposicion.ObtenerRegistroComposicionVehiculos());

                        }
                        contador++;
                    }
                }


                File.Delete(archivoComposicion);
                File.Move(archivoTemporal, archivoComposicion);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al modificar el archivo: {ex.Message}");
            }
        }
    }
}
