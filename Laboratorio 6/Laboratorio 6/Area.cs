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
    class Area:Division
    {
        string nombre,encargado1;
        public Area(string anombre, string aencargado)
        {
            encargado1 = aencargado;
            nombre = anombre;
        }

        public string getinfo()
        {
            return "area: " + nombre + " encargado: "+ encargado1;
        }
    }
}
