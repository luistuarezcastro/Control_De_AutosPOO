using System;
using System.Collections.Generic;
namespace Control_De_Autos
{
    class Program
    {
        static void Main(string[] args)
        {
            // SESION DE AUTOS
            //auto 1
            Sesion_Autos volkswagen = new Sesion_Autos();
            volkswagen.Marcadelcarro = "volkswagen";
            volkswagen.Modelodelcarro = "Escarabajo";
            volkswagen.añodecreacion = "1967";
            volkswagen.Tipodeauto = "volkswagen tipo 1";
            volkswagen.Preciodelauto = 7000;

            //auto 2
            Sesion_Autos Tesla = new Sesion_Autos();
            Tesla.Marcadelcarro = "Tesla Motors";
            Tesla.Modelodelcarro = "models S";
            Tesla.añodecreacion = "2012";
            Tesla.Tipodeauto = "Luxuri car";
            Tesla.Preciodelauto = 130000;

            //auto 3
            Sesion_Autos Ferrari = new Sesion_Autos();
            Ferrari.Marcadelcarro = "Ferrari";
            Ferrari.Modelodelcarro = "458";
            Ferrari.añodecreacion = "2009";
            Ferrari.Tipodeauto = "Formula 1 (F136)";
            Ferrari.Preciodelauto = 230561;

            //Sesion de autos tipo sedan y tipo Hatchback
            //sendan
            Sesion_Autos Chevrolet = new Sesion_Autos();
            Chevrolet.Marcadelcarro = "Chevrolet";
            Chevrolet.Modelodelcarro = "Chevrolet Beat";
            Chevrolet.añodecreacion = "2019";
            Chevrolet.Tipodeauto = "sedan";
            Chevrolet.Preciodelauto = 25000;

            //Hatchback
            Sesion_Autos Toyota = new Sesion_Autos();
            Toyota.Marcadelcarro = "Toyota";
            Toyota.Modelodelcarro = "Yaris";
            Toyota.añodecreacion = "2019";
            Toyota.Tipodeauto = "Hatchback";
            Toyota.Preciodelauto = 20000;

            //Sesion de Camionetas 
            //DOBLE CABINA 
            Sesion_Camionetas Ford = new Sesion_Camionetas();
            Ford.Marcadelcarro = "Ford";
            Ford.Modelodelcarro = "Ranger";
            Ford.añodecreacion = "1983";
            Ford.Cabinadecamioneta = "DOBLE CABINA";

            //CABINA SIMPLE
            Sesion_Camionetas Mazda = new Sesion_Camionetas();
            Mazda.Marcadelcarro = "Mazda";
            Mazda.Modelodelcarro = "BT-50";
            Mazda.añodecreacion = "2006";
            Mazda.Cabinadecamioneta = "CABINA SIMPLE";

            //Sesion de Furgonetas
            Sesion_Furgonetas Mercedes_Vens = new Sesion_Furgonetas();
            Mercedes_Vens.Marcadelcarro = "Van Sprinter";
            Mercedes_Vens.Modelodelcarro = "Sprinter";
            Mercedes_Vens.añodecreacion = "2021";
            Mercedes_Vens.Numerodeasientos = 10;
            Mercedes_Vens.PreciobaseFurgo = 41000;
            Mercedes_Vens.Preciodeasientos = 3000;

            //Creamos ahora una lista con nuestros coches
            List<Sesion_Vehiculos> Listadecochesagregados = new List<Sesion_Vehiculos>();
            Listadecochesagregados.Add(volkswagen);
            Listadecochesagregados.Add(Tesla);
            Listadecochesagregados.Add(Ferrari);
            Listadecochesagregados.Add(Chevrolet);
            Listadecochesagregados.Add(Toyota);
            Listadecochesagregados.Add(Ford);
            Listadecochesagregados.Add(Mazda);
            Listadecochesagregados.Add(Mercedes_Vens);
            // Mostramos resultados con el foreach
            foreach (Sesion_Vehiculos sesion_Vehiculos in Listadecochesagregados) 
            {
                sesion_Vehiculos.Mostrardatos();
                sesion_Vehiculos.Calculodeprecio();
                
            }
            Console.WriteLine("****GRACIAS POR PREFERIRNOS****");
        }
        

    
    
    }
}
