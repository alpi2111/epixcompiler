using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpixCompilerIDE
{
    class Procesos
    {

        private bool isSave;
        private String ruta;

        public bool IsSave { get => isSave; set => isSave = value; }
        public string Ruta { get => ruta; set => ruta = value; }

        public Procesos()
        {
            IsSave = false;
            Ruta = "";
        }
    }
}
