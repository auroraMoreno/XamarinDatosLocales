using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinDatosLocales.Models
{
    public class Serie
    {
        [JsonProperty("idserie")]
        public int IdSerie { get; set; }
        [JsonProperty("nombre")]
        public String Nombre { get; set; }
        [JsonProperty("imagen")]
        public String Imagen { get; set; }
        [JsonProperty("valoracion")]
        public int Valoracion { get; set; }
    }
}
