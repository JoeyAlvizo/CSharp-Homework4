using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Homework4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            uxSubmit.IsEnabled = false;
        }
        private void keyUpEvent(object sender, KeyEventArgs e)
        {
            String uSPattern = @"^\d{5}(?:-?\d{4})?$";
            String canadaPattern = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
            Regex uSRx = new Regex(uSPattern);
            Regex canadaRx = new Regex(canadaPattern);
            bool uS = uSRx.IsMatch(uxZipCode.Text);
            bool canada = canadaRx.IsMatch(uxZipCode.Text);
            uxSubmit.IsEnabled = uS || canada;
        }
    }
}
