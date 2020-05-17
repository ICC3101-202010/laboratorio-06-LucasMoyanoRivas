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
                Console.Clear();
                Console.WriteLine("Quiere salir del programa?(si/no)");
                string a = Console.ReadLine();
                if (a == "si")
                {
                    exec = false;
                }
            }
        }
        static public void addEmpresa(List<Empresa> empresas)
        {
            Console.Write("Ingrese el nombre de la empresa:");
            string name = Console.ReadLine();
            Console.Write("Ingrese el rut de la empresa:");
            string rut = Console.ReadLine();
            empresas.Add(new Empresa(name, rut));
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
