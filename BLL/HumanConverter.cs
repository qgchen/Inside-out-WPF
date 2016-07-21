using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.ComponentModel;

namespace WpfApplication1.BLL
{
    public class StringToHumanTypeConverter : TypeConverter
    {

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if (value is string)
            {
                Human0 h = new Human0();
                h.Name = value as string;
                    return h;

            }
            return base.ConvertFrom(context,culture,value);
        }

   
    }
}
