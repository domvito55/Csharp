namespace Lab9
{
    partial class frmCalculator
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.rbtnDivision = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplication = new System.Windows.Forms.RadioButton();
            this.rbtnSubtraction = new System.Windows.Forms.RadioButton();
            this.rbtnAddition = new System.Windows.Forms.RadioButton();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.txtResultNum = new System.Windows.Forms.TextBox();
            this.lblEqual = new System.Windows.Forms.Label();
            this.btnOperation = new System.Windows.Forms.Button();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblLine3 = new System.Windows.Forms.Label();
            this.txtSecondDem = new System.Windows.Forms.TextBox();
            this.txtResultDem = new System.Windows.Forms.TextBox();
            this.txtFirstDem = new System.Windows.Forms.TextBox();
            this.grpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(40, 66);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(40, 20);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(243, 66);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(64, 20);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Second";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(403, 66);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 20);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.rbtnDivision);
            this.grpOperations.Controls.Add(this.rbtnMultiplication);
            this.grpOperations.Controls.Add(this.rbtnSubtraction);
            this.grpOperations.Controls.Add(this.rbtnAddition);
            this.grpOperations.Location = new System.Drawing.Point(119, 42);
            this.grpOperations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpOperations.Size = new System.Drawing.Size(81, 196);
            this.grpOperations.TabIndex = 10;
            this.grpOperations.TabStop = false;
            // 
            // rbtnDivision
            // 
            this.rbtnDivision.AutoSize = true;
            this.rbtnDivision.Location = new System.Drawing.Point(25, 150);
            this.rbtnDivision.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnDivision.Name = "rbtnDivision";
            this.rbtnDivision.Size = new System.Drawing.Size(38, 24);
            this.rbtnDivision.TabIndex = 25;
            this.rbtnDivision.TabStop = true;
            this.rbtnDivision.Text = "/";
            this.rbtnDivision.UseVisualStyleBackColor = true;
            this.rbtnDivision.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // rbtnMultiplication
            // 
            this.rbtnMultiplication.AutoSize = true;
            this.rbtnMultiplication.Location = new System.Drawing.Point(25, 109);
            this.rbtnMultiplication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnMultiplication.Name = "rbtnMultiplication";
            this.rbtnMultiplication.Size = new System.Drawing.Size(40, 24);
            this.rbtnMultiplication.TabIndex = 20;
            this.rbtnMultiplication.TabStop = true;
            this.rbtnMultiplication.Text = "*";
            this.rbtnMultiplication.UseVisualStyleBackColor = true;
            this.rbtnMultiplication.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // rbtnSubtraction
            // 
            this.rbtnSubtraction.AutoSize = true;
            this.rbtnSubtraction.Location = new System.Drawing.Point(25, 68);
            this.rbtnSubtraction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnSubtraction.Name = "rbtnSubtraction";
            this.rbtnSubtraction.Size = new System.Drawing.Size(39, 24);
            this.rbtnSubtraction.TabIndex = 15;
            this.rbtnSubtraction.TabStop = true;
            this.rbtnSubtraction.Text = "-";
            this.rbtnSubtraction.UseVisualStyleBackColor = true;
            this.rbtnSubtraction.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // rbtnAddition
            // 
            this.rbtnAddition.AutoSize = true;
            this.rbtnAddition.Location = new System.Drawing.Point(25, 26);
            this.rbtnAddition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnAddition.Name = "rbtnAddition";
            this.rbtnAddition.Size = new System.Drawing.Size(43, 24);
            this.rbtnAddition.TabIndex = 10;
            this.rbtnAddition.TabStop = true;
            this.rbtnAddition.Text = "+";
            this.rbtnAddition.UseVisualStyleBackColor = true;
            this.rbtnAddition.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Location = new System.Drawing.Point(44, 124);
            this.txtFirstNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(46, 26);
            this.txtFirstNum.TabIndex = 1;
            this.txtFirstNum.Text = "0";
            this.txtFirstNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstNum_KeyPress);
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Location = new System.Drawing.Point(246, 124);
            this.txtSecondNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(46, 26);
            this.txtSecondNum.TabIndex = 30;
            this.txtSecondNum.Text = "0";
            this.txtSecondNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondNum_KeyPress);
            // 
            // txtResultNum
            // 
            this.txtResultNum.Location = new System.Drawing.Point(406, 124);
            this.txtResultNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultNum.Name = "txtResultNum";
            this.txtResultNum.ReadOnly = true;
            this.txtResultNum.Size = new System.Drawing.Size(46, 26);
            this.txtResultNum.TabIndex = 45;
            this.txtResultNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultNum_KeyPress);
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(342, 128);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(18, 20);
            this.lblEqual.TabIndex = 7;
            this.lblEqual.Text = "=";
            this.lblEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(44, 268);
            this.btnOperation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(413, 60);
            this.btnOperation.TabIndex = 40;
            this.btnOperation.Text = "Perform Operation";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // lblLine1
            // 
            this.lblLine1.AutoSize = true;
            this.lblLine1.Location = new System.Drawing.Point(31, 138);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(72, 20);
            this.lblLine1.TabIndex = 8;
            this.lblLine1.Text = "_______";
            this.lblLine1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLine2
            // 
            this.lblLine2.AutoSize = true;
            this.lblLine2.Location = new System.Drawing.Point(232, 138);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(72, 20);
            this.lblLine2.TabIndex = 9;
            this.lblLine2.Text = "_______";
            this.lblLine2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLine3
            // 
            this.lblLine3.AutoSize = true;
            this.lblLine3.Location = new System.Drawing.Point(393, 138);
            this.lblLine3.Name = "lblLine3";
            this.lblLine3.Size = new System.Drawing.Size(72, 20);
            this.lblLine3.TabIndex = 10;
            this.lblLine3.Text = "_______";
            this.lblLine3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSecondDem
            // 
            this.txtSecondDem.Location = new System.Drawing.Point(246, 162);
            this.txtSecondDem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSecondDem.Name = "txtSecondDem";
            this.txtSecondDem.Size = new System.Drawing.Size(46, 26);
            this.txtSecondDem.TabIndex = 35;
            this.txtSecondDem.Text = "1";
            this.txtSecondDem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondDem_KeyPress);
            // 
            // txtResultDem
            // 
            this.txtResultDem.Location = new System.Drawing.Point(406, 162);
            this.txtResultDem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultDem.Name = "txtResultDem";
            this.txtResultDem.ReadOnly = true;
            this.txtResultDem.Size = new System.Drawing.Size(46, 26);
            this.txtResultDem.TabIndex = 50;
            this.txtResultDem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultDem_KeyPress);
            // 
            // txtFirstDem
            // 
            this.txtFirstDem.Location = new System.Drawing.Point(44, 162);
            this.txtFirstDem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstDem.Name = "txtFirstDem";
            this.txtFirstDem.Size = new System.Drawing.Size(46, 26);
            this.txtFirstDem.TabIndex = 5;
            this.txtFirstDem.Text = "1";
            this.txtFirstDem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstDem_KeyPress);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 342);
            this.Controls.Add(this.txtSecondDem);
            this.Controls.Add(this.txtResultDem);
            this.Controls.Add(this.txtFirstDem);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.txtResultNum);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.lblLine3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.RadioButton rbtnDivision;
        private System.Windows.Forms.RadioButton rbtnMultiplication;
        private System.Windows.Forms.RadioButton rbtnSubtraction;
        private System.Windows.Forms.RadioButton rbtnAddition;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.TextBox txtSecondNum;
        private System.Windows.Forms.TextBox txtResultNum;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblLine3;
        private System.Windows.Forms.TextBox txtSecondDem;
        private System.Windows.Forms.TextBox txtResultDem;
        private System.Windows.Forms.TextBox txtFirstDem;
    }
}

