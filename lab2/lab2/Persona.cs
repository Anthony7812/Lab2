using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Persona
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string provincia { get; set; }
        public string canton { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int edad { get; set; }
        public List<int> telefonos{ get; set; }
        public string estado { get; set; }

        public Persona(string cedula, string nombre, string apellido1, string apellido2, string provincia, string canton, DateTime fechaNacimiento, int edad, List<int> telefonos, string estado)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.provincia = provincia;
            this.canton = canton;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = edad;
            this.telefonos = telefonos;
            this.estado = estado;
        }

        public Persona()
        {

        }
        public int calculaEdad()
        {
            int annio = DateTime.Now.Year - fechaNacimiento.Year;
            int mes = DateTime.Now.Month - fechaNacimiento.Year;
            if(mes < 0)
            {
                return annio - 1;
            }
            return annio;
        }

    }
}
