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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2.Page
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : System.Windows.Controls.Page
    {
        public Page1()
        {
            InitializeComponent();
  
            //button1.Click += new RoutedEventHandler(MyButton_Click);

            riceType.MouseDown += new MouseButtonEventHandler(showPopUp);
            riceVariety.MouseDown += new MouseButtonEventHandler(showPopUp);
            preprocessing.MouseDown += new MouseButtonEventHandler(showPopUp);
            capacity.MouseDown += new MouseButtonEventHandler(showPopUp);
        }

        void MyButton_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("HandleEvent");
            if (popup.IsOpen == false)
            {
                popup.IsOpen = true;
            }
            else
            {
                popup.IsOpen = false;
            }
        }

        public void showPopUp(object sender, RoutedEventArgs e)
        {
            if (popup.IsOpen == false)
            {
                popup.IsOpen = true;
            }
            else
            {
                popup.IsOpen = false;
            }
        }
     }
}
