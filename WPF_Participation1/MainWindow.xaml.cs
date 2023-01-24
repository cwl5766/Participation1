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

namespace WPF_Participation1
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string name = nametxt.Text;
            string dob1 = dobtxt.Text;
            DateTime dob = new DateTime();
            dob = Convert.ToDateTime(dob1);
            TimeSpan time = DateTime.Today - dob;
            int age = (time.Days)/365;
            MessageBox.Show($"Hello {name}, your age is {age}");

        }

        private void btn_MouseEnter(object sender, MouseEventArgs e)
        {
            window.Background = Brushes.Purple;
        }
    }
}
