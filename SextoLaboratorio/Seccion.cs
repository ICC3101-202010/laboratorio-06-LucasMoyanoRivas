using System;
namespace SextoLaboratorio
{
    [Serializable]
    public class Seccion : Division
    {
        public string name;
        public Seccion(string name, Persona persona) : base(name, persona)
        {
            this.name = name;
        }
    }
}
