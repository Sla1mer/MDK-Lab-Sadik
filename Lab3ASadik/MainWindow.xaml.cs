using Lab3ASadik.Models;
using System.Collections.ObjectModel;
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

namespace Lab3ASadik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Account> Accounts { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Accounts = new List<Account>();
            accountsDataGrid.ItemsSource = Accounts;
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {
            Account newAccount = new Account(txtSurname.Text, int.Parse(txtAccountNumber.Text),
                                              double.Parse(txtAccrualCent.Text), double.Parse(txtBalance.Text), Date.Today());

            Accounts.Add(newAccount);
            accountsDataGrid.Items.Refresh();
        }

        private void Deposit_Click(object sender, RoutedEventArgs e)
        {
            Account selectedAccount = accountsDataGrid.SelectedItem as Account;
            if (selectedAccount != null)
            {
                selectedAccount.Deposit(100); // Внести 100
                accountsDataGrid.Items.Refresh();
            }

        }

        private void Withdraw_Click(object sender, RoutedEventArgs e)
        {
            Account selectedAccount = accountsDataGrid.SelectedItem as Account;
            if (selectedAccount != null)
            {
                selectedAccount.Withdraw(50); // Снять 50
                accountsDataGrid.Items.Refresh();
            }
        }

        private void AccrueInterest_Click(object sender, RoutedEventArgs e)
        {
            Account selectedAccount = accountsDataGrid.SelectedItem as Account;
            if (selectedAccount != null)
            {
                selectedAccount.AccrueInterest();
                accountsDataGrid.Items.Refresh();
            }
        }

        private void To_Dollar_Click(object sender, RoutedEventArgs e)
        {
            Account selectedAccount = accountsDataGrid.SelectedItem as Account;
            if (selectedAccount != null)
            {
                MessageBox.Show($"Ваш баланс в долларах: {selectedAccount.ConvertToDollars(91.38):F2}");
            }
        }

        private void To_Euro_Click(object sender, RoutedEventArgs e)
        {
            Account selectedAccount = accountsDataGrid.SelectedItem as Account;
            if (selectedAccount != null)
            {
                MessageBox.Show($"Ваш баланс в евро: {selectedAccount.ConvertToEuros(98.68):F2}");
            }
        }

        private void Change_Owner_Click(object sender, RoutedEventArgs e)
        {
            Account selectedAccount = accountsDataGrid.SelectedItem as Account;
            if (selectedAccount != null)
            {
                selectedAccount.ChangeOwner(txtSurname.Text);
                accountsDataGrid.Items.Refresh();
            }
        }

        private void Add_Procent_Click(object sender, RoutedEventArgs e)
        {
            Account selectedAccount = accountsDataGrid.SelectedItem as Account;
            if (selectedAccount != null)
            {
                selectedAccount.AccrueInterest();
                accountsDataGrid.Items.Refresh();
            }
        }
    }
}