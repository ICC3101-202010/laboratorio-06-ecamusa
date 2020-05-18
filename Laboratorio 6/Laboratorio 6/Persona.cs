using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_6
{
    class Persona
    {
        string nombre, rut, apellido,cargo ,nombre1, rut1, apellido1, cargo1;
        int edad, edad1;
       public  Persona(string anombre, string aapellido, string arut, int aedad, string acargo)
        {
            nombre = anombre;
            apellido = aapellido;
            rut = arut;
            edad = aedad;
            cargo = acargo;
        }

        List<Persona> personas = new List<Persona>();
        public void createperson()
        {
            Console.WriteLine("ingrese nombre:" );
            nombre1 = Console.ReadLine();
            Console.WriteLine("ingrese apellido:");
            apellido1 = Console.ReadLine();
            Console.WriteLine("ingrese rut:");
            rut = Console.ReadLine();
            Console.WriteLine("ingrese edad:");
            edad1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese cargo: ");
            cargo1 = Console.ReadLine();
            


            Persona persona1 = new Persona(nombre1, apellido1, rut1, edad1,cargo1);

            personas.Add(persona1);
        }

        public string getnombre()
        {
            return nombre;
        }

        public string getapellido()
        {
            return apellido1;
        }
        public string getrut()
        {
            return rut1;
        }
        public int getedad()
        {
            return edad1;
        }
        public string getcargo()
        {
            return cargo1;
        }
        public string getinfo()
        {
            return "nombre: " + nombre + " apellido: " + apellido + " edad: " + edad + " rut: " + rut + " cargo: " + cargo;
        }

    }
}
