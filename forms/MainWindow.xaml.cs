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

namespace ZulrahRotations
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

        private void zul_rotation_a_Click(object sender, RoutedEventArgs e)
        {
            

            if(zul_rotation_b.Visibility == Visibility.Hidden)
            {
                resetVisib();
                
            } else
            {
                zul_rotation_a.SetValue(Grid.ColumnSpanProperty, 4);

                zul_rotation_b.Visibility = Visibility.Hidden;
                zul_rotation_c.Visibility = Visibility.Hidden;
                zul_rotation_d.Visibility = Visibility.Hidden;
            }
        }

        private void zul_rotation_b_Click(object sender, RoutedEventArgs e)
        {
            

            if (zul_rotation_a.Visibility == Visibility.Hidden)
            {
                resetVisib();
            }
            else
            {
                zul_rotation_b.SetValue(Grid.ColumnProperty, 0);
                zul_rotation_b.SetValue(Grid.ColumnSpanProperty, 4);

                zul_rotation_a.Visibility = Visibility.Hidden;
                zul_rotation_c.Visibility = Visibility.Hidden;
                zul_rotation_d.Visibility = Visibility.Hidden;
            }
        }

        private void zul_rotation_c_Click(object sender, RoutedEventArgs e)
        {
            

            if (zul_rotation_b.Visibility == Visibility.Hidden)
            {
                resetVisib();
            }
            else
            {
                zul_rotation_c.SetValue(Grid.ColumnProperty, 0);
                zul_rotation_c.SetValue(Grid.ColumnSpanProperty, 4);

                zul_rotation_a.Visibility = Visibility.Hidden;
                zul_rotation_b.Visibility = Visibility.Hidden;
                zul_rotation_d.Visibility = Visibility.Hidden;
            }
        }

        private void zul_rotation_d_Click(object sender, RoutedEventArgs e)
        {
            

            if (zul_rotation_c.Visibility == Visibility.Hidden)
            {
                resetVisib();
            }
            else
            {
                zul_rotation_d.SetValue(Grid.ColumnProperty, 0);
                zul_rotation_d.SetValue(Grid.ColumnSpanProperty, 4);

                zul_rotation_a.Visibility = Visibility.Hidden;
                zul_rotation_b.Visibility = Visibility.Hidden;
                zul_rotation_c.Visibility = Visibility.Hidden;
            }
        }

        private void reset_but_Click(object sender, RoutedEventArgs e)
        {
            resetVisib();
        }

        private void resetVisib()
        {
            zul_rotation_a.SetValue(Grid.ColumnSpanProperty, 1);
            zul_rotation_b.SetValue(Grid.ColumnSpanProperty, 1);
            zul_rotation_c.SetValue(Grid.ColumnSpanProperty, 1);
            zul_rotation_d.SetValue(Grid.ColumnSpanProperty, 1);


            zul_rotation_a.SetValue(Grid.ColumnProperty, 0);
            zul_rotation_b.SetValue(Grid.ColumnProperty, 1);
            zul_rotation_c.SetValue(Grid.ColumnProperty, 2);
            zul_rotation_d.SetValue(Grid.ColumnProperty, 3);

            zul_rotation_a.Visibility = Visibility.Visible;
            zul_rotation_b.Visibility = Visibility.Visible;
            zul_rotation_c.Visibility = Visibility.Visible;
            zul_rotation_d.Visibility = Visibility.Visible;
        }
    }
}
