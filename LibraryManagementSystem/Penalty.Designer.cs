namespace LibraryManagementSystem
{
    partial class Penalty
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelReceipt = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.btnBorrowerList = new System.Windows.Forms.Button();
            this.btnBookBorrowing = new System.Windows.Forms.Button();
            this.btnBookReturning = new System.Windows.Forms.Button();
            this.btnBookReservation = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.btnBookList = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 95);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(348, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRIMSON LIBRARY SYSTEM";
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.panelReceipt);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtChange);
            this.panel2.Controls.Add(this.txtAmountPaid);
            this.panel2.Controls.Add(this.txtAmountDue);
            this.panel2.Location = new System.Drawing.Point(294, 129);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 631);
            this.panel2.TabIndex = 18;
            // 
            // panelReceipt
            // 
            this.panelReceipt.BackColor = System.Drawing.SystemColors.Control;
            this.panelReceipt.Location = new System.Drawing.Point(571, 58);
            this.panelReceipt.Name = "panelReceipt";
            this.panelReceipt.Size = new System.Drawing.Size(437, 492);
            this.panelReceipt.TabIndex = 38;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(296, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 37);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPay.Location = new System.Drawing.Point(108, 315);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(129, 37);
            this.btnPay.TabIndex = 35;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(50, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Change:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(46, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Paid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(46, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount Due";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(249, 206);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(216, 26);
            this.txtChange.TabIndex = 2;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(249, 137);
            this.txtAmountPaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(216, 26);
            this.txtAmountPaid.TabIndex = 1;
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Location = new System.Drawing.Point(249, 68);
            this.txtAmountDue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(216, 26);
            this.txtAmountDue.TabIndex = 0;
            // 
            // btnBorrowerList
            // 
            this.btnBorrowerList.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBorrowerList.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBorrowerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowerList.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowerList.ForeColor = System.Drawing.Color.White;
            this.btnBorrowerList.Location = new System.Drawing.Point(21, 198);
            this.btnBorrowerList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBorrowerList.Name = "btnBorrowerList";
            this.btnBorrowerList.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnBorrowerList.Size = new System.Drawing.Size(258, 57);
            this.btnBorrowerList.TabIndex = 28;
            this.btnBorrowerList.Text = "BORROWER LIST";
            this.btnBorrowerList.UseVisualStyleBackColor = false;
            this.btnBorrowerList.Click += new System.EventHandler(this.btnBorrowerList_Click);
            // 
            // btnBookBorrowing
            // 
            this.btnBookBorrowing.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBookBorrowing.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBookBorrowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookBorrowing.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookBorrowing.ForeColor = System.Drawing.Color.White;
            this.btnBookBorrowing.Location = new System.Drawing.Point(21, 268);
            this.btnBookBorrowing.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBookBorrowing.Name = "btnBookBorrowing";
            this.btnBookBorrowing.Size = new System.Drawing.Size(258, 57);
            this.btnBookBorrowing.TabIndex = 29;
            this.btnBookBorrowing.Text = "BOOK BORROWING";
            this.btnBookBorrowing.UseVisualStyleBackColor = false;
            this.btnBookBorrowing.Click += new System.EventHandler(this.btnBookBorrowing_Click);
            // 
            // btnBookReturning
            // 
            this.btnBookReturning.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBookReturning.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBookReturning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookReturning.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReturning.ForeColor = System.Drawing.Color.White;
            this.btnBookReturning.Location = new System.Drawing.Point(21, 335);
            this.btnBookReturning.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBookReturning.Name = "btnBookReturning";
            this.btnBookReturning.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnBookReturning.Size = new System.Drawing.Size(258, 57);
            this.btnBookReturning.TabIndex = 30;
            this.btnBookReturning.Text = "BOOK RETURNING";
            this.btnBookReturning.UseVisualStyleBackColor = false;
            this.btnBookReturning.Click += new System.EventHandler(this.btnBookReturning_Click);
            // 
            // btnBookReservation
            // 
            this.btnBookReservation.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBookReservation.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBookReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookReservation.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReservation.ForeColor = System.Drawing.Color.White;
            this.btnBookReservation.Location = new System.Drawing.Point(21, 403);
            this.btnBookReservation.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBookReservation.Name = "btnBookReservation";
            this.btnBookReservation.Size = new System.Drawing.Size(258, 57);
            this.btnBookReservation.TabIndex = 31;
            this.btnBookReservation.Text = "BOOK RESERVATION";
            this.btnBookReservation.UseVisualStyleBackColor = false;
            this.btnBookReservation.Click += new System.EventHandler(this.btnBookReservation_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonLogout.Font = new System.Drawing.Font("Imprint MT Shadow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(124, 682);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(154, 48);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // btnBookList
            // 
            this.btnBookList.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBookList.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookList.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookList.ForeColor = System.Drawing.Color.White;
            this.btnBookList.Location = new System.Drawing.Point(20, 129);
            this.btnBookList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(258, 58);
            this.btnBookList.TabIndex = 43;
            this.btnBookList.Text = "BOOK LIST";
            this.btnBookList.UseVisualStyleBackColor = false;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // Penalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 775);
            this.Controls.Add(this.btnBookList);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.btnBookReservation);
            this.Controls.Add(this.btnBookReturning);
            this.Controls.Add(this.btnBookBorrowing);
            this.Controls.Add(this.btnBorrowerList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Penalty";
            this.Text = "Crimson Library System | Penalty";
            this.Load += new System.EventHandler(this.Penalty_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBorrowerList;
        private System.Windows.Forms.Button btnBookBorrowing;
        private System.Windows.Forms.Button btnBookReturning;
        private System.Windows.Forms.Button btnBookReservation;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Panel panelReceipt;
    }
}