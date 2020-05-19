using System;
namespace SextoLaboratorio
{
    [Serializable]
    public class Persona
    {
        private string name;
        private string sirname;
        private string rut;
        private string cargo;
        public Persona(string name, string sirname, string rut, string cargo)
        {
            this.name = name;
            this.sirname = sirname;
            this.rut = rut;
            this.cargo = cargo;
        }
        public string GetName()
        {
            return name;
        }
        public string GetSirName()
        {
            return sirname;
        }
        public string GetRut()
        {
            return rut;
        }
        public string GetCargo()
        {
            return cargo;
        }
    }
}
