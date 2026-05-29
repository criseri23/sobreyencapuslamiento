class Program3
{
    static void Main(string[] args)
    {
        Microondas micro1 = new Microondas(8);

        micro1.AgregarTiempo();
        micro1.AgregarTiempo(90);

        micro1.Iniciar();

        micro1.Mostrar();
    }
}