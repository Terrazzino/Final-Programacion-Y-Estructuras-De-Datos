using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpFinal
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

            for (int i = 0; i < pedidos.Length; i++)
            {
                var temp = pedidos[i];
                for (int j = i + 1; j < pedidos.Length; j++)
                {
                    if (pedidos[i].NumeroModelo > pedidos[j].NumeroModelo)
                    {
                        pedidos[i] = pedidos[j];
                        pedidos[j] = temp;
                        temp = pedidos[j];

                        if (pedidos[i].NumeroModelo == pedidos[j].NumeroModelo &&
                            pedidos[i].NumeroConcecionaria > pedidos[j].NumeroConcecionaria)
                        {
                            pedidos[i] = pedidos[j];
                            pedidos[j] = temp;
                            temp = pedidos[j];
                        }
                    }
                }
                
            }
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
                string linea = reader.ReadLine();
                int contador = 0;

                while (linea != null)
                {
                    Concesionaria unPedido = new Concesionaria(linea);

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

    }
}
