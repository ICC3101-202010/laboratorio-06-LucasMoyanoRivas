using System;
namespace SextoLaboratorio
{
    [Serializable]
    public class Bloque : Division
    {
        public string name;
        protected Persona persona1;
        protected Persona persona2;
        public Bloque(string name, Persona persona, Persona persona1, Persona persona2) : base(name, persona)
        {
            this.name = name;
            this.persona1 = persona1;
            this.persona2 = persona2;
        }
    }
}
