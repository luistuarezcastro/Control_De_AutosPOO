using System;
using System.Collections.Generic;
using System.Text;

namespace Control_De_Autos
{
    public abstract class Sesion_Vehiculos
    {
        //primero que todo agregamos las distintas propiedades como marca, modelo y año de creación
        public string Marcadelcarro { get; set; }
        public string Modelodelcarro { get; set; }
        public string añodecreacion { get; set; }

        public virtual void Mostrardatos()
        {
            Console.WriteLine("Marca del Carro:{0}...Modelo del Carro:{1}...Año de fabricación:{2}", Marcadelcarro , Modelodelcarro , añodecreacion);

        }
        public abstract void Calculodeprecio();
    
    }
}
