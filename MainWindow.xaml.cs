using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 p2 = new Window1();
            p2.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(A.Text);
            int b = Int32.Parse(B.Text);
            int c = a + b;
            string d = c.ToString();
            Diff_de_temp.Text = d;
            
            if (Diff_de_temp.Visibility == Visibility.Collapsed)
                Montrer();
            else
                Diff_de_temp.Visibility = Visibility.Collapsed;
         
        }

        private void Montrer()
        {
            Diff_de_temp.Visibility = Visibility.Visible;
        }

      

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Degre.Visibility = Visibility.Visible;
            repDegre.Visibility = Visibility.Visible;
        }

        private void CheckBox_unChecked(object sender, RoutedEventArgs e)
        {
            Degre.Visibility = Visibility.Collapsed;
            repDegre.Visibility = Visibility.Collapsed;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }
}
