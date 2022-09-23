namespace PrimeMinisters
{
    partial class frmPrimeMinisters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimeMinisters));
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.lstPrimeMinisters = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblParty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picPhoto
            // 
            this.picPhoto.Location = new System.Drawing.Point(30, 35);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(0);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(250, 250);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // lstPrimeMinisters
            // 
            this.lstPrimeMinisters.FormattingEnabled = true;
            this.lstPrimeMinisters.ItemHeight = 20;
            this.lstPrimeMinisters.Location = new System.Drawing.Point(390, 35);
            this.lstPrimeMinisters.Name = "lstPrimeMinisters";
            this.lstPrimeMinisters.Size = new System.Drawing.Size(210, 244);
            this.lstPrimeMinisters.TabIndex = 1;
            this.lstPrimeMinisters.SelectedValueChanged += new System.EventHandler(this.lstPrimeMinisters_SelectedValueChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 310);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 27);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Term:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Party:";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(110, 355);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(44, 22);
            this.lblTerm.TabIndex = 5;
            this.lblTerm.Text = "Hold";
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParty.Location = new System.Drawing.Point(110, 395);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(44, 22);
            this.lblParty.TabIndex = 6;
            this.lblParty.Text = "Hold";
            // 
            // frmPrimeMinisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 454);
            this.Controls.Add(this.lblParty);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstPrimeMinisters);
            this.Controls.Add(this.picPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrimeMinisters";
            this.Text = "Prime Ministers";
            this.Load += new System.EventHandler(this.frmPrimeMinisters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.ListBox lstPrimeMinisters;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblParty;
    }
}

