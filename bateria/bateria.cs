class Bateria
{
    private int porcentajeCarga;
    private int saludBateria;
    private bool conectadoCargador;
    private bool modoAhorroEnergia;

    public Bateria(int carga, int salud)
    {
        this.PorcentajeCarga = carga;
        this.SaludBateria = salud;

        this.ConectadoCargador = false;
        this.ModoAhorroEnergia = false;
    }

    public int PorcentajeCarga
    {
        get { return porcentajeCarga; }
        set { porcentajeCarga = value; }
    }

    public int SaludBateria
    {
  get { return saludBateria; }
        set { saludBateria = value; }
    }

    public bool ConectadoCargador
    {
        get { return conectadoCargador; }
        set { conectadoCargador = value; }
    }

    public bool ModoAhorroEnergia
    {
        get { return modoAhorroEnergia; }
        set { modoAhorroEnergia = value; }
    }

    public string ESTADO_TEXTO
    {
        get
        {
            return "BATERIA: " + PorcentajeCarga + "%";
        }
    }

    public void AlternarCargador()
    {
        ConectadoCargador = !ConectadoCargador;
    }

    public void ConsumirEnergia()
    {
        PorcentajeCarga -= 1;
    }

    public void ConsumirEnergia(int gasto)
    {
        PorcentajeCarga -= gasto;
    }

    public void CicloDeCarga()
    {
        if (ConectadoCargador)
        {
            PorcentajeCarga += 10;

            if (PorcentajeCarga > SaludBateria)
            {
                PorcentajeCarga = SaludBateria;
            }
        }
    }

    public void Mostrar()
    {
        Console.WriteLine(ESTADO_TEXTO);
        Console.WriteLine("Salud: " + SaludBateria);
    }
}
