using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Laboratorio_6
{
    [Serializable()]
    class Empresa
    {
        string nombre, rut;
        public Empresa(string anombre, string arut)
        {
            nombre = anombre;
            rut = arut;
        }

        public string infoempresa()
        {
            return "nombre: " + nombre + " rut: " + rut;
        }
        public static void Creararchivo()
        {
            IFormatter empresa = new BinaryFormatter();
            Stream bf = new FileStream("Empresas.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            bf.Close();

        }

        static List<Empresa> listaempresa = new List<Empresa>();
        static List<Empresa> listaempresa2 = new List<Empresa>();
        static List<Area> areaempresa = new List<Area>();
        static List<Departamento> deptoempresa = new List<Departamento>();
        static List<Seccion> seccionempresa = new List<Seccion>();
        static List<Bloque> bloqueempresa= new List<Bloque>();
        static List<Area> areaempresa2 = new List<Area>();
        static List<Departamento> deptoempresa2 = new List<Departamento>();
        static List<Seccion> seccionempresa2 = new List<Seccion>();
        static List<Bloque> bloqueempresa2 = new List<Bloque>();

        public void addempresa(Empresa empresa, Area area,Departamento depto, Seccion seccion, Bloque bloque)
        {
            listaempresa.Add(empresa);
            areaempresa.Add(area);
            deptoempresa.Add(depto);
            seccionempresa.Add(seccion);
            bloqueempresa.Add(bloque);
        }

        public  void saveempresa()
        {
            IFormatter empresa = new BinaryFormatter();
            Stream bf = new FileStream("Empresas.bin",FileMode.Open,FileAccess.Write,FileShare.None);
            empresa.Serialize(bf, listaempresa.Count());
            for(int i=0; i <listaempresa.Count(); i++)
            {
                empresa.Serialize(bf, listaempresa[i]);
                empresa.Serialize(bf, areaempresa[i]);
                empresa.Serialize(bf, deptoempresa[i]);
                empresa.Serialize(bf, seccionempresa[i]);
                empresa.Serialize(bf, bloqueempresa[i]);
            }
            bf.Close();
        }

        public static void readempresa()
        {
            IFormatter empresa = new BinaryFormatter();
            Stream bf = new FileStream("Empresas.bin", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            int p = (int)empresa.Deserialize(bf);
            for (int i=0; i<p ; i++)
            {
                Empresa emp = (Empresa)empresa.Deserialize(bf);
                Area are = (Area)empresa.Deserialize(bf);
                Departamento dep = (Departamento)empresa.Deserialize(bf);
                Seccion sec = (Seccion)empresa.Deserialize(bf);
                Bloque blo = (Bloque)empresa.Deserialize(bf);
                listaempresa2.Add(emp);
                areaempresa2.Add(are);
                deptoempresa2.Add(dep);
                seccionempresa2.Add(sec);
                bloqueempresa2.Add(blo);
                
            }
            for(int i=0; i<p;  i++)
            {
                Console.WriteLine(listaempresa2[i].infoempresa());
                Console.WriteLine(areaempresa2[i].getinfo());
                Console.WriteLine(deptoempresa2[i].getinfo());
                Console.WriteLine(seccionempresa2[i].getinfo());
                Console.WriteLine(bloqueempresa2[i].getinfo());


            }
            bf.Close();
        }

        


    }
}
