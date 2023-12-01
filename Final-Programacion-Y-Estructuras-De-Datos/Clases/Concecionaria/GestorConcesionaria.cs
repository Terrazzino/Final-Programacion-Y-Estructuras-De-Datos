using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpFinal.Clases.Concecionaria
{
    public class GestorConcesionaria
    {
        string archivo = "Pedidos.txt";
        


        public Concesionaria[] leerConcesionarias()
        {
            Concesionaria[] lista = new Concesionaria[1];
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader br = new StreamReader(fs);

            string? linea = br.ReadLine();
            int i = 0;
            while (linea != null)
            {
                lista[i] = new Concesionaria(linea);
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

        public Concesionaria[] Ordenar()
        {
            Concesionaria[] pedidos = leerConcesionarias();
            string archivoOrdenado = "PedidosOrdenados.txt";

            for (int i = 0; i < pedidos.Length; i++)
            {
                var temp = pedidos[i];
                for (int j = i + 1; j < pedidos.Length; j++)
                {
                    if (pedidos[i].NumeroConcecionaria > pedidos[j].NumeroConcecionaria)
                    {
                        pedidos[i] = pedidos[j];
                        pedidos[j] = temp;
                        temp = pedidos[j];
                    }
                }
            }

            File.Delete(archivoOrdenado);
            FileStream fs = new FileStream(archivoOrdenado, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            foreach (Concesionaria item in pedidos)
            {
                sw.WriteLine(item.ObtenerRegistro());
            }
            sw.Close();
            File.Delete(archivo);
            File.Move(archivoOrdenado,archivo);

            return pedidos;
        }

        public void GuardarPedido(Concesionaria unPedido)
        {
            
            FileStream fs = new FileStream(archivo, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(unPedido.ObtenerRegistro());
            sw.Close();
        }

        public void Baja(int seleccionado)
        {
            string output = string.Empty;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
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

            fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();

        }

        public void Modificar(int numeroModelo, int numeroConcesionaria, int cantidadPedido, int seleccionado)
        {
            string archivoTemporal = "temp.txt";

            try
            {
                using (FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fs))
                using (FileStream fsTemp = new FileStream(archivoTemporal, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fsTemp))
                {
                    string? linea;
                    int contador = 0;

                    while ((linea = reader.ReadLine()) != null)
                    {
                        Concesionaria unPedido = new Concesionaria(linea);

                        if (seleccionado != contador)
                        {
                            writer.WriteLine(linea);
                        }
                        else
                        {

                            unPedido.NumeroModelo = numeroModelo;
                            unPedido.NumeroConcecionaria = numeroConcesionaria;
                            unPedido.Cantidad = cantidadPedido;


                            writer.WriteLine(unPedido.ObtenerRegistro());

                        }
                        contador++;
                    }
                }


                File.Delete(archivo);
                File.Move(archivoTemporal, archivo);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al modificar el archivo: {ex.Message}");
            }

        }


    }
}
