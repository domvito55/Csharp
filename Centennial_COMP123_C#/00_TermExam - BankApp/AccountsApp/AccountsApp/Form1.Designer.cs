namespace AccountsApp
{
    partial class frmAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccounts));
            this.grpAccountDetails = new System.Windows.Forms.GroupBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDailyWithdrawLimit = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtDailyWithdrawLimit = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.grpTypeOfAccount = new System.Windows.Forms.GroupBox();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.rbtnSavings = new System.Windows.Forms.RadioButton();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpAccountDetails.SuspendLayout();
            this.grpTypeOfAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccountDetails
            // 
            this.grpAccountDetails.Controls.Add(this.grpTypeOfAccount);
            this.grpAccountDetails.Controls.Add(this.txtInterestRate);
            this.grpAccountDetails.Controls.Add(this.txtDailyWithdrawLimit);
            this.grpAccountDetails.Controls.Add(this.txtBalance);
            this.grpAccountDetails.Controls.Add(this.txtClientName);
            this.grpAccountDetails.Controls.Add(this.txtAccountNumber);
            this.grpAccountDetails.Controls.Add(this.lblInterestRate);
            this.grpAccountDetails.Controls.Add(this.lblDailyWithdrawLimit);
            this.grpAccountDetails.Controls.Add(this.lblBalance);
            this.grpAccountDetails.Controls.Add(this.lblClientName);
            this.grpAccountDetails.Controls.Add(this.lblAccountNumber);
            resources.ApplyResources(this.grpAccountDetails, "grpAccountDetails");
            this.grpAccountDetails.Name = "grpAccountDetails";
            this.grpAccountDetails.TabStop = false;
            // 
            // lblAccountNumber
            // 
            resources.ApplyResources(this.lblAccountNumber, "lblAccountNumber");
            this.lblAccountNumber.Name = "lblAccountNumber";
            // 
            // lblClientName
            // 
            resources.ApplyResources(this.lblClientName, "lblClientName");
            this.lblClientName.Name = "lblClientName";
            // 
            // lblBalance
            // 
            resources.ApplyResources(this.lblBalance, "lblBalance");
            this.lblBalance.Name = "lblBalance";
            // 
            // lblDailyWithdrawLimit
            // 
            resources.ApplyResources(this.lblDailyWithdrawLimit, "lblDailyWithdrawLimit");
            this.lblDailyWithdrawLimit.Name = "lblDailyWithdrawLimit";
            // 
            // lblInterestRate
            // 
            resources.ApplyResources(this.lblInterestRate, "lblInterestRate");
            this.lblInterestRate.Name = "lblInterestRate";
            // 
            // txtAccountNumber
            // 
            resources.ApplyResources(this.txtAccountNumber, "txtAccountNumber");
            this.txtAccountNumber.Name = "txtAccountNumber";
            // 
            // txtClientName
            // 
            resources.ApplyResources(this.txtClientName, "txtClientName");
            this.txtClientName.Name = "txtClientName";
            // 
            // txtBalance
            // 
            resources.ApplyResources(this.txtBalance, "txtBalance");
            this.txtBalance.Name = "txtBalance";
            // 
            // txtDailyWithdrawLimit
            // 
            resources.ApplyResources(this.txtDailyWithdrawLimit, "txtDailyWithdrawLimit");
            this.txtDailyWithdrawLimit.Name = "txtDailyWithdrawLimit";
            // 
            // txtInterestRate
            // 
            resources.ApplyResources(this.txtInterestRate, "txtInterestRate");
            this.txtInterestRate.Name = "txtInterestRate";
            // 
            // grpTypeOfAccount
            // 
            this.grpTypeOfAccount.Controls.Add(this.rbtnSavings);
            this.grpTypeOfAccount.Controls.Add(this.rbtnChecking);
            resources.ApplyResources(this.grpTypeOfAccount, "grpTypeOfAccount");
            this.grpTypeOfAccount.Name = "grpTypeOfAccount";
            this.grpTypeOfAccount.TabStop = false;
            // 
            // rbtnChecking
            // 
            resources.ApplyResources(this.rbtnChecking, "rbtnChecking");
            this.rbtnChecking.Checked = true;
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.TabStop = true;
            this.rbtnChecking.UseVisualStyleBackColor = true;
            this.rbtnChecking.CheckedChanged += new System.EventHandler(this.rbtnChecking_CheckedChanged);
            // 
            // rbtnSavings
            // 
            resources.ApplyResources(this.rbtnSavings, "rbtnSavings");
            this.rbtnSavings.Name = "rbtnSavings";
            this.rbtnSavings.UseVisualStyleBackColor = true;
            this.rbtnSavings.CheckedChanged += new System.EventHandler(this.rbtnSavings_CheckedChanged);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCreateAccount, "btnCreateAccount");
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmAccounts
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.grpAccountDetails);
            this.Name = "frmAccounts";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            this.grpAccountDetails.ResumeLayout(false);
            this.grpAccountDetails.PerformLayout();
            this.grpTypeOfAccount.ResumeLayout(false);
            this.grpTypeOfAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccountDetails;
        private System.Windows.Forms.Label lblDailyWithdrawLimit;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtDailyWithdrawLimit;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.GroupBox grpTypeOfAccount;
        private System.Windows.Forms.RadioButton rbtnSavings;
        private System.Windows.Forms.RadioButton rbtnChecking;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnSearch;
    }
}

