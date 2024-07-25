﻿using System;
using System.Windows.Data;

namespace Eclipse.Converters
{
    // shifts the game video and bezel up 1/2 way when displaying feature
    public class DisplayingFeatureVideoOffsetConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool isFeature = (bool)values[0];
            bool isMoreInfo = (bool)values[1];
            double offsetAmount = (double)values[2];

            if (isMoreInfo) return 0;
            if (isFeature) return -1 * offsetAmount/6.0;
            return 0;
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException("Going back is not supported");
        }
    }

}
