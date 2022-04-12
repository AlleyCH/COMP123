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
		public MainWindow() {
			InitializeComponent();
			this.InitializeUI();
		}

		private void InitializeUI() {
			// Initialize event listeners.
			btnResetAccounts.Click += OnResetAccounts;
			btnCreateAccount.Click += OnCreateAccount;

			// Misc.
			txtAccountNumber.Text = this.GenerateAccountNumber();
			dataAccounts.ItemsSource = AccountService.GetAll();
		}

		// Event Handler Methods.
		private void OnResetAccounts(object sender, EventArgs e) {
			txtAccountNumber.Text = null;
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
				MessageBox.Show("Please input all fields before creating the new account.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
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

				//account.Type = comboAccountType.SelectedItem.ToString() == "Checking" ? Account.AccountType.Checking : (comboAccountType.SelectedItem.ToString() == "Savings" ? Account.AccountType.Savings : Account.AccountType.Investment);

				if (((ComboBoxItem)comboAccountType.SelectedItem).Content.ToString() == "Checking")
					account.Type = Account.AccountType.Checking;
				else if (((ComboBoxItem)comboAccountType.SelectedItem).Content.ToString() == "Savings")
					account.Type = Account.AccountType.Savings;
				else 
					account.Type = Account.AccountType.Investment;

				try {
					AccountService.Create(account);

					dataAccounts.ItemsSource = null;
					dataAccounts.ItemsSource = AccountService.GetAll();
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
		}

		// Helper Methods.
		private string GenerateAccountNumber() {
			return new Random().Next(1000000, 9999999).ToString();
		}
	}
}
