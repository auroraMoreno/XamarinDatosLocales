using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinDatosLocales.Base;
using XamarinDatosLocales.Models;
using XamarinDatosLocales.Repository;

namespace XamarinDatosLocales.ViewModels
{
    public class SeriesViewModel : ViewModelBase
    {
        RepositorySeries repo;
        public SeriesViewModel()
        {
            this.repo = new RepositorySeries();
            List<Serie> lista = this.repo.GetSeries();
            this.Series = new ObservableCollection<Serie>(lista);
        }

        private ObservableCollection<Serie> _Series;
        public ObservableCollection<Serie> Series
        {
            get { return this._Series; }
            set
            {
                this._Series = value;
                OnPropertyChanged("Series");
            }

        }
    }
}
