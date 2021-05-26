using System;
using System.Collections.Generic;
using System.Text;
using XamarinDatosLocales.Base;
using XamarinDatosLocales.Models;

namespace XamarinDatosLocales.ViewModels
{
    public class PeliculaViewModel : ViewModelBase
    {
        private Pelicula _Pelicula;
        public Pelicula Pelicula
        {
            get { return this._Pelicula;}
            set
            {
                this._Pelicula = value;
                OnPropertyChanged("Pelicula");
            }
        }
    }
}
