class Program2
{
    static void Main(string[] args)
    {
        SmartTV tv1 = new SmartTV("Samsung", 55, true);

        Console.WriteLine(tv1.CODIGO_CONFIG);

        tv1.Power();

        tv1.CambiarCanal();
        tv1.CambiarCanal(80);

        tv1.RegularVolumen(true);

        tv1.MostrarEstado();
    }
}
