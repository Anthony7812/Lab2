using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Geografia
    {
        public string id { get; set; }
        public string nombre { get; set; }

        public Geografia(string id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
