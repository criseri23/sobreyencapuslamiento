
class SmartTV
{
    private string marca;
    private int pulgadas;
    private bool encendido;
    private int canalActual;
    private int volumen;
    private bool esPremium;

    public SmartTV(string marca, int pulgadas, bool esPremium)
    {
        this.marca = marca;
        this.pulgadas = pulgadas;
        this.esPremium = esPremium;

        encendido = false;
        canalActual = 1;
        volumen = 20;
    }

    public string CODIGO_CONFIG
    {
        get
        {
            if (esPremium)
            {
                return marca + "-" + pulgadas + "-PREM";
            }
            else
            {
                return marca + "-" + pulgadas + "-STD";
            }
        }
    }

    public void Power()
    {
        encendido = !encendido;
    }

    public void CambiarCanal()
    {
        if (encendido)
        {
            canalActual++;
        }
    }

    public void CambiarCanal(int canal)
    {
        if (encendido)
        {
            canalActual = canal;
        }
    }

    public void RegularVolumen(bool subir)
    {
        if (encendido)
        {
            if (subir)
            {
                volumen += 2;
            }
            else
            {
                volumen -= 2;
            }
        }
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Canal: " + canalActual);
        Console.WriteLine("Volumen: " + volumen);
    }
}
