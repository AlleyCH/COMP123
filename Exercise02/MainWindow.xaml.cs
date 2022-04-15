using Exercise02.Models;
using Exercise02.Utilities;
using System;
using System.Windows;
using System.Windows.Controls;

/*
 
 	Implement a desktop application for a bank.

	The application should allow users to create accounts, as well as transactions (credit or debit) against those accounts.

	PART 1: DOMAIN:
	- Implement classes that allows for the proper maintenance of the relevant entities for the context of this application. 

	PART 2: UI:
	- Implement a user interface that allows users to create accounts.

	PART 3: IMPLEMENTATION:
	- Implement the required functionality. Use XML serialization for data persistence.
 
*/

namespace Exercise02 {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		private Account selectedAccount;

		public MainWindow() {
			InitializeComponent();
			this.InitializeUI();
		}

		// Event Handler Methods.
		private void OnResetAccountForm(object sender, EventArgs e) {
			txtAccountNumber.Text = this.GenerateAccountNumber();
			comboAccountType.SelectedItem = null;
			txtFirstName.Text = null;
			txtLastName.Text = null;
			dateDOB.SelectedDate = null;
			txtAddressLine1.Text = null;
			txtAddressLine2.Text = null;
			txtCity.Text = null;
			txtProvince.Text = null;
			txtPostalCode.Text = null;
		}

