using System;
namespace SextoLaboratorio
{
    [Serializable]
    public class Empresa
    {
        private string name;
        private string rut;
        public Empresa(string name, string rut)
        {
            this.name = name;
            this.rut = rut;
        }
        public override string ToString()
        {
            return name + " " + rut;
        }
    }
}
