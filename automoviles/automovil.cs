class Automovil
{
    private string marca;
    private bool motorEncendido;
    private int velocidadActual;
    private bool cajaAutomatica;
    private bool modoCrucero;

    public Automovil(string marca, bool cajaAutomatica)
    {
        this.Marca = marca;
        this.CajaAutomatica = cajaAutomatica;
        this.MotorEncendido = false;
        this.VelocidadActual = 0;
        this.ModoCrucero = false;
    }

    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public bool MotorEncendido
    {
        get { return motorEncendido; }
        set { motorEncendido = value; }
    }

    public int VelocidadActual
    {
        get { return velocidadActual; }
        set { velocidadActual = value; }
    }

    public bool CajaAutomatica
    {
        get { return cajaAutomatica; }
        set { cajaAutomatica = value; }
    }

    public bool ModoCrucero
    {
        get { return modoCrucero; }
        set { modoCrucero = value; }
    }

    public string IDENTIFICADOR
    {
        get
        {
            string tipoCaja;

            if (CajaAutomatica)
            {
                tipoCaja = "AUTO";
            }
            else
            {
                tipoCaja = "MAN";
            }

            return Marca.Substring(0, 3).ToUpper() + "-" + tipoCaja + "-2026";
        }
    }

    public void EncenderApagar()
    {
        MotorEncendido = !MotorEncendido;

        if (!MotorEncendido)
        {
            VelocidadActual = 0;
            ModoCrucero = false;
        }
    }

    public void Acelerar()
    {
        if (MotorEncendido)
        {
            VelocidadActual += 10;
        }
    }

    public void Acelerar(int km)
    {
        if (MotorEncendido)
        {
            VelocidadActual += km;
        }
    }

    public void Frenar()
    {
        VelocidadActual = 0;
        ModoCrucero = false;
    }

    public void Frenar(int km)
    {
        VelocidadActual -= km;

        if (VelocidadActual < 0)
        {
            VelocidadActual = 0;
        }

        ModoCrucero = false;
    }

    public void MostrarDatos()
    {
        Console.WriteLine("Motor: " + MotorEncendido);
        Console.WriteLine("Velocidad: " + VelocidadActual);
        Console.WriteLine("Modo crucero: " + ModoCrucero);
    }
}

