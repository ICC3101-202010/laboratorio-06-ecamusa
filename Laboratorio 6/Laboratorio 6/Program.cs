using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Laboratorio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice, respuesta, respuesta2, nempresa, rutempresa,ndepartamento,nseccion,narea,nbloque;
            string aenc, denc, senc, benc;
            Division cuchufli = new Division();
            respuesta = "si";
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Quiere utilizar un archivo para cargar la informacion de su empresa?");
            choice = Console.ReadLine();
            if (choice == "no")
            {
                Empresa.Creararchivo();
                while (respuesta != "no")
                {
                    Console.WriteLine("ingrese nombre de la empresa: ");
                    nempresa = Console.ReadLine();
                    Console.WriteLine("ingrese rut de la empresa");
                    rutempresa = Console.ReadLine();
                    Console.WriteLine("ingrese nombre del area:");
                    narea= Console.ReadLine();
                    aenc=cuchufli.encargado();
                    Console.WriteLine("ingrese nombre del departamento:");
                    ndepartamento = Console.ReadLine();
                    denc=cuchufli.encargado();
                    Console.WriteLine("ingrese nombre de la seccion:");
                    nseccion = Console.ReadLine();
                    senc=cuchufli.encargado();
                    Console.WriteLine("ingrese nombre del bloque:");
                    nbloque = Console.ReadLine();
                    benc=cuchufli.encargado();
                    Empresa empresa1 = new Empresa(nempresa, rutempresa);
                    Area area1 = new Area(narea, aenc);
                    Departamento depto1 = new Departamento(ndepartamento, denc);
                    Seccion seccion1 = new Seccion(nseccion, senc);
                    Bloque bloque1 = new Bloque(nbloque, benc);

                    empresa1.addempresa(empresa1,area1,depto1,seccion1,bloque1);
                    Console.WriteLine("desea agregar otra empresa?");
                    respuesta2 = Console.ReadLine();
                    if (respuesta2 == "no")
                    {
                        empresa1.saveempresa();
                        respuesta = "no";
                    }
                }
                Empresa.readempresa();
                Console.ReadLine();


            }
            if (choice == "si")
            {
                Empresa.readempresa();
                Console.ReadLine();
            }

           


        }
    }
}
