using System;
using System.Globalization;

namespace MAUIFlextLayout
{
    public class StringToReverseBoolConverter : IValueConverter
    {
        public StringToReverseBoolConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string val = (string)value;

            if (!string.IsNullOrEmpty(val))
            {
                if (val.Length > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !((bool)value);
        }
    }
}

