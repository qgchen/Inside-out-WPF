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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window37_1.xaml
    /// </summary>
    public partial class Window37_1 : Window
    {
        public Window37_1()
        {
            InitializeComponent();
        }
    }

    public class Unit
    {
        public int Price { get; set;}
        public string Year { get; set; }


    }

}
