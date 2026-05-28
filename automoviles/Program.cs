class Program1
{
    static void Main(string[] args)
    {
        Automovil auto1 = new Automovil("Ford", false);

        Console.WriteLine(auto1.IDENTIFICADOR);

        auto1.EncenderApagar();

        auto1.Acelerar();
        auto1.Acelerar(50);

        auto1.MostrarDatos();

        auto1.Frenar(20);

        auto1.MostrarDatos();
    }
}

