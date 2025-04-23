namespace BankAccountsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            AmountOwner = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            WithdrawBtn = new Button();
            DepositBtn = new Button();
            CreateAccountBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(120, 45);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 327);
            label2.Name = "label2";
            label2.Size = new Size(142, 45);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            label2.Click += label2_Click;
            // 
            // AmountOwner
            // 
            AmountOwner.Location = new Point(156, 41);
            AmountOwner.Name = "AmountOwner";
            AmountOwner.Size = new Size(253, 31);
            AmountOwner.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(178, 341);
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(180, 31);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(448, 42);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 62;
            BankAccountsGrid.Size = new Size(743, 290);
            BankAccountsGrid.TabIndex = 4;
            BankAccountsGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(847, 359);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(344, 63);
            WithdrawBtn.TabIndex = 7;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(448, 359);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(344, 63);
            DepositBtn.TabIndex = 8;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(156, 94);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(253, 63);
            CreateAccountBtn.TabIndex = 9;
            CreateAccountBtn.Text = "Create";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 450);
            Controls.Add(CreateAccountBtn);
            Controls.Add(DepositBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(AmountOwner);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox AmountOwner;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button WithdrawBtn;
        private Button DepositBtn;
        private Button CreateAccountBtn;
    }
}
