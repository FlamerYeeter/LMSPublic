namespace LibraryManagementSystem
{
    partial class BookReturningForms
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.borrowedBooksComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxBorrower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dateTimeDueDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentRadio = new System.Windows.Forms.RadioButton();
            this.teacherRadio = new System.Windows.Forms.RadioButton();
            this.selectBorrowerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookBorrowing = new System.Windows.Forms.Button();
            this.btnBorrowerList = new System.Windows.Forms.Button();
            this.btnBookReturning = new System.Windows.Forms.Button();
            this.btnBookReservation = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.btnBookList = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.borrowedBooksComboBox);
            this.panel2.Controls.Add(this.textBoxBorrower);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridViewDetails);
            this.panel2.Controls.Add(this.btnCalculate);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.dateTimeDueDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dateTimeReturnDate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.studentRadio);
            this.panel2.Controls.Add(this.teacherRadio);
            this.panel2.Controls.Add(this.selectBorrowerLabel);
            this.panel2.Location = new System.Drawing.Point(294, 128);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 631);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // borrowedBooksComboBox
            // 
            this.borrowedBooksComboBox.FormattingEnabled = true;
            this.borrowedBooksComboBox.Items.AddRange(new object[] {
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
            this.borrowedBooksComboBox.Location = new System.Drawing.Point(171, 272);
            this.borrowedBooksComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.borrowedBooksComboBox.Name = "borrowedBooksComboBox";
            this.borrowedBooksComboBox.Size = new System.Drawing.Size(312, 28);
            this.borrowedBooksComboBox.TabIndex = 44;
            // 
            // textBoxBorrower
            // 
            this.textBoxBorrower.Location = new System.Drawing.Point(171, 118);
            this.textBoxBorrower.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxBorrower.Name = "textBoxBorrower";
            this.textBoxBorrower.Size = new System.Drawing.Size(312, 26);
            this.textBoxBorrower.TabIndex = 43;
            this.textBoxBorrower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBorrower_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(22, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Book Borrowed";
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(544, 48);
            this.dataGridViewDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.RowHeadersWidth = 62;
            this.dataGridViewDetails.RowTemplate.Height = 28;
            this.dataGridViewDetails.Size = new System.Drawing.Size(470, 462);
            this.dataGridViewDetails.TabIndex = 38;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculate.Location = new System.Drawing.Point(434, 535);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(176, 52);
            this.btnCalculate.TabIndex = 37;
            this.btnCalculate.Text = "Calculate Penalty";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(663, 538);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 49);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Location = new System.Drawing.Point(242, 538);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(129, 49);
            this.btnReturn.TabIndex = 34;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dateTimeDueDate
            // 
            this.dateTimeDueDate.Location = new System.Drawing.Point(171, 222);
            this.dateTimeDueDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeDueDate.Name = "dateTimeDueDate";
            this.dateTimeDueDate.Size = new System.Drawing.Size(312, 26);
            this.dateTimeDueDate.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(22, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Due Date";
            // 
            // dateTimeReturnDate
            // 
            this.dateTimeReturnDate.Location = new System.Drawing.Point(171, 172);
            this.dateTimeReturnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeReturnDate.Name = "dateTimeReturnDate";
            this.dateTimeReturnDate.Size = new System.Drawing.Size(312, 26);
            this.dateTimeReturnDate.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(22, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Return Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Borrower";
            // 
            // studentRadio
            // 
            this.studentRadio.AutoSize = true;
            this.studentRadio.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.studentRadio.ForeColor = System.Drawing.SystemColors.Control;
            this.studentRadio.Location = new System.Drawing.Point(314, 31);
            this.studentRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentRadio.Name = "studentRadio";
            this.studentRadio.Size = new System.Drawing.Size(101, 28);
            this.studentRadio.TabIndex = 23;
            this.studentRadio.TabStop = true;
            this.studentRadio.Text = "Student";
            this.studentRadio.UseVisualStyleBackColor = true;
            this.studentRadio.CheckedChanged += new System.EventHandler(this.studentRadio_CheckedChanged);
            // 
            // teacherRadio
            // 
            this.teacherRadio.AutoSize = true;
            this.teacherRadio.Font = new System.Drawing.Font("Imprint MT Shadow", 10F);
            this.teacherRadio.ForeColor = System.Drawing.SystemColors.Control;
            this.teacherRadio.Location = new System.Drawing.Point(171, 31);
            this.teacherRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teacherRadio.Name = "teacherRadio";
            this.teacherRadio.Size = new System.Drawing.Size(105, 28);
            this.teacherRadio.TabIndex = 22;
            this.teacherRadio.TabStop = true;
            this.teacherRadio.Text = "Teacher";
            this.teacherRadio.UseVisualStyleBackColor = true;
            this.teacherRadio.CheckedChanged += new System.EventHandler(this.teacherRadio_CheckedChanged);
            // 
            // selectBorrowerLabel
            // 
            this.selectBorrowerLabel.AutoSize = true;
            this.selectBorrowerLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBorrowerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.selectBorrowerLabel.Location = new System.Drawing.Point(22, 35);
            this.selectBorrowerLabel.Name = "selectBorrowerLabel";
            this.selectBorrowerLabel.Size = new System.Drawing.Size(110, 24);
            this.selectBorrowerLabel.TabIndex = 21;
            this.selectBorrowerLabel.Text = "Select Type";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 95);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.btnBookBorrowing.Size = new System.Drawing.Size(258, 58);
            this.btnBookBorrowing.TabIndex = 26;
            this.btnBookBorrowing.Text = "BOOK BORROWING";
            this.btnBookBorrowing.UseVisualStyleBackColor = false;
            this.btnBookBorrowing.Click += new System.EventHandler(this.btnBookBorrowing_Click);
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
            this.btnBorrowerList.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnBorrowerList.Size = new System.Drawing.Size(258, 58);
            this.btnBorrowerList.TabIndex = 27;
            this.btnBorrowerList.Text = "BORROWER LIST";
            this.btnBorrowerList.UseVisualStyleBackColor = false;
            this.btnBorrowerList.Click += new System.EventHandler(this.btnBorrowerList_Click);
            // 
            // btnBookReturning
            // 
            this.btnBookReturning.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBookReturning.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBookReturning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookReturning.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReturning.ForeColor = System.Drawing.Color.White;
            this.btnBookReturning.Location = new System.Drawing.Point(21, 338);
            this.btnBookReturning.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBookReturning.Name = "btnBookReturning";
            this.btnBookReturning.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnBookReturning.Size = new System.Drawing.Size(258, 58);
            this.btnBookReturning.TabIndex = 28;
            this.btnBookReturning.Text = "BOOK RETURNING";
            this.btnBookReturning.UseVisualStyleBackColor = false;
            // 
            // btnBookReservation
            // 
            this.btnBookReservation.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBookReservation.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBookReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookReservation.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReservation.ForeColor = System.Drawing.Color.White;
            this.btnBookReservation.Location = new System.Drawing.Point(21, 402);
            this.btnBookReservation.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBookReservation.Name = "btnBookReservation";
            this.btnBookReservation.Size = new System.Drawing.Size(258, 58);
            this.btnBookReservation.TabIndex = 29;
            this.btnBookReservation.Text = "BOOK RESERVATION";
            this.btnBookReservation.UseVisualStyleBackColor = false;
            this.btnBookReservation.Click += new System.EventHandler(this.btnBookReservation_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonLogout.Font = new System.Drawing.Font("Imprint MT Shadow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(124, 682);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(154, 48);
            this.buttonLogout.TabIndex = 30;
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
            this.btnBookList.Location = new System.Drawing.Point(21, 129);
            this.btnBookList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(258, 58);
            this.btnBookList.TabIndex = 41;
            this.btnBookList.Text = "BOOK LIST";
            this.btnBookList.UseVisualStyleBackColor = false;
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // BookReturningForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 775);
            this.Controls.Add(this.btnBookList);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.btnBookReservation);
            this.Controls.Add(this.btnBookReturning);
            this.Controls.Add(this.btnBorrowerList);
            this.Controls.Add(this.btnBookBorrowing);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookReturningForms";
            this.Text = "Crimson Library System | Book Returning";
            this.Load += new System.EventHandler(this.BookReturningForms_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookBorrowing;
        private System.Windows.Forms.Button btnBorrowerList;
        private System.Windows.Forms.Button btnBookReturning;
        private System.Windows.Forms.Button btnBookReservation;
        private System.Windows.Forms.Label selectBorrowerLabel;
        private System.Windows.Forms.RadioButton teacherRadio;
        private System.Windows.Forms.RadioButton studentRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeDueDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeReturnDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBorrower;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.ComboBox borrowedBooksComboBox;
    }
}