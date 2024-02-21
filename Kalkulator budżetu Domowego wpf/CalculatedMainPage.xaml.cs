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
            int numberA = 0;
            Int32.TryParse(incomeA, out numberA);
            string incomeB = incomeTextBoxB.Text;
            int numberB = 0;
            Int32.TryParse(incomeB, out numberB);
            string expensesA = expensesTextBoxA.Text;
            int expensesANumber = 0;
            Int32.TryParse(expensesA, out expensesANumber);
            string expensesB = expensesTextBoxB.Text;
            int expensesBNumber = 0;
            Int32.TryParse(expensesB, out expensesBNumber);
            string expensesB2 = expensesTextBoxB2.Text;
            int expensesB2Number = 0;
            Int32.TryParse(expensesB2, out expensesB2Number);

            int income = numberA + numberB;
            int expensesOverall = expensesANumber + expensesBNumber + expensesB2Number;
            int budgetOverall = income - expensesOverall;

            if(budgetOverall<0)
            {
                MessageBox.Show("Wydatki są większe od zarobków!", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else
            {
                overallIncome.Content = budgetOverall;
            }


        }

    }
}
