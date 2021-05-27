using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDatosLocales.Models;
using XamarinDatosLocales.ViewModels;

namespace XamarinDatosLocales.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeliculasView : ContentPage
    {
        public PeliculasView()
        {
            InitializeComponent();
            this.listviewpelicula.ItemSelected += Lstviewpeliculas_ItemSelected;
        }

        private void Lstviewpeliculas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Pelicula peliseleccionada = e.SelectedItem as Pelicula;
            PeliculaViewModel viewModel = new PeliculaViewModel();
            EscenasView view = new EscenasView();
            viewModel.Pelicula = peliseleccionada;
            view.BindingContext = viewModel;
            Navigation.PushModalAsync(view);
        }
    }
}