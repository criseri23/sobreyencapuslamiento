class Invernadero
{
    private string nombreSector;
    private int temperaturaActual;
    private int humedadSuelo;
    private bool sistemaRiegoActivo;
    private bool calefaccionActiva;
    private string tipoCultivo;

    public Invernadero(string nombreSector, string tipoCultivo)
    {
        this.NombreSector = nombreSector;
        this.TipoCultivo = tipoCultivo;

        this.TemperaturaActual = 25;
        this.HumedadSuelo = 50;
    }

    public string NombreSector
    {
        get { return nombreSector; }
        set { nombreSector = value; }
    }

    public int TemperaturaActual
    {
        get { return temperaturaActual; }
        set { temperaturaActual = value; }
    }

    public int HumedadSuelo
    {
        get { return humedadSuelo; }
        set { humedadSuelo = value; }
    }

    public bool SistemaRiegoActivo
    {
        get { return sistemaRiegoActivo; }
        set { sistemaRiegoActivo = value; }
    }

    public bool CalefaccionActiva
    {
        get { return calefaccionActiva; }
        set { calefaccionActiva = value; }
    }

    public string TipoCultivo
    {
        get { return tipoCultivo; }
        set { tipoCultivo = value; }
    }

    public string REPORTE_ESTADO
    {
        get
        {
            return "SECTOR: " + NombreSector +
                   " CULTIVO: " + TipoCultivo;
        }
    }

    public void SimularClima()
    {
        HumedadSuelo -= 5;
        TemperaturaActual += 1;
    }

    public void SimularClima(int humedad, int temperatura)
    {
        HumedadSuelo = humedad;
        TemperaturaActual = temperatura;
    }

    public void ControlAutomatico()
    {
        if (TipoCultivo == "TROPICAL")
        {
            if (HumedadSuelo < 60)
            {
                SistemaRiegoActivo = true;
            }
        }
    }

    public void Mostrar()
    {
        Console.WriteLine(REPORTE_ESTADO);
        Console.WriteLine("Temperatura: " + TemperaturaActual);
        Console.WriteLine("Humedad: " + HumedadSuelo);
    }
}
