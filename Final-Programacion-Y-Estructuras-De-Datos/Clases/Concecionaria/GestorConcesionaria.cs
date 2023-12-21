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
        

        //Funcion que retorna la lista de atributos del archivo Pedidos.txt como atributos separados
        public Concesionaria[] leerConcesionarias()
        {
            //Creamos un array para contener los objetos de Concecionaria
            Concesionaria[] lista = new Concesionaria[1];
            //Creamos un objeto FS para abrir o crear un archivo en modo "Solo Lectura"
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            //Creamos un objeto SR para leer el archivo en FS
            StreamReader br = new StreamReader(fs);
            //Leemos la primera linea y la almacenamos en la variable linea
            string? linea = br.ReadLine();
            //Contador para cambiar la posicion de almacenamiento del array
            int i = 0;
            while (linea != null)
            {
                //Mediante el metodo Concecionaria(string...) del objeto guardamos el primer objeto en lista[i]
                lista[i] = new Concesionaria(linea);
                //Indicamos a la variable linea que debera realizar un salto de linea si es que existe
                linea = br.ReadLine();
                if (linea != null)
                {
                    //En caso que la linea exista, redimensionamos el tamaño del array para almacenar el siguiente objeto
                    Array.Resize(ref lista, lista.Length + 1);
                }
                i++;
            }
            //Cerramos el SR para liberar los recursos asociados al archivo
            br.Close();
            return lista;
        }

        //Funcion que retorna los pedidos de la concecionaria de manera ordenada
        public Concesionaria[] Ordenar()
        {
            //Creamos un array de pedidos que guardara los string del archivo que leamos
            Concesionaria[] pedidos = leerConcesionarias();
            string archivoOrdenado = "PedidosOrdenados.txt";

            //Generamos el ordenamiento del array pedidos en base a los parametros Modelo y Concesionaria
            for (int i = 0; i < pedidos.Length; i++)
            {
                var temp = pedidos[i];
                for (int j = i + 1; j < pedidos.Length; j++)
                {
                    if (pedidos[i].NumeroModelo > pedidos[j].NumeroModelo || (pedidos[i].NumeroModelo == pedidos[j].NumeroModelo && pedidos[i].NumeroConcesionaria > pedidos[j].NumeroConcesionaria))
                    {
                        pedidos[i] = pedidos[j];
                        pedidos[j] = temp;
                        temp = pedidos[j];
                    }
                }
            }
            //Comenzamos borrando el archivoOrdenado.txt en caso que ya exista uno (Precaución)
            File.Delete(archivoOrdenado);
            //Creamos objeto FS para anexar y/o crear al archivoOrdenado los atributos ordenados en el array pedidos
            FileStream fs = new FileStream(archivoOrdenado, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            //Cargamos en cada linea del archivo con el objeto de escritura FS los atributos
            foreach (Concesionaria item in pedidos)
            {
                sw.WriteLine(item.ObtenerRegistro());
            }
            sw.Close();
            //Elimiamos los archivos registrados en el archivo Pedidos.txt y le cargamos los nuevos valos Moviendolos desde archivoOrdenado
            File.Delete(archivo);
            File.Move(archivoOrdenado,archivo);

            return pedidos;
        }

        //Metodo para guardar mediante el objeto que pasemos como parametro, sus atributos en el archivo
        public void GuardarPedido(Concesionaria unPedido)
        {
            
            FileStream fs = new FileStream(archivo, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            //Escribimos en el archivo los atributos mediante el metodo Obtener Registro para pasar a string el objeto
            sw.WriteLine(unPedido.ObtenerRegistro());
            sw.Close();
        }

        //Metodo para eliminar un registro del archivo mediante el indice seleccionado en el FORM
        public void Baja(int seleccionado)
        {
            //Creamos un string que funcionara de auxiliar para guardar todos los registros que no coincidan
            //con el indice seleccionado. Lo inicializamos vacio en caso que tenga algun registro guardado previamente
            string output = string.Empty;

            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                //Comenzamos leyendo la primera linea
                string? linea = reader.ReadLine();
                int contador = 0;

                while (linea != null)
                {
                    //Si el contador y el indice del seleccionado no coinciden se guarda el registro en output y se salta a la siguiente linea del ourput para guardar el nuevo registro
                    if (seleccionado != contador)
                    {
                        output += linea + Environment.NewLine;
                    }
                    contador++;
                    //Saltamos a la siguiente linea del archivo para leer si es que existe
                    linea = reader.ReadLine();
                }

            }

            fs.Close();

            //Eliminamos los registros del archivo Pedidos.txt para cargar los archivos actualizados cargados en output
            fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();

        }

        //Metodo para modificar los atributos de un registro segun el indice del registro seleccionado
        public void Modificar(int numeroModelo, int numeroConcesionaria, int cantidadPedido, int seleccionado)
        {
            //Creamos un archivo temporal para guardar los registros que no coincidan con el indice seleccionado
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
                    //Con este condicional generamos automaticamente en cada vuelta
                    //de bucle el salto de linea en el archivo Pedidos.txt
                    while ((linea = reader.ReadLine()) != null)
                    {
                        //Creamos el objeto con la funcion Concesionaria(string...) y la asignamos a unPedio
                        Concesionaria unPedido = new Concesionaria(linea);
                        //Si el contador no coincide con el indice seleccionado se carga al archivoTemporal
                        //el registro que se esta leyendo, sino se cambian los valores de los atributos de ese registro
                        if (seleccionado != contador)
                        {
                            writer.WriteLine(linea);
                        }
                        else
                        {

                            unPedido.NumeroModelo = numeroModelo;
                            unPedido.NumeroConcesionaria = numeroConcesionaria;
                            unPedido.Cantidad = cantidadPedido;

                            //Creamos mediante el Metodo obtener registro un nuevo registro y lo cargamos al archivoTemporal
                            writer.WriteLine(unPedido.ObtenerRegistro());

                        }
                        contador++;
                    }
                }

                //Borramos el archivo Pedidos.txt y luego movemos los registros de archivoTemporal a archivo
                File.Delete(archivo);
                File.Move(archivoTemporal, archivo);
            }
            catch (Exception ex)
            {
                //Mensaje de error en el control de exepciones
                Console.WriteLine($"Error al modificar el archivo: {ex.Message}");
            }

        }

    }
}