		private void OnCreateAccount(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(txtAccountNumber.Text) ||
				comboAccountType.SelectedItem == null ||
				string.IsNullOrWhiteSpace(txtFirstName.Text) ||
				string.IsNullOrWhiteSpace(txtLastName.Text) ||
				dateDOB.SelectedDate == null ||
				string.IsNullOrWhiteSpace(txtAddressLine1.Text) ||
				string.IsNullOrWhiteSpace(txtCity.Text) ||
				string.IsNullOrWhiteSpace(txtProvince.Text) ||
				string.IsNullOrWhiteSpace(txtPostalCode.Text)) {
				MessageBox.Show("Please input all needed values before creating the new account.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			else {
				Account account = new Account();
				account.AccountNumber = txtAccountNumber.Text;
				account.Customer = new Customer();
				account.Customer.FirstName = txtFirstName.Text;
				account.Customer.LastName = txtLastName.Text;
				account.Customer.DateOfBirth = dateDOB.SelectedDate;
				account.Customer.Address = new Address();
				account.Customer.Address.AddressLine1 = txtAddressLine1.Text;
				account.Customer.Address.AddressLine2 = txtAddressLine2.Text;
				account.Customer.Address.City = txtCity.Text;
				account.Customer.Address.Province = txtProvince.Text;
				account.Customer.Address.PostalCode = txtPostalCode.Text;

				if (((ComboBoxItem)comboAccountType.SelectedItem).Content.ToString() == "Checking")
					account.Type = Account.AccountType.Checking;
				else if (((ComboBoxItem)comboAccountType.SelectedItem).Content.ToString() == "Savings")
					account.Type = Account.AccountType.Savings;
				else
					account.Type = Account.AccountType.Investment;

				try {
					AccountService.Create(account);
					this.OnResetAccountForm(sender, e);

					dataAccounts.ItemsSource = null;
					dataAccounts.ItemsSource = AccountService.GetAll();

					MessageBox.Show("Account successfully created!", "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
		}

		private void OnResetTransactionForm(object sender, RoutedEventArgs e) {
			txtTransactionAmount.Text = null;
			comboTransactionType.SelectedItem = null;
		}

		private void OnCreateTransaction(object sender, RoutedEventArgs e) {
			if (selectedAccount == null) {
				MessageBox.Show("Please select an account before creating the new transaction.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			else if (string.IsNullOrWhiteSpace(txtTransactionAmount.Text) || comboTransactionType.SelectedItem == null) {
				MessageBox.Show("Please input all needed values before creating the new transaction.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
			} 
			else {
				double value;

				try {
					 value = double.Parse(txtTransactionAmount.Text);
				}
				catch {
					MessageBox.Show("Transaction amount must be a positive numeric value.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);

					return;
				}

				if (value < 0) {
					MessageBox.Show("Transaction amount cannot be negative.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
					
					return;
				}

				Transaction transaction = new Transaction();
				transaction.Value = double.Parse(txtTransactionAmount.Text);

				if (((ComboBoxItem)comboTransactionType.SelectedItem).Content.ToString() == "Credit") {
					transaction.Type = Transaction.TransactionType.Credit;
				}
				else {
					transaction.Type = Transaction.TransactionType.Credit;
				}

				selectedAccount.Transactions.Add(transaction);

				try {
					AccountService.Update(selectedAccount);
					this.OnResetTransactionForm(sender, e);

					dataTransactions.ItemsSource = null;
					dataTransactions.ItemsSource = selectedAccount.Transactions;

					dataAccounts.ItemsSource = null;
					dataAccounts.ItemsSource = AccountService.GetAll();
					dataAccounts.SelectedItem = selectedAccount;

					MessageBox.Show("Transaction successfully created!", "Success!", MessageBoxButton.OK, MessageBoxImage.Information);
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
		}

		private void OnSelectAccount(object sender, SelectionChangedEventArgs e) {
			this.selectedAccount = ((DataGrid)sender).SelectedItem as Account;

			if (this.selectedAccount == null)
				return;

			txtSelectedAccountNumber.Text = this.selectedAccount.AccountNumber;
			txtSelectedAccountType.Text = this.selectedAccount.Type.ToString();
			txtSelectedFirstName.Text = this.selectedAccount.Customer.FirstName;
			txtSelectedLastName.Text = this.selectedAccount.Customer.LastName;
			dateSelectedDOB.SelectedDate = this.selectedAccount.Customer.DateOfBirth;
			txtSelectedAddressLine1.Text = this.selectedAccount.Customer.Address.AddressLine1;
			txtSelectedAddressLine2.Text = this.selectedAccount.Customer.Address.AddressLine2;
			txtSelectedCity.Text = this.selectedAccount.Customer.Address.City;
			txtSelectedProvince.Text = this.selectedAccount.Customer.Address.Province;
			txtSelectedBalance.Text = this.selectedAccount.Balance.ToString("C");
			txtTransactionAmount.Text = null;
			comboTransactionType.SelectedItem = null;
			dataTransactions.ItemsSource = this.selectedAccount.Transactions;
		}

		// Helper Methods.
		private void InitializeUI() {
			// Installing event handlers.
			btnCreateAccount.Click += OnCreateAccount;
			btnCreateTransaction.Click += OnCreateTransaction;
			btnResetAccountForm.Click += OnResetAccountForm;
			btnResetTransactionForm.Click += OnResetTransactionForm;
			dataAccounts.SelectionChanged += OnSelectAccount;

			// Misc.
			txtAccountNumber.Text = this.GenerateAccountNumber();
			dataAccounts.ItemsSource = AccountService.GetAll();
		}

		private string GenerateAccountNumber() {
			return new Random().Next(1000000, 9999999).ToString();
		}

		private void OnGenerateAccountColumns(object sender, EventArgs e) {
			foreach (var column in ((DataGrid)sender).Columns) {
				column.MinWidth = 118.5;

				if (column.Header.ToString() == "AccountID") {
					column.Visibility = Visibility.Hidden;
				}
				else if (column.Header.ToString() == "AccountNumber") {
					column.Header = "Account Number";
				}
				else if (column.Header.ToString() == "Transactions") {
					column.Visibility = Visibility.Hidden;
				}
			}
		}

		private void OnGenerateTransactionColumns(object sender, EventArgs e) {
			foreach (var column in ((DataGrid)sender).Columns) {
				column.MinWidth = 158;

				if (column.Header.ToString() == "TransactionID") {
					column.Visibility = Visibility.Hidden;
				}
				//else if (column.Header.ToString() == "AccountNumber") {
				//	column.Header = "Account Number";
				//}
				//else if (column.Header.ToString() == "Transactions") {
				//	column.Visibility = Visibility.Hidden;
				//}
			}
		}
	}
}
