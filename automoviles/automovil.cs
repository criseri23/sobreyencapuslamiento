
using System;

class Automovil
{
    private string marca; private bool motorEncendido;
    private int velocidadActual;
    private bool cajaAutomatica;
    private bool modoCrucero;

    public Automovil(string marca, bool cajaAutomatica)
    {
        this.marca = marca;
        this.cajaAutomatica = cajaAutomatica;
        motorEncendido = false;
        velocidadActual = 0;
        modoCrucero = false;
    }

    public string IDENTIFICADOR
    {
        get
        {
            string tipoCaja;

            if (cajaAutomatica)
            {
                tipoCaja = "AUTO";
            }
            else
            {
                tipoCaja = "MAN";
            }

            return marca.Substring(0, 3).ToUpper() + "-" + tipoCaja + "-2026";
        }
    }

    public void EncenderApagar()
    {
        motorEncendido = !motorEncendido;

        if (!motorEncendido)
        {
            velocidadActual = 0;
            modoCrucero = false;
        }
    }

    public void Acelerar()
    {
        if (motorEncendido)
        {
            velocidadActual += 10;
        }
    }

    public void Acelerar(int km)
    {
        if (motorEncendido)
        {
            velocidadActual += km;
        }
    }

    public void Frenar()
    {
        velocidadActual = 0;
        modoCrucero = false;
    }

    public void Frenar(int km)
    {
        velocidadActual -= km;

        if (velocidadActual < 0)
        {
            velocidadActual = 0;
        }

        modoCrucero = false;
    }

    public void MostrarDatos()
    {
        Console.WriteLine("Motor: " + motorEncendido);
        Console.WriteLine("Velocidad: " + velocidadActual);
        Console.WriteLine("Modo crucero: " + modoCrucero);
    }
}
