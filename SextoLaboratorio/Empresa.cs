using System;
using System.Collections.Generic;

namespace SextoLaboratorio
{
    [Serializable]
    public class Empresa
    {
        private string name;
        private string rut;
        private List<Division> divisiones = new List<Division>();
        public Empresa(string name, string rut, List<Division> divisiones)
        {
            this.name = name;
            this.rut = rut;
            this.divisiones = divisiones;
        }
        public override string ToString()
        {
            string division = "";
            string persona1 = "";
            string depto = "";
            string seccion = "";
            string bloque1 = "";
            string bloque2 = "";
            string persona2 = "";
            string persona3 = "";
            string persona4 = "";
            string persona5 = "";

            foreach (Division a in divisiones)
            {
                Type t = a.GetType();
                if (t == typeof(Division))
                {
                    division = a.GetName();
                    persona1 = a.GetPersonaName();
                }
                if (t == typeof(Departamento))
                {
                    depto = a.GetName();
                }
                if (t == typeof(Seccion))
                {
                    seccion = a.GetName();
                }
                if (t == typeof(Bloque))
                {
                    bloque1 = a.GetName();
                    persona2 = a.GetPersonaName();
                    break;
                }
            }
            foreach (Division a in divisiones)
            {
                Type t = a.GetType();
                if (t == typeof(Division))
                {
                    division = a.GetName();
                    persona1 = a.GetPersonaName();
                }
                if (t == typeof(Departamento))
                {
                    depto = a.GetName();
                }
                if (t == typeof(Seccion))
                {
                    seccion = a.GetName();
                }
                if (t == typeof(Bloque))
                {
                    bloque1 = a.GetName();
                    persona3 = a.GetPersonaName();
                    if (persona3 == persona2)
                    {
                        persona3 = a.GetPersonaName();
                        break;
                    }
                }
            }
            foreach (Division a in divisiones)
            {
                Type t = a.GetType();
                if (t == typeof(Division))
                {
                    division = a.GetName();
                    persona1 = a.GetPersonaName();
                }
                if (t == typeof(Departamento))
                {
                    depto = a.GetName();
                }
                if (t == typeof(Seccion))
                {
                    seccion = a.GetName();
                }
                if (t == typeof(Bloque))
                {
                    bloque2 = a.GetName();
                    persona4 = a.GetPersonaName();
                    if (persona4 == persona3)
                    {
                        persona4 = a.GetPersonaName();
                        break;
                    }
                }
            }
            foreach (Division a in divisiones)
            {
                Type t = a.GetType();
                if (t == typeof(Division))
                {
                    division = a.GetName();
                    persona1 = a.GetPersonaName();
                }
                if (t == typeof(Departamento))
                {
                    depto = a.GetName();
                }
                if (t == typeof(Seccion))
                {
                    seccion = a.GetName();
                }
                if (t == typeof(Bloque))
                {
                    bloque2 = a.GetName();
                    persona5 = a.GetPersonaName();
                }
            }
            string message = "Nombre empresa: " + name + " " + "Rut empresa: " + rut + "\n" + "Nombre Division: " + division + "\n" + "Encargado: " + persona1 + "\n" + "Nombre Depto: " + depto + "\n" + "Nombre Seccion: " + seccion + "\n" + "Nombre Bloque1: " + bloque1 + "\n" + "Personal 1: " + persona2 + "\n" + "Personal 2: " + persona3 + "\n" + "Nombre Bloque2: " + bloque2 + "\n" + "Personal 1: " + persona4 + "\n" + "Personal 2: " + persona5;
            return message;
        }
    }
}
