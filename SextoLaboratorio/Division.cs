using System;
using System.Collections.Generic;
namespace SextoLaboratorio
{
    [Serializable]
    public class Division
    {
        string name;
        protected Persona persona;
        public Division(string name, Persona persona)
        {
            this.name = name;
            this.persona = persona;
        }
        public string GetName()
        {
            return name;
        }
        public string GetPersonaName()
        {
            return "Nombre: " + persona.GetName() + " " + "Apellido: "+ persona.GetSirName() + " " + "Rut: "+ persona.GetRut() + " " + "Cargo: "+ persona.GetCargo();
        }

    }
}
