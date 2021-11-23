using System;
using System.Collections.Generic;
using System.Text;

namespace Control_De_Autos
{
    class Sesion_Furgonetas : Sesion_Vehiculos
    {
        //primero que todo agregamos las distintas propiedades
        public int Numerodeasientos    { get; set; }
        public double PreciobaseFurgo  { get; set; }
        public double Preciodeasientos { get; set; }
        public double Valordelafurgoneta { get; set; }
        
        //Metodo para calcular el precio de la furgoneta
        public override void Calculodeprecio ()
        {
            //Calculo a cobrar (Sumar al precio base el producto del precio de asiento por el número de asientos)
            Valordelafurgoneta = PreciobaseFurgo + (Preciodeasientos * Numerodeasientos);

            Console.WriteLine("La furgoneta tiene {0} asientos su precio base es de {1} y su precio por asientos es:{2} el valor final a pagar es de:${3}", Numerodeasientos, PreciobaseFurgo,  Preciodeasientos,  Valordelafurgoneta);
        }

    
    }
}
