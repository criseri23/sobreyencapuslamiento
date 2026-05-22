using System;

class Automovil
{
    private string _marca;
    private bool _motorEncendido;
    private int _velocidadActual;
    private bool _cajaAutomatica;
    private bool _modoCrucero;

    public Automovil(string marca, bool cajaAutomatica)
    {
        this._marca = marca;
        this._cajaAutomatica = cajaAutomatica;
        _motorEncendido = false;
        _motorEncendido = false;
        _velocidadActual = 0;
        _modoCrucero = false;
    }

    public string IDENTIFICADOR
    {
        get
        {
            string tipoCaja;

            if (_cajaAutomatica)
            {
                tipoCaja = "AUTO";
         }
            else
            {
                tipoCaja = "MAN";
            }

            return _marca.Substring(0, 3).ToUpper() + "-" + tipoCaja + "-2026";
        }
    }

    public void EncenderApagar()
    {
        _motorEncendido = !_motorEncendido;

        if (!_motorEncendido)
        {
            _velocidadActual = 0;
            _modoCrucero = false;
        }
    }

    public void Acelerar()
    {
        if (_motorEncendido)
        {
            _velocidadActual += 10;
        }
    }

    public void Acelerar(int km)
    {
        if (_motorEncendido)
        {
            _velocidadActual += km;
        }
        else(
               !_motorEncendido )
               {
            console.Writeline("No se puede acelerar porque el motor esta apagado")
                return;
        }
    }
   public void Frenar()
    {
        _velocidadActual = 0;
        _modoCrucero = false;
    }

    public void Frenar(int km)
    {
        _velocidadActual -= km;

        if (_velocidadActual < 0)
        {
            _velocidadActual = 0;
        }

        _modoCrucero = false;
    }

    public void MostrarDatos()
    {
        Console.WriteLine("Motor: " + _motorEncendido);
        Console.WriteLine("Velocidad: " + _velocidadActual);
        Console.WriteLine("Modo crucero: " + _modoCrucero);
    }
}
