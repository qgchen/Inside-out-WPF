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

namespace WpfApplication1
{
    /// <summary>
    /// Window6.xaml 的交互逻辑
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
  
  //         this.textBox1.SetBinding(TextBox.TextProperty, new Binding("/") { Source = st });
    //       this.textBox2.SetBinding(TextBox.TextProperty, new Binding("/[2]") { Source = st });
            Student st = new Student();
            st.Id = 1;
            st.Age = 55;
            st.Name = "chrisDarren";

            Binding bind = new Binding();
            bind.Source = st;
            bind.Path = new PropertyPath("Name");
            this.textBox2.SetBinding(TextBox.TextProperty, bind);

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
          //  st.Name += "f";
           // new Window6().Show();
        }
    }

  public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int Property
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }

      
}
