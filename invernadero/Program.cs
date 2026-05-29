class Program4
{
    static void Main(string[] args)
    {
        Invernadero inv1 = new Invernadero("Norte", "TROPICAL");

        inv1.Mostrar();

        inv1.SimularClima();

        inv1.ControlAutomatico();

        inv1.Mostrar();
    }
}
