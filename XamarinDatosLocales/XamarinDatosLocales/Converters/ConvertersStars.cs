using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinDatosLocales.Converters
{
    public class ConvertersStars : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int valoracion = (int)value;
            if (valoracion == 1)
            {
                return "star1.png";
            }else if (valoracion == 2)
            {
                return "star2.png";
            }else if (valoracion==3)
            {
                return "star3.png";
            }else if (valoracion==4)
            {
                return "star4.png";
            }
            else
            {
                return "star5.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
