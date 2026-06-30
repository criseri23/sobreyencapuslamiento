using System;

class Program
{
    static void Main(string[] args)
    {
        Bateria bateria = new Bateria(80, 100);
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine(bateria.ESTADO_TEXTO);
            Console.WriteLine("Modo ahorro: " + (bateria.ModoAhorroEnergia ? "ACTIVADO" : "DESACTIVADO"));
            Console.WriteLine("=================================");

            Console.WriteLine("1- Conectar/Desconectar cargador");
            Console.WriteLine("2- Usar teléfono en reposo");
            Console.WriteLine("3- Abrir una app pesada");
            Console.WriteLine("4- Simular carga");
            Console.WriteLine("5- Mostrar información");
            Console.WriteLine("0- Salir");
            Console.Write("\nOpción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    bateria.AlternarCargador();
                    break;

                case 2:
                    bateria.ConsumirEnergia();
                    break;

                case 3:
                    Console.Write("¿Cuánta batería consume la app?: ");
                    int gasto = int.Parse(Console.ReadLine());
                    bateria.ConsumirEnergia(gasto);
                    break;

                case 4:
                    bateria.CicloDeCarga();
                    break;

                case 5:
                    bateria.Mostrar();
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != 0);
    }
}
