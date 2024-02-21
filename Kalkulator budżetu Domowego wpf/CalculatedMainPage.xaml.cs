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
using System.Windows.Shapes;

namespace Kalkulator_budżetu_Domowego_wpf
{
    /// <summary>
    /// Interaction logic for CalculatedMainPage.xaml
    /// </summary>
    public partial class CalculatedMainPage : Window
    {
      
        public CalculatedMainPage()
        {
            InitializeComponent();



        }

        private void calculateHomeBudget(object sender, RoutedEventArgs e)
        {


        }


        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string incomeA = incomeTextBox.Text;
            string incomeB = incomeTextBoxB.Text;
            string expensesA = expensesTextBoxA.Text;
            string expensesB = expensesTextBoxB.Text;
            string expensesB2 = expensesTextBoxB2.Text;

          
        }

    }
}
