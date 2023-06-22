using CircConCentro2023.Entidades;
using System;

namespace CircConCentro2023.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese el radio de la circunferencia:");
                var radio = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la coord. X del centro:");
                var x = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la coord. Y del centro:");
                var y = int.Parse(Console.ReadLine());
                var centroCirc = new Punto(x, y);

                Console.WriteLine(centroCirc.ToString());

                var circ = new Circunferencia(radio, centroCirc);
                //if (circ.Validar())
                //{
                //    Console.WriteLine(circ.ToString());
                //    Console.WriteLine($"Su perímetro es {circ.GetPerimetro()}");
                //    Console.WriteLine($"Su superficie es {circ.GetSuperficie()}");

                //}
                //else
                //{
                //    Console.WriteLine("Circunferencia no válida... Chequear valor del radio!!!");
                //}

                Console.WriteLine(circ.ToString());
                Console.WriteLine($"Su perímetro es {circ.GetPerimetro()}");
                Console.WriteLine($"Su superficie es {circ.GetSuperficie()}");
                //circ.Radio = -12;
                Console.Write("Ingrese la coord x de otro punto:");
                var x2 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la coord y de otro punto:");
                var y2 = int.Parse(Console.ReadLine());
                var otroPunto = new Punto(x2, y2);
                if (circ.PuntoPerteneceACirc(otroPunto))
                {
                    Console.WriteLine($"{otroPunto.ToString()} pertenece a la circ {circ.ToString()}");
                }
                else
                {
                    Console.WriteLine($"{otroPunto.ToString()} no pertenece a la circ {circ.ToString()}");

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
