using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using XamarinDatosLocales.Helpers;
using XamarinDatosLocales.Models;

namespace XamarinDatosLocales.Repository
{
    public class RepositoryPeliculas
    {
        HelperFile helper;
        public RepositoryPeliculas()
        {
            this.helper = new HelperFile();
        }

        public List<Pelicula> GetPeliculas()
        {
            String data = this.helper.ReadFile("XamarinDatosLocales.Documents.EscenasPeliculas.xml");
            XDocument docxml = XDocument.Parse(data);
            var escenasxml = from datos in docxml.Descendants("pelicula").Descendants("escena")
                             select new Escena
                             {
                                 TituloEscena = datos.Element("tituloescena").Value,
                                 Descripcion = datos.Element("descripcion").Value,
                                 Imagen = datos.Element("imagen").Value
                             };
            List<Escena> escenas = escenasxml.ToList();
            var consulta = from datos in docxml.Descendants("pelicula")
                           select new Pelicula
                           {
                               Titulo = datos.Element("titulo").Value,
                               TituloOriginal = datos.Element("titulooriginal").Value,
                               Descripcion = datos.Element("descripcion").Value,
                               Poster = datos.Element("poster").Value,
                               Escenas = escenas
                           };
            return consulta.ToList();

        }
    }
}
