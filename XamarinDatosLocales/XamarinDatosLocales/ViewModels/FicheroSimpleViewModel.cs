using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinDatosLocales.Helpers;

namespace XamarinDatosLocales.ViewModels
{
    public class FicheroSimpleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private String _Data;
        public String Data
        {
            get { return this._Data; }
            set
            {
                this._Data = value;
                OnPropertyChanged("Data");
            }
        }

        public Command ReadFile
        {
            get
            {
                return new Command(() =>
                {
                    HelperFile helper = new HelperFile();
                    this.Data = helper.ReadFile("XamarinDatosLocales.Documents.prueba.txt");
                });
            }
        }
    }
}
