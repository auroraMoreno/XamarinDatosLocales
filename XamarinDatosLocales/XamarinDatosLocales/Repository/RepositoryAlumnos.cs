using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using XamarinDatosLocales.Helpers;
using XamarinDatosLocales.Models;

namespace XamarinDatosLocales.Repository
{
    public class RepositoryAlumnos
    {
        HelperFile helper;
        public RepositoryAlumnos()
        {
            this.helper = new HelperFile();
        }
        
        public List<Alumno> GetAlumnos()
        {
            String data = this.helper.ReadFile("XamarinDatosLocales.Documents.alumnos.xml");
            XDocument docxml = XDocument.Parse(data);
            var consulta = from datos in docxml.Descendants("alumno")
                           select new Alumno
                           {
                               IdAlumno=int.Parse(datos.Element("idalumno").Value),
                               Nombre=datos.Element("nombre").Value,
                               Apellidos=datos.Element("apellidos").Value,
                               Nota=int.Parse(datos.Element("nota").Value)
                           };
            return consulta.ToList();
        }
    }
}
