using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace lab2
{
    class LogGeografia
    {
        Geografy geografia = new Geografy();
        List<Geografia> lstProvincia = new List<Geografia>();
        List<Geografia> lstCanton = new List<Geografia>();

        public List<Geografia> listadoProvincia(int tipo, int provincia = 1)
        {
            lstProvincia.Clear();
            String respuesta = geografia.obtenerGeografia(tipo, provincia);
            var dicProvincias = JsonConvert.DeserializeObject<Dictionary<string, string>>(respuesta);


            foreach (var dp in dicProvincias)
            {
                lstProvincia.Add(new Geografia(dp.Key, dp.Value));
            }
            return lstProvincia;
        }

        public List<Geografia> listadoCanton(int tipo, int provincia = 1)
        {
            lstCanton.Clear();
            String respuesta = geografia.obtenerGeografia(tipo, provincia);
            var dicCanton = JsonConvert.DeserializeObject<Dictionary<string, string>>(respuesta);


            foreach (var dc in dicCanton)
            {
                lstCanton.Add(new Geografia(dc.Key, dc.Value));
            }
            return lstCanton;
        }
    }
}
