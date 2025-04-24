namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAccount = new BankAccount();
            bankAccount.Owner = "Hugoat";
            bankAccount.AccountNumber = Guid.NewGuid();
            bankAccount.Balance = 1000;

            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.Owner = "Proutman";
            bankAccount2.AccountNumber = Guid.NewGuid();
            bankAccount2.Balance = 350;

            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.Owner = "Test";
            bankAccount3.AccountNumber = Guid.NewGuid();
            bankAccount3.Balance = 400;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount2);
            bankAccounts.Add(bankAccount3);

            BankAccountsGrid.DataSource = bankAccounts;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
