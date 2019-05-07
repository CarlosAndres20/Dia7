using System;
using System.Collections.Generic;
using System.Text;

namespace Dia7
{
    //Definir un metodo que permita dar de baja a un vehiculo dependiendo de la fecha del vehiculo por el año y el tipo del vehiculo:
    //Si el año del vehiculo es inferior a 1800 y es una retroescavadora se debe dar de baja, 
    //Si es un auto cuyo año es inferior a 1700 se debe dar de baja,
    //si es una moto inferior a 1900 se debe dar de baja,
    //el metodo debe devolver un valor boleano si se puede o no se pude dar de baja posterirmente mostrar 
    //la retroescavadora no se puede dar de baja etc..
    class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Nombre { get; set; }
        public int Ruedas { get; set; }
        public virtual void MiVehiculoDice() {

        }
    }

}
