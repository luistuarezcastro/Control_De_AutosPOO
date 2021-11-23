using System;
using System.Collections.Generic;
using System.Text;

namespace Control_De_Autos
{
    // aqui podemos ver como esta clase autos hereda de la clase Vehiculos
    public class Sesion_Autos : Sesion_Vehiculos 
    {
    //propiedades
    public string Tipodeauto { get; set; }
    public int Preciodelauto { get; set; }
    
    public double Precio;
      
        //sobreescribimos el metodo astracto (override)
        public override void Calculodeprecio()
        {
            //sedan
            if (Tipodeauto.Equals("sedan"))
            {
                Precio = Preciodelauto;
            }
            //Hatchback
            else
            {
                Precio = Preciodelauto - (Preciodelauto * 0.10);
            }
            Console.WriteLine("el coche es de tipo :{0} y tiene un valor de:{1}", Tipodeauto, Precio);
        }







    }
}
