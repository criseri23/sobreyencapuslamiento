class Microondas
{
    private int potencia;
    private int tiempoSegundos;
    private bool puertaAbierta;
    private bool enFuncionamiento;

    public Microondas(int potencia)
    {
        this.potencia = potencia;
        tiempoSegundos = 0;
        puertaAbierta = false;
        enFuncionamiento = false;
    }

    public string PANTALLA_TIEMPO
    {
        get
        {
            int minutos = tiempoSegundos / 60;
            int segundos = tiempoSegundos % 60;

            return minutos.ToString("00") + ":" + segundos.ToString("00");
        }
    }

    public void AgregarTiempo()
    {
        tiempoSegundos += 30;
    }

    public void AgregarTiempo(int segundos)
    {
        tiempoSegundos += segundos;
    }

    public void Iniciar()
    {
        if (!puertaAbierta && tiempoSegundos > 0)
        {
            enFuncionamiento = true;
        }
    }

    public void Detener()
    {
        enFuncionamiento = false;
    }

    public void AbrirCerrarPuerta()
    {
        puertaAbierta = !puertaAbierta;
    }

    public void Mostrar()
    {
        Console.WriteLine("Tiempo: " + PANTALLA_TIEMPO);
        Console.WriteLine("Potencia: " + potencia);
        Console.WriteLine("Puerta abierta: " + puertaAbierta);
    }
}
