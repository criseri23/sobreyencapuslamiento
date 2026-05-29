class Program5
{
    static void Main(string[] args)
    {
        Bateria bat1 = new Bateria(50, 100);

        bat1.Mostrar();

        bat1.ConsumirEnergia(20);

        bat1.Mostrar();

        bat1.AlternarCargador();

        bat1.CicloDeCarga();

        bat1.Mostrar();
    }
}