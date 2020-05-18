using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_6
{
    [Serializable()]
    class Division
    {
        string nombre,rut,apellido,cargo;
        int edad;

        public Division()
        {

        }

        public string encargado()
        {
            Console.WriteLine("ingrese nombre del encargado:");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese apellido del encargado:");
            apellido = Console.ReadLine();
            Console.WriteLine("ingrese rut del encargado:");
            rut = Console.ReadLine();
            Console.WriteLine("ingrese edad del encargado:");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese cargo del encargado:");
            cargo = Console.ReadLine();

            Persona persona1 = new Persona(nombre, apellido, rut, edad, cargo);
            return persona1.getinfo();

        }


    }
}
