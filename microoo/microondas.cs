class Microondas
{
    private int potencia;
    private int tiempoSegundos;
    private bool puertaAbierta;
    private bool enFuncionamiento;

    public Microondas(int potencia)
    {
        this.Potencia = potencia;
        this.TiempoSegundos = 0;
        this.PuertaAbierta = false;
        this.EnFuncionamiento = false;
    }

    public int Potencia
    {
        get { return potencia; }
        set { potencia = value; }
    }

    public int TiempoSegundos
    {
        get { return tiempoSegundos; }
        set { tiempoSegundos = value; }
    }

    public bool PuertaAbierta
    {
        get { return puertaAbierta; }
        set { puertaAbierta = value; }
    }

    public bool EnFuncionamiento
    {
        get { return enFuncionamiento; }
        set { enFuncionamiento = value; }
    }

    public string PANTALLA_TIEMPO
    {
        get
        {
            int minutos = TiempoSegundos / 60;
            int segundos = TiempoSegundos % 60;

            return minutos.ToString("00") + ":" + segundos.ToString("00");
        }
    }

    public void AgregarTiempo()
    {
        TiempoSegundos += 30;
    }

    public void AgregarTiempo(int segundos)
    {
        TiempoSegundos += segundos;
    }

    public void Iniciar()
    {
        if (!PuertaAbierta && TiempoSegundos > 0)
        {
            EnFuncionamiento = true;
        }
    }

    public void Detener()
    {
        EnFuncionamiento = false;
    }

    public void AbrirCerrarPuerta()
    {
        PuertaAbierta = !PuertaAbierta;
    }

    public void Mostrar()
    {
        Console.WriteLine("Tiempo: " + PANTALLA_TIEMPO);
        Console.WriteLine("Potencia: " + Potencia);
        Console.WriteLine("Puerta abierta: " + PuertaAbierta);
    }
}
