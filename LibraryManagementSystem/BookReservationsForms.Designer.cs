namespace LibraryManagementSystem
{
    partial class BookReservationsForms
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
            this.comboBox5SelectBookTitle = new System.Windows.Forms.ComboBox();
            this.comboBox4SelectBookTitle = new System.Windows.Forms.ComboBox();
            this.comboBox3SelectBookTitle = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.dateTimeReserved = new System.Windows.Forms.DateTimePicker();
            this.comboBox2SelectBookTitle = new System.Windows.Forms.ComboBox();
            this.comboBox1SelectbookTitle = new System.Windows.Forms.ComboBox();
            this.textBoxBorrower = new System.Windows.Forms.TextBox();
            this.labelBorrower = new System.Windows.Forms.Label();
            this.lblDateReserved = new System.Windows.Forms.Label();
            this.selecReservationLabel = new System.Windows.Forms.Label();
            this.btnBookList = new System.Windows.Forms.Button();
            this.btnBorrowerList = new System.Windows.Forms.Button();
            this.btnBookBorrowing = new System.Windows.Forms.Button();
            this.btnBookReturning = new System.Windows.Forms.Button();
            this.btnBookReservation = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 76);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(309, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRIMSON LIBRARY SYSTEM";
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.comboBox5SelectBookTitle);
            this.panel2.Controls.Add(this.comboBox4SelectBookTitle);
            this.panel2.Controls.Add(this.comboBox3SelectBookTitle);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnReserve);
            this.panel2.Controls.Add(this.dateTimeReserved);
            this.panel2.Controls.Add(this.comboBox2SelectBookTitle);
            this.panel2.Controls.Add(this.comboBox1SelectbookTitle);
            this.panel2.Controls.Add(this.textBoxBorrower);
            this.panel2.Controls.Add(this.labelBorrower);
            this.panel2.Controls.Add(this.lblDateReserved);
            this.panel2.Controls.Add(this.selecReservationLabel);
            this.panel2.Location = new System.Drawing.Point(261, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 505);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // comboBox5SelectBookTitle
            // 
            this.comboBox5SelectBookTitle.FormattingEnabled = true;
            this.comboBox5SelectBookTitle.Items.AddRange(new object[] {
            "Harry Potter and The Sorcerer\'s Stone",
            "Percy Jackson: The Lightning Thief",
            "The Da Vinci Code",
            "The Hobbit",
            "The Hunger Games",
            "Thinking, Fast and Slow",
            "Quiet: The Power of Introverts",
            "Sapiens: A Brief History of Humankind",
            "The Immortal Life of Henrietta Lacks",
            "The Power of Habit",
            "Real Estate Finance and Investments",
            "Economics: Principles, Problems, and Policies",
            "Principles of Corporate Finance",
            "Python for Data Analysis",
            "Cognitive Psychology"});
            this.comboBox5SelectBookTitle.Location = new System.Drawing.Point(51, 302);
            this.comboBox5SelectBookTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox5SelectBookTitle.Name = "comboBox5SelectBookTitle";
            this.comboBox5SelectBookTitle.Size = new System.Drawing.Size(287, 24);
            this.comboBox5SelectBookTitle.TabIndex = 58;
            // 
            // comboBox4SelectBookTitle
            // 
            this.comboBox4SelectBookTitle.FormattingEnabled = true;
            this.comboBox4SelectBookTitle.Items.AddRange(new object[] {
            "Harry Potter and The Sorcerer\'s Stone",
            "Percy Jackson: The Lightning Thief",
            "The Da Vinci Code",
            "The Hobbit",
            "The Hunger Games",
            "Thinking, Fast and Slow",
            "Quiet: The Power of Introverts",
            "Sapiens: A Brief History of Humankind",
            "The Immortal Life of Henrietta Lacks",
            "The Power of Habit",
            "Real Estate Finance and Investments",
            "Economics: Principles, Problems, and Policies",
            "Principles of Corporate Finance",
            "Python for Data Analysis",
            "Cognitive Psychology"});
            this.comboBox4SelectBookTitle.Location = new System.Drawing.Point(51, 238);
            this.comboBox4SelectBookTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox4SelectBookTitle.Name = "comboBox4SelectBookTitle";
            this.comboBox4SelectBookTitle.Size = new System.Drawing.Size(287, 24);
            this.comboBox4SelectBookTitle.TabIndex = 57;
            // 
            // comboBox3SelectBookTitle
            // 
            this.comboBox3SelectBookTitle.FormattingEnabled = true;
            this.comboBox3SelectBookTitle.Items.AddRange(new object[] {
            "Harry Potter and The Sorcerer\'s Stone",
            "Percy Jackson: The Lightning Thief",
            "The Da Vinci Code",
            "The Hobbit",
            "The Hunger Games",
            "Thinking, Fast and Slow",
            "Quiet: The Power of Introverts",
            "Sapiens: A Brief History of Humankind",
            "The Immortal Life of Henrietta Lacks",
            "The Power of Habit",
            "Real Estate Finance and Investments",
            "Economics: Principles, Problems, and Policies",
            "Principles of Corporate Finance",
            "Python for Data Analysis",
            "Cognitive Psychology"});
            this.comboBox3SelectBookTitle.Location = new System.Drawing.Point(51, 185);
            this.comboBox3SelectBookTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3SelectBookTitle.Name = "comboBox3SelectBookTitle";
            this.comboBox3SelectBookTitle.Size = new System.Drawing.Size(287, 24);
            this.comboBox3SelectBookTitle.TabIndex = 56;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(453, 404);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 46);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReserve.Location = new System.Drawing.Point(275, 404);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(131, 46);
            this.btnReserve.TabIndex = 54;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // dateTimeReserved
            // 
            this.dateTimeReserved.Location = new System.Drawing.Point(567, 130);
            this.dateTimeReserved.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeReserved.Name = "dateTimeReserved";
            this.dateTimeReserved.Size = new System.Drawing.Size(278, 22);
            this.dateTimeReserved.TabIndex = 53;
            // 
            // comboBox2SelectBookTitle
            // 
            this.comboBox2SelectBookTitle.FormattingEnabled = true;
            this.comboBox2SelectBookTitle.Items.AddRange(new object[] {
            "Harry Potter and The Sorcerer\'s Stone",
            "Percy Jackson: The Lightning Thief",
            "The Da Vinci Code",
            "The Hobbit",
            "The Hunger Games",
            "Thinking, Fast and Slow",
            "Quiet: The Power of Introverts",
            "Sapiens: A Brief History of Humankind",
            "The Immortal Life of Henrietta Lacks",
            "The Power of Habit",
            "Real Estate Finance and Investments",
            "Economics: Principles, Problems, and Policies",
            "Principles of Corporate Finance",
            "Python for Data Analysis",
            "Cognitive Psychology"});
            this.comboBox2SelectBookTitle.Location = new System.Drawing.Point(51, 130);
            this.comboBox2SelectBookTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2SelectBookTitle.Name = "comboBox2SelectBookTitle";
            this.comboBox2SelectBookTitle.Size = new System.Drawing.Size(287, 24);
            this.comboBox2SelectBookTitle.TabIndex = 52;
            this.comboBox2SelectBookTitle.SelectedIndexChanged += new System.EventHandler(this.comboBox2SelectBookTitle_SelectedIndexChanged);
            // 
            // comboBox1SelectbookTitle
            // 
            this.comboBox1SelectbookTitle.FormattingEnabled = true;
            this.comboBox1SelectbookTitle.Items.AddRange(new object[] {
            "Harry Potter and The Sorcerer\'s Stone",
            "Percy Jackson: The Lightning Thief",
            "The Da Vinci Code",
            "The Hobbit",
            "The Hunger Games",
            "Thinking, Fast and Slow",
            "Quiet: The Power of Introverts",
            "Sapiens: A Brief History of Humankind",
            "The Immortal Life of Henrietta Lacks",
            "The Power of Habit",
            "Real Estate Finance and Investments",
            "Economics: Principles, Problems, and Policies",
            "Principles of Corporate Finance",
            "Python for Data Analysis",
            "Cognitive Psychology"});
            this.comboBox1SelectbookTitle.Location = new System.Drawing.Point(51, 76);
            this.comboBox1SelectbookTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1SelectbookTitle.Name = "comboBox1SelectbookTitle";
            this.comboBox1SelectbookTitle.Size = new System.Drawing.Size(287, 24);
            this.comboBox1SelectbookTitle.TabIndex = 51;
            // 
            // textBoxBorrower
            // 
            this.textBoxBorrower.Location = new System.Drawing.Point(567, 76);
            this.textBoxBorrower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBorrower.Name = "textBoxBorrower";
            this.textBoxBorrower.Size = new System.Drawing.Size(278, 22);
            this.textBoxBorrower.TabIndex = 50;
            // 
            // labelBorrower
            // 
            this.labelBorrower.AutoSize = true;
            this.labelBorrower.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrower.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBorrower.Location = new System.Drawing.Point(414, 76);
            this.labelBorrower.Name = "labelBorrower";
            this.labelBorrower.Size = new System.Drawing.Size(78, 20);
            this.labelBorrower.TabIndex = 49;
            this.labelBorrower.Text = "Borrower";
            // 
            // lblDateReserved
            // 
            this.lblDateReserved.AutoSize = true;
            this.lblDateReserved.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReserved.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDateReserved.Location = new System.Drawing.Point(414, 134);
            this.lblDateReserved.Name = "lblDateReserved";
            this.lblDateReserved.Size = new System.Drawing.Size(116, 20);
            this.lblDateReserved.TabIndex = 48;
            this.lblDateReserved.Text = "Date Reserved";
            // 
            // selecReservationLabel
            // 
            this.selecReservationLabel.AutoSize = true;
            this.selecReservationLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecReservationLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.selecReservationLabel.Location = new System.Drawing.Point(46, 41);
            this.selecReservationLabel.Name = "selecReservationLabel";
            this.selecReservationLabel.Size = new System.Drawing.Size(151, 23);
            this.selecReservationLabel.TabIndex = 46;
            this.selecReservationLabel.Text = "Select Book Title";
            // 
            // btnBookList
            // 
            this.btnBookList.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBookList.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookList.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookList.ForeColor = System.Drawing.Color.White;
            this.btnBookList.Location = new System.Drawing.Point(18, 103);
            this.btnBookList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(229, 46);
            this.btnBookList.TabIndex = 44;
            this.btnBookList.Text = "BOOK LIST";
            this.btnBookList.UseVisualStyleBackColor = false;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // btnBorrowerList
            // 
            this.btnBorrowerList.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBorrowerList.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBorrowerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowerList.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowerList.ForeColor = System.Drawing.Color.White;
            this.btnBorrowerList.Location = new System.Drawing.Point(19, 158);
            this.btnBorrowerList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrowerList.Name = "btnBorrowerList";
            this.btnBorrowerList.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnBorrowerList.Size = new System.Drawing.Size(229, 46);
            this.btnBorrowerList.TabIndex = 45;
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
            this.btnBookBorrowing.Location = new System.Drawing.Point(19, 214);
            this.btnBookBorrowing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookBorrowing.Name = "btnBookBorrowing";
            this.btnBookBorrowing.Size = new System.Drawing.Size(229, 46);
            this.btnBookBorrowing.TabIndex = 46;
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
            this.btnBookReturning.Location = new System.Drawing.Point(19, 268);
            this.btnBookReturning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookReturning.Name = "btnBookReturning";
            this.btnBookReturning.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnBookReturning.Size = new System.Drawing.Size(229, 46);
            this.btnBookReturning.TabIndex = 47;
            this.btnBookReturning.Text = "BOOK RETURNING";
            this.btnBookReturning.UseVisualStyleBackColor = false;
            this.btnBookReturning.Click += new System.EventHandler(this.btnBookReturning_Click);
            // 
            // btnBookReservation
            // 
            this.btnBookReservation.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBookReservation.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBookReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookReservation.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReservation.ForeColor = System.Drawing.Color.White;
            this.btnBookReservation.Location = new System.Drawing.Point(19, 322);
            this.btnBookReservation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookReservation.Name = "btnBookReservation";
            this.btnBookReservation.Size = new System.Drawing.Size(229, 46);
            this.btnBookReservation.TabIndex = 48;
            this.btnBookReservation.Text = "BOOK RESERVATION";
            this.btnBookReservation.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonLogout.Font = new System.Drawing.Font("Imprint MT Shadow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(110, 546);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(137, 38);
            this.buttonLogout.TabIndex = 49;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // BookReservationsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 620);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.btnBookReservation);
            this.Controls.Add(this.btnBookReturning);
            this.Controls.Add(this.btnBookBorrowing);
            this.Controls.Add(this.btnBorrowerList);
            this.Controls.Add(this.btnBookList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookReservationsForms";
            this.Text = "Crimson Library System | Book Reservation";
            this.Load += new System.EventHandler(this.BookReservationsForms_Load);
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
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.Button btnBorrowerList;
        private System.Windows.Forms.Button btnBookBorrowing;
        private System.Windows.Forms.Button btnBookReturning;
        private System.Windows.Forms.Button btnBookReservation;
        private System.Windows.Forms.Label selecReservationLabel;
        private System.Windows.Forms.TextBox textBoxBorrower;
        private System.Windows.Forms.Label labelBorrower;
        private System.Windows.Forms.Label lblDateReserved;
        private System.Windows.Forms.ComboBox comboBox2SelectBookTitle;
        private System.Windows.Forms.ComboBox comboBox1SelectbookTitle;
        private System.Windows.Forms.DateTimePicker dateTimeReserved;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ComboBox comboBox5SelectBookTitle;
        private System.Windows.Forms.ComboBox comboBox4SelectBookTitle;
        private System.Windows.Forms.ComboBox comboBox3SelectBookTitle;
    }
}