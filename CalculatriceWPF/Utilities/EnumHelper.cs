using CalculatriceWPF.Enumeration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace CalculatriceWPF.Utilities
{
    /// <summary>
    /// Classe qui permet d'afficher les enums dans des combobox
    /// </summary>
    public class EnumHelper : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is MorpionDifficultiesEnum enumValue)
            {
                // Transformez votre énumération en chaîne comme vous le souhaitez
                switch (enumValue)
                {
                    case MorpionDifficultiesEnum.FACILE:
                        return "Facile";
                    case MorpionDifficultiesEnum.MOYEN:
                        return "Moyen";
                    default: 
                        return "Difficile";
                }
            }
            return "Facile";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public EnumHelper() { }
    }
}
