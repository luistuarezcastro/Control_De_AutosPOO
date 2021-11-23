using System;
using System.Collections.Generic;
using System.Text;


namespace Control_De_Autos
{
    //herademos la clase camionetas de la clase vehiculos
    public class Sesion_Camionetas : Sesion_Vehiculos
    {
    public string Cabinadecamioneta { get; set; }

    public Double valorCami;

        public override void Calculodeprecio()
        {
            //Doble cabina
            if (Cabinadecamioneta.Equals("DOBLE CABINA"))
            {
                valorCami = 20000;
            }
            if (Cabinadecamioneta.Equals("CABINA SIMPLE"))
            {
                //Cabina simple
                valorCami = 15000;
            }
            Console.WriteLine("La camioneta es de tipo:{0} y su valor es de:{1}", Cabinadecamioneta , valorCami);
        }
    }
}
