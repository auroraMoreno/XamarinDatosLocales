using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDatosLocales.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FicheroSimpleView : ContentPage
    {
        public FicheroSimpleView()
        {
            InitializeComponent();
            //this.btnleer.Clicked += Btnleer_Clicked;
        }

        //private void Btnleer_Clicked(object sender, EventArgs e)
        //{
        //    //var assembly =
        //    //    IntrospectionExtensions.GetTypeInfo(typeof(FicheroSimpleView)).Assembly;
        //    //String namespaces = "XamarinDatosLocales.Documents.prueba.txt";
        //    //Stream stream = assembly.GetManifestResourceStream(namespaces);
        //    //using (StreamReader reader = new StreamReader(stream))
        //    //{
        //    //    String datos = reader.ReadToEnd();
        //    //    this.lblDatos.Text = datos;
        //    //}
        //}
    }
}