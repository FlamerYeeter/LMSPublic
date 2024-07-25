namespace LibraryManagementSystem
{
    partial class BookListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookListForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.lvBookList = new System.Windows.Forms.ListView();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnBorrowerList = new System.Windows.Forms.Button();
            this.btnBookBorrowing = new System.Windows.Forms.Button();
            this.btnBookReturning = new System.Windows.Forms.Button();
            this.btnBookReservation = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.btnBookList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(16, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 95);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1320, 95);
            this.label1.TabIndex = 2;
            this.label1.Text = "CRIMSON LIBRARY SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.SearchBar);
            this.panel2.Controls.Add(this.lvBookList);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Location = new System.Drawing.Point(290, 129);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 628);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // SearchBar
            // 
            this.SearchBar.AcceptsReturn = true;
            this.SearchBar.Location = new System.Drawing.Point(26, 42);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(598, 26);
            this.SearchBar.TabIndex = 8;
            this.SearchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lvBookList
            // 
            this.lvBookList.FullRowSelect = true;
            this.lvBookList.GridLines = true;
            this.lvBookList.HideSelection = false;
            this.lvBookList.Location = new System.Drawing.Point(26, 120);
            this.lvBookList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvBookList.Name = "lvBookList";
            this.lvBookList.Size = new System.Drawing.Size(1002, 478);
            this.lvBookList.TabIndex = 7;
            this.lvBookList.UseCompatibleStateImageBehavior = false;
            this.lvBookList.View = System.Windows.Forms.View.Details;
            this.lvBookList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(48, 622);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(99, 138);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(56, 815);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(99, 118);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(56, 640);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 174);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(56, 689);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(99, 118);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // btnBorrowerList
            // 
            this.btnBorrowerList.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBorrowerList.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBorrowerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowerList.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowerList.ForeColor = System.Drawing.Color.White;
            this.btnBorrowerList.Location = new System.Drawing.Point(16, 198);
            this.btnBorrowerList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBorrowerList.Name = "btnBorrowerList";
            this.btnBorrowerList.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnBorrowerList.Size = new System.Drawing.Size(258, 58);
            this.btnBorrowerList.TabIndex = 8;
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
            this.btnBookBorrowing.Location = new System.Drawing.Point(16, 266);
            this.btnBookBorrowing.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBookBorrowing.Name = "btnBookBorrowing";
            this.btnBookBorrowing.Size = new System.Drawing.Size(258, 58);
            this.btnBookBorrowing.TabIndex = 9;
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
            this.btnBookReturning.Location = new System.Drawing.Point(16, 334);
            this.btnBookReturning.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBookReturning.Name = "btnBookReturning";
            this.btnBookReturning.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnBookReturning.Size = new System.Drawing.Size(258, 58);
            this.btnBookReturning.TabIndex = 10;
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
            this.btnBookReservation.Location = new System.Drawing.Point(16, 402);
            this.btnBookReservation.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBookReservation.Name = "btnBookReservation";
            this.btnBookReservation.Size = new System.Drawing.Size(258, 58);
            this.btnBookReservation.TabIndex = 11;
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
            this.buttonLogout.TabIndex = 32;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // btnBookList
            // 
            this.btnBookList.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBookList.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookList.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookList.ForeColor = System.Drawing.Color.White;
            this.btnBookList.Location = new System.Drawing.Point(16, 129);
            this.btnBookList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Size = new System.Drawing.Size(258, 58);
            this.btnBookList.TabIndex = 39;
            this.btnBookList.Text = "BOOK LIST";
            this.btnBookList.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(596, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 749);
            this.Controls.Add(this.btnBookList);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.btnBookReservation);
            this.Controls.Add(this.btnBookReturning);
            this.Controls.Add(this.btnBookBorrowing);
            this.Controls.Add(this.btnBorrowerList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "BookListForm";
            this.Text = "Crimson Library System | Book List";
            this.Load += new System.EventHandler(this.BookListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnBookList;
        private System.Windows.Forms.ListView lvBookList;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}