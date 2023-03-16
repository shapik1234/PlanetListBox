using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.Globalization;

namespace PlanetsListBox
{
	public class ConvertOrbit : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double orbit = (double)value;
            double factor = System.Convert.ToDouble(parameter, culture.NumberFormat);
			return Math.Pow(orbit / 40, 0.4) * 770 * factor;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException("This method should never be called");
		}
	}
}
