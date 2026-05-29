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
        this.nombreSector = nombreSector;
        this.tipoCultivo = tipoCultivo;

        temperaturaActual = 25;
        humedadSuelo = 50;
    }

    public string REPORTE_ESTADO
    {
        get
        {
            return "SECTOR: " + nombreSector +
                   " CULTIVO: " + tipoCultivo;
        }
    }

    public void SimularClima()
    {
        humedadSuelo -= 5;
        temperaturaActual += 1;
    }

    public void SimularClima(int humedad, int temperatura)
    {
        humedadSuelo = humedad;
        temperaturaActual = temperatura;
    }

    public void ControlAutomatico()
    {
        if (tipoCultivo == "TROPICAL")
        {
            if (humedadSuelo < 60)
            {
                sistemaRiegoActivo = true;
            }
        }
    }

    public void Mostrar()
    {
        Console.WriteLine(REPORTE_ESTADO);
        Console.WriteLine("Temperatura: " + temperaturaActual);
        Console.WriteLine("Humedad: " + humedadSuelo);
    }
}
