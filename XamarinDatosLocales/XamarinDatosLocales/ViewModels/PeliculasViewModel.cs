using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinDatosLocales.Base;
using XamarinDatosLocales.Models;
using XamarinDatosLocales.Repository;

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
    }
}
