using EjemploPooListas.Datos;
using EjemploPooListas.Entidades;

namespace EjemploPooListas.Consola
{
    internal class Program
    {
        static RepositorioDeCuadrados repositorio=new RepositorioDeCuadrados();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Lists!");
            do
            {
                string opcionSeleccionada;
                Console.Clear();
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1-Ingresar Cuadrados");
                Console.WriteLine("2-Listar Datos");
                Console.WriteLine("x-Salir");
                Console.Write("Ingrese selección:");
                opcionSeleccionada = Console.ReadLine();
                switch (opcionSeleccionada)
                {
                    case "1":
                        IngresoDeDatos();
                        break;
                    case "2":
                        MostrarDatos();
                        break;
                    case "3":
                    case "x":
                        break;
                }
                if (opcionSeleccionada == "x")
                {
                    break;
                }
            } while (true);
            Console.WriteLine("Fin del Programa");
        }

        private static void MostrarDatos()
        {
            Console.Clear();
            Console.WriteLine("Listado de Datos");
            var lista = repositorio.GetLista();
            foreach (var c in lista)
            {
                Console.WriteLine(c.Lado);
            }
            Console.WriteLine("Listado Finalizado!!!");
            Console.WriteLine("ENTER para continuar");
            Console.ReadLine();

        }

        private static void IngresoDeDatos()
        {
            Console.Clear();
            Console.WriteLine("Ingreso de datos de cuadrados");
            Console.Write("Ingrese un valor del lado (1-10):");
            var lado=int.Parse(Console.ReadLine());
            Cuadrado c=new Cuadrado(lado);
            repositorio.AgregarCuadrado(c);
            Console.WriteLine("Cuadrado agregado!!!");
            Console.WriteLine("ENTER para continuar");
            Console.ReadLine();
        }
    }
}
