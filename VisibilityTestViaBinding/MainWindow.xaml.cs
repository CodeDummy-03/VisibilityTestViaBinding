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

namespace VisibilityTestViaBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 2;
        ViewModel ob = new ViewModel();
        public MainWindow()
        {
            this.DataContext = ob;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(count%2==0)
                ob.TextblockVisibility = Visibility.Collapsed;
            else
                ob.TextblockVisibility = Visibility.Visible;
            count++;
        }
    }
}
