using System;
namespace SextoLaboratorio
{
    [Serializable]
    public class Departamento : Division
    {
        public string name;
        public Departamento(string name, Persona persona) : base(name, persona)
        {
            this.name = name;
        }
    }
}
