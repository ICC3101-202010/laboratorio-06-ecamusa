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
    class Bloque:Division
    {

        string nombre,encargado1;
        public Bloque(string anombre, string aencargado)
        {
            nombre = anombre;
            encargado1 = aencargado;
        }

        public string getinfo()
        {
            return "bloque: " + nombre +" encargado: " + encargado1 ;
        }
    }
}
