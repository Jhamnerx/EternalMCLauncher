using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EternalMCLauncher.Models
{
    public class Datos
    {
        public bool Production { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Titulo { get; set; }

        public Imagenes Imagenes { get; set; } 
        public Redes Redes { get; set; }
    }
}
