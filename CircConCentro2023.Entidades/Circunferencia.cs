using System;

namespace CircConCentro2023.Entidades
{
    public class Circunferencia
    {
        private int _radio;
        public int Radio
        {
            get
            {
                return _radio;
            }
            set
            {
                _radio = ValidarRadio(value);
            }
        }
        public Punto Centro { get; set; }

        public Circunferencia( int radio, Punto centro)
        {
            //Radio= radio;
            Radio=ValidarRadio(radio);
            Centro= centro;

        }

        public int ValidarRadio( int radio )
        {
            if ( radio <= 0)
            {
                throw new ArgumentOutOfRangeException("Radio no válido");
            }
            return radio;
        }

        //public bool Validar() => Radio > 0;

        public override string ToString()
        {
            return $"Circ de radio {Radio} y centro {Centro.ToString()}";
        }
        public double GetPerimetro()=>2*Math.PI*Radio;
        public double GetSuperficie() => Math.PI * Math.Pow(Radio, 2);

        public bool PuntoPerteneceACirc(Punto punto)
        {
            return Centro.DistanciaEntrePuntos(punto)<=Radio;
        }
    }
}
