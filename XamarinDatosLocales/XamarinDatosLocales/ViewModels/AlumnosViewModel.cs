using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinDatosLocales.Models;
using XamarinDatosLocales.Repository;

namespace XamarinDatosLocales.ViewModels
{
    public class AlumnosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public RepositoryAlumnos repo;
        public void RaisePropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private String _Dato;
        public String Datos
        {
            get { return this._Dato; }
            set
            {
                this._Dato = value;
                RaisePropertyChanged("Dato");
            }
        }

        private List<Alumno> _Alumnos;
        public List<Alumno> Alumnos
        {
            get { return this._Alumnos; }
            set
            {
                this._Alumnos = value;
                RaisePropertyChanged("Alumnos");
            }
        }

        private List<Alumno> MostrarAlumnos()
        {
            List<Alumno> alumnos = this.repo.GetAlumnos();
            return alumnos;
        }

        public Command MostrarDatos
        {
            get
            {
                return new Command(() =>
                {
                    this.Alumnos = MostrarAlumnos();
                });
            }
        }
    }
}
