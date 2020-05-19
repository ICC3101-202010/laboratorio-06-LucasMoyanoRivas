using System;
namespace SextoLaboratorio
{
    [Serializable]
    public class Area : Division
    {
        public string name;
        public Area(string name, Persona persona) : base(name, persona)
        {
            this.name = name;
        }
    }
}
