using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections.Generic;
using System.Threading;
namespace SextoLaboratorio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool exec = true;
            while (exec)
            {
                Console.WriteLine("Quiere cargar la informacion para obtener la información de la empresa?(si/no)");
                string answer = Console.ReadLine();
                List<Empresa> empresas = new List<Empresa>();
                if (answer == "si")
                {
                    try
                    {
                        empresas = Load();
                        showEmpresa(empresas);
                        Thread.Sleep(2000);
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine("No se encontro un archivo");
                        Console.WriteLine(e.Message);
                        Thread.Sleep(2000);
                        addEmpresa(empresas);
                        Console.WriteLine("Guardando datos en el archivo Empresa.bin");
                        Thread.Sleep(2000);
                        Save(empresas);
                        Console.WriteLine("Cerrando archivo...");
                        Thread.Sleep(2000);
                    }
                }
                else
                {
                    addEmpresa(empresas);
                    Console.WriteLine("Guardando datos en el archivo Empresa.bin");
                    Thread.Sleep(2000);
                    Save(empresas);
                    Console.WriteLine("Cerrando archivo...");
                    Thread.Sleep(2000);
                }
                Console.WriteLine("Quiere salir del programa?(si/no)");
                string a = Console.ReadLine();
                if (a == "si")
                {
                    exec = false;
                }
                Console.Clear();
            }
        }
        static public void addEmpresa(List<Empresa> empresas)
        {
            List<Division> divisiones = new List<Division>();
            Console.WriteLine("Ingrese el nombre de la empresa:");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese el rut de la empresa:");
            string rut = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la division:");
            string division = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del encargado:");
            string nombreencargado = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del encargado:");
            string apellidoencargado = Console.ReadLine();
            Console.WriteLine("Ingrese el rut del encargado:");
            string rutencargado = Console.ReadLine();
            Console.WriteLine("Ingrese nombre del area:");
            string area = Console.ReadLine();
            Console.WriteLine("Ingrese nombre del departamento:");
            string depto = Console.ReadLine();
            Console.WriteLine("Ingrese nombre de la seccion:");
            string seccion = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del bloque 1:");
            string bloque1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del personal 1 del bloque 1:");
            string nombrepersonal11 = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del personal 1 del bloque 1:");
            string apellidopersonal11 = Console.ReadLine();
            Console.WriteLine("Ingrese el rut del personal 1 del bloque 1:");
            string rutpersonal11 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del personal 2 del bloque 1:");
            string nombrepersonal21 = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del personal 2 del bloque 1:");
            string apellidopersonal21 = Console.ReadLine();
            Console.WriteLine("Ingrese el rut del personal 2 del bloque 1:");
            string rutpersonal21 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del bloque 2:");
            string bloque2 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del personal 1 del bloque 2:");
            string nombrepersonal12 = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del personal 1 del bloque 2:");
            string apellidopersonal12 = Console.ReadLine();
            Console.WriteLine("Ingrese el rut del personal 1 del bloque 2:");
            string rutpersonal12 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del personal 2 del bloque 2:");
            string nombrepersonal22 = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del personal 2 del bloque 2:");
            string apellidopersonal22 = Console.ReadLine();
            Console.WriteLine("Ingrese el rut del personal 2 del bloque 2:");
            string rutpersonal22 = Console.ReadLine();
            Persona encargado = new Persona(nombreencargado, apellidoencargado, rutencargado, "Encargado");
            Persona personal1 = new Persona(nombrepersonal11, apellidopersonal11, rutpersonal11, "Personal 1");
            Persona personal2 = new Persona(nombrepersonal21, apellidopersonal21, rutpersonal21, "Personal 2");
            Persona personal3 = new Persona(nombrepersonal12, apellidopersonal12, rutpersonal12, "Personal 3");
            Persona personal4 = new Persona(nombrepersonal22, apellidopersonal22, rutpersonal22, "Personal 4");
            Division division1 = new Division(division, encargado);
            Departamento depto1 = new Departamento(depto, encargado);
            Seccion seccion1 = new Seccion(seccion, encargado);
            Bloque bloque11 = new Bloque(bloque1, personal1, personal1, personal1);
            Bloque bloque12 = new Bloque(bloque1, personal2, personal2, personal2);
            Bloque bloque21 = new Bloque(bloque2, personal3, personal3, personal3);
            Bloque bloque22 = new Bloque(bloque2, personal4, personal4, personal4);
            divisiones.Add(division1);
            divisiones.Add(depto1);
            divisiones.Add(seccion1);
            divisiones.Add(bloque11);
            divisiones.Add(bloque12);
            divisiones.Add(bloque21);
            divisiones.Add(bloque22);
            empresas.Add(new Empresa(name, rut, divisiones));
        }
        static public void showEmpresa(List<Empresa> empresas)
        {
            foreach (Empresa empresa in empresas)
            {
                Console.WriteLine(empresa);
            }
            Console.WriteLine();
        }
        static private void Save(List<Empresa> empresas)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, empresas);
            stream.Close();
        }
        static private List<Empresa> Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Empresa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Empresa> empresas = (List<Empresa>)formatter.Deserialize(stream);
            stream.Close();
            return empresas;
        }
    }
}
