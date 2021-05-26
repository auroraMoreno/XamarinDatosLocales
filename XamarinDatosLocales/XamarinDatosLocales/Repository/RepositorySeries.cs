using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinDatosLocales.Helpers;
using XamarinDatosLocales.Models;

namespace XamarinDatosLocales.Repository
{
    public class RepositorySeries
    {
        HelperFile helper;
        public RepositorySeries()
        {
            this.helper = new HelperFile();
        }

        public List<Serie> GetSeries()
        {
            String resourse = "XamarinDatosLocales.Documents.series.json";
            String data = this.helper.ReadFile(resourse);
            List<Serie> series = JsonConvert.DeserializeObject<List<Serie>>(data);
            return series;
        }
    }
}
