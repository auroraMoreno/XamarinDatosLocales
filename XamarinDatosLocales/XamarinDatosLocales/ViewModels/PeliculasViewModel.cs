using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinDatosLocales.Base;
using XamarinDatosLocales.Models;
using XamarinDatosLocales.Repository;
using XamarinDatosLocales.Views;

namespace XamarinDatosLocales.ViewModels
{
    public class PeliculasViewModel : ViewModelBase
    {
        RepositoryPeliculas repository;
        public PeliculasViewModel()
        {
            this.repository = new RepositoryPeliculas();
            List<Pelicula> pelis = this.repository.GetPeliculas();
            this.Peliculas = new ObservableCollection<Pelicula>(pelis);
        }

        private ObservableCollection<Pelicula> _Peliculas;
        public ObservableCollection<Pelicula> Peliculas 
        {
            get { return this._Peliculas; }
            set
            {
                this._Peliculas = value;
                OnPropertyChanged("Peliculas");
            }
        }

        private Pelicula _PeliculaSeleccionada;
        public Pelicula PeliculaSeleccionda
        {
            get { return this._PeliculaSeleccionada; }
            set
            {
                this._PeliculaSeleccionada = value;
                OnPropertyChanged("PeliculaSeleccionada");
            }
        } 

        public Command ShowEscenas
        {
            get
            {
                return new Command(() =>
                {
                    PeliculaViewModel vm = new PeliculaViewModel();
                    vm.Pelicula = this.PeliculaSeleccionda;
                    EscenasView view = new EscenasView();
                    view.BindingContext = vm;
                    Application.Current.MainPage.Navigation.PushAsync(view);
                });
            }
        }
    }
}
