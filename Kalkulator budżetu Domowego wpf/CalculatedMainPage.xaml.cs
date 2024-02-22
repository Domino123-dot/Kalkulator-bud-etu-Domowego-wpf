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
            if (!decimal.TryParse(incomeTextBox.Text, out decimal value) || value < 0 ||
              !decimal.TryParse(incomeTextBoxB.Text, out decimal value2) || value2 < 0 ||
              !decimal.TryParse(expensesTextBoxA.Text, out decimal value3) || value3 < 0 ||
              !decimal.TryParse(expensesTextBoxB.Text, out decimal value4) || value4 < 0 ||
              !decimal.TryParse(expensesTextBoxB2.Text, out decimal value5) || value5 < 0)

            {

                MessageBox.Show("Wprowadziłeś liczbę ujemną, literę, lub nie wypełniłeś wszystkich rubryk, spróbuj ponownie", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Warning);
                incomeTextBox.Clear();
                incomeTextBoxB.Clear();
                expensesTextBoxA.Clear();
                expensesTextBoxB.Clear();
                expensesTextBoxB2.Clear();
                yourBudget.Content = null;
                yourExpenses.Content = null;
                yourSaldo.Content = null;

            }
            else
            {
                yourSaldo.Content = budgetOverall + "zł";
                yourBudget.Content = income + "zł";
                yourExpenses.Content = expensesOverall + "zł";
            }

            if (income < expensesOverall)
            {
                warningDisplay.Visibility = Visibility.Visible;
            }
            else
            {
                warningDisplay.Visibility = Visibility.Hidden;

            }

        }

        private void resetButtonClick(object sender, RoutedEventArgs e)
        {
            incomeTextBox.Text = String.Empty;
            incomeTextBoxB.Text = String.Empty;
            expensesTextBoxA.Text = String.Empty;
            expensesTextBoxB.Text = String.Empty;
            expensesTextBoxB2.Text = String.Empty;
            yourExpenses.Content = String.Empty;
            yourBudget.Content = String.Empty;
            yourSaldo.Content = String.Empty;
            warningDisplay.Visibility = Visibility.Hidden;

        }

    }
}