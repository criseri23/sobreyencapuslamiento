class SmartTV
{
    private string _marca;
    private int _pulgadas;
    private bool _encendido;
    private int _canalActual;
    private int _volumen;
    private bool _esPremium;

    public SmartTV(string marca, int pulgadas, bool esPremium)
    {
        this._marca = marca;
        this._pulgadas = pulgadas;
        this._esPremium = esPremium;

        _encendido = false;
        _canalActual = 1;
        _volumen = 20;
    }

    public string CODIGO_CONFIG
    {
        get
        {
            if (_esPremium)
            {
                return _marca + "-" + _pulgadas + "-PREM";
            }
            else
            {
                return _marca + "-" + _pulgadas + "-STD";
            }
        }
    }

    public void Power()
    {
        _encendido = !_encendido;
    }

    public void CambiarCanal()
    {
        if (_encendido)
        {
            _canalActual++;
        }
    }

    public void CambiarCanal(int canal)
    {
        if (_encendido)
        {
                   _canalActual = canal;
        }
    }

    public void RegularVolumen(bool subir)
    {
        if (_encendido)
        {
            if (subir)
            {
                _volumen += 2;
            }
            else
            {
                _volumen -= 2;
            }
        }
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Canal: " + _canalActual);
        Console.WriteLine("Volumen: " + _volumen);
    }
}
