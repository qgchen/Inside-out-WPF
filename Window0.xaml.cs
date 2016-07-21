using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.ComponentModel;
using WpfApplication1.BLL;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window0.xaml
    /// </summary>
    public partial class Window0 : Window
    {
        public Window0()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Human0 h = (Human0)this.FindResource("human");
            MessageBox.Show(h.Child.Name);
        }
    }
       [TypeConverterAttribute(typeof(StringToHumanTypeConverter))]
    public class Human0
    {
        public string Name { set; get; }
        public Human0 Child { set; get; }
    }
}
