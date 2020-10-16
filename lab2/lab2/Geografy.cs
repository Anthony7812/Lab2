using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace lab2
{
    public class Geografy
    {
        private string urlGeografia;

        public string obtenerGeografia(int tipo, int provincia = 1)
        {
            if (tipo == 1)
            {
                urlGeografia = "https://ubicaciones.paginasweb.cr/provincias.json";
            }
            if (tipo == 2)
            {
                urlGeografia = "https://ubicaciones.paginasweb.cr/provincia/" + provincia + "/cantones.json";
            }

            WebRequest request = WebRequest.Create(this.urlGeografia);
            WebResponse response = request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            return streamReader.ReadToEnd().ToString();
        }
    }
}
