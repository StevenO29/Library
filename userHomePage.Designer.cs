namespace Library
{
    partial class userHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userHomePage));
            this.lblUser_TitleHome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userHome = new System.Windows.Forms.ToolStripMenuItem();
            this.userLoans = new System.Windows.Forms.ToolStripMenuItem();
            this.userLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_AvailableBooks = new System.Windows.Forms.ListBox();
            this.lbl_BookTitle = new System.Windows.Forms.Label();
            this.lbl_TitleAuthor = new System.Windows.Forms.Label();
            this.lbl_TitlePublisher = new System.Windows.Forms.Label();
            this.lbl_TitleYear = new System.Windows.Forms.Label();
            this.lblTitle_Genre = new System.Windows.Forms.Label();
            this.lbl_TitleISBN = new System.Windows.Forms.Label();
            this.lbl_TitleAvail = new System.Windows.Forms.Label();
            this.lbl_BookAuthor = new System.Windows.Forms.Label();
            this.lbl_BookPublisher = new System.Windows.Forms.Label();
            this.lbl_BookYear = new System.Windows.Forms.Label();
            this.lbl_BookGenre = new System.Windows.Forms.Label();
            this.lbl_BookISBN = new System.Windows.Forms.Label();
            this.lbl_BookAvail = new System.Windows.Forms.Label();
            this.panel_MyLoans = new System.Windows.Forms.Panel();
            this.dgvReturnedBooks = new System.Windows.Forms.DataGridView();
            this.lblTitle_ReturnedBooks = new System.Windows.Forms.Label();
            this.dgvUserLoans = new System.Windows.Forms.DataGridView();
            this.lblTitle_MyLoans = new System.Windows.Forms.Label();
            this.btnLoan = new System.Windows.Forms.Button();
            this.lbl_TitleOverdue = new System.Windows.Forms.Label();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.picBoxBook = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel_MyLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBook)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser_TitleHome
            // 
            this.lblUser_TitleHome.AutoSize = true;
            this.lblUser_TitleHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser_TitleHome.Location = new System.Drawing.Point(12, 39);
            this.lblUser_TitleHome.Name = "lblUser_TitleHome";
            this.lblUser_TitleHome.Size = new System.Drawing.Size(129, 29);
            this.lblUser_TitleHome.TabIndex = 0;
            this.lblUser_TitleHome.Text = "Welcome!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userHome,
            this.userLoans,
            this.userLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userHome
            // 
            this.userHome.Name = "userHome";
            this.userHome.Size = new System.Drawing.Size(64, 24);
            this.userHome.Text = "Home";
            this.userHome.Click += new System.EventHandler(this.userHome_Click);
            // 
            // userLoans
            // 
            this.userLoans.Name = "userLoans";
            this.userLoans.Size = new System.Drawing.Size(85, 24);
            this.userLoans.Text = "My Loans";
            this.userLoans.Click += new System.EventHandler(this.userLoans_Click);
            // 
            // userLogout
            // 
            this.userLogout.Name = "userLogout";
            this.userLogout.Size = new System.Drawing.Size(70, 24);
            this.userLogout.Text = "Logout";
            this.userLogout.Click += new System.EventHandler(this.userLogout_Click);
            // 
            // listBox_AvailableBooks
            // 
            this.listBox_AvailableBooks.FormattingEnabled = true;
            this.listBox_AvailableBooks.ItemHeight = 16;
            this.listBox_AvailableBooks.Location = new System.Drawing.Point(17, 72);
            this.listBox_AvailableBooks.Name = "listBox_AvailableBooks";
            this.listBox_AvailableBooks.Size = new System.Drawing.Size(243, 356);
            this.listBox_AvailableBooks.TabIndex = 2;
            this.listBox_AvailableBooks.SelectedIndexChanged += new System.EventHandler(this.listBox_AvailableBooks_SelectedIndexChanged);
            // 
            // lbl_BookTitle
            // 
            this.lbl_BookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BookTitle.Location = new System.Drawing.Point(342, 218);
            this.lbl_BookTitle.Name = "lbl_BookTitle";
            this.lbl_BookTitle.Size = new System.Drawing.Size(397, 27);
            this.lbl_BookTitle.TabIndex = 4;
            this.lbl_BookTitle.Text = "Title";
            this.lbl_BookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TitleAuthor
            // 
            this.lbl_TitleAuthor.AutoSize = true;
            this.lbl_TitleAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleAuthor.Location = new System.Drawing.Point(312, 255);
            this.lbl_TitleAuthor.Name = "lbl_TitleAuthor";
            this.lbl_TitleAuthor.Size = new System.Drawing.Size(59, 16);
            this.lbl_TitleAuthor.TabIndex = 5;
            this.lbl_TitleAuthor.Text = "Author :";
            // 
            // lbl_TitlePublisher
            // 
            this.lbl_TitlePublisher.AutoSize = true;
            this.lbl_TitlePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitlePublisher.Location = new System.Drawing.Point(312, 282);
            this.lbl_TitlePublisher.Name = "lbl_TitlePublisher";
            this.lbl_TitlePublisher.Size = new System.Drawing.Size(80, 16);
            this.lbl_TitlePublisher.TabIndex = 6;
            this.lbl_TitlePublisher.Text = "Publisher :";
            // 
            // lbl_TitleYear
            // 
            this.lbl_TitleYear.AutoSize = true;
            this.lbl_TitleYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleYear.Location = new System.Drawing.Point(312, 307);
            this.lbl_TitleYear.Name = "lbl_TitleYear";
            this.lbl_TitleYear.Size = new System.Drawing.Size(129, 16);
            this.lbl_TitleYear.TabIndex = 7;
            this.lbl_TitleYear.Text = "Publication Year :";
            // 
            // lblTitle_Genre
            // 
            this.lblTitle_Genre.AutoSize = true;
            this.lblTitle_Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_Genre.Location = new System.Drawing.Point(312, 332);
            this.lblTitle_Genre.Name = "lblTitle_Genre";
            this.lblTitle_Genre.Size = new System.Drawing.Size(57, 16);
            this.lblTitle_Genre.TabIndex = 8;
            this.lblTitle_Genre.Text = "Genre :";
            // 
            // lbl_TitleISBN
            // 
            this.lbl_TitleISBN.AutoSize = true;
            this.lbl_TitleISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleISBN.Location = new System.Drawing.Point(312, 357);
            this.lbl_TitleISBN.Name = "lbl_TitleISBN";
            this.lbl_TitleISBN.Size = new System.Drawing.Size(50, 16);
            this.lbl_TitleISBN.TabIndex = 9;
            this.lbl_TitleISBN.Text = "ISBN :";
            // 
            // lbl_TitleAvail
            // 
            this.lbl_TitleAvail.AutoSize = true;
            this.lbl_TitleAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleAvail.Location = new System.Drawing.Point(312, 382);
            this.lbl_TitleAvail.Name = "lbl_TitleAvail";
            this.lbl_TitleAvail.Size = new System.Drawing.Size(81, 16);
            this.lbl_TitleAvail.TabIndex = 10;
            this.lbl_TitleAvail.Text = "Available :";
            // 
            // lbl_BookAuthor
            // 
            this.lbl_BookAuthor.AutoSize = true;
            this.lbl_BookAuthor.Location = new System.Drawing.Point(456, 255);
            this.lbl_BookAuthor.Name = "lbl_BookAuthor";
            this.lbl_BookAuthor.Size = new System.Drawing.Size(45, 16);
            this.lbl_BookAuthor.TabIndex = 11;
            this.lbl_BookAuthor.Text = "Author";
            // 
            // lbl_BookPublisher
            // 
            this.lbl_BookPublisher.AutoSize = true;
            this.lbl_BookPublisher.Location = new System.Drawing.Point(456, 282);
            this.lbl_BookPublisher.Name = "lbl_BookPublisher";
            this.lbl_BookPublisher.Size = new System.Drawing.Size(63, 16);
            this.lbl_BookPublisher.TabIndex = 12;
            this.lbl_BookPublisher.Text = "Publisher";
            // 
            // lbl_BookYear
            // 
            this.lbl_BookYear.AutoSize = true;
            this.lbl_BookYear.Location = new System.Drawing.Point(456, 307);
            this.lbl_BookYear.Name = "lbl_BookYear";
            this.lbl_BookYear.Size = new System.Drawing.Size(36, 16);
            this.lbl_BookYear.TabIndex = 13;
            this.lbl_BookYear.Text = "Year";
            // 
            // lbl_BookGenre
            // 
            this.lbl_BookGenre.AutoSize = true;
            this.lbl_BookGenre.Location = new System.Drawing.Point(456, 332);
            this.lbl_BookGenre.Name = "lbl_BookGenre";
            this.lbl_BookGenre.Size = new System.Drawing.Size(44, 16);
            this.lbl_BookGenre.TabIndex = 14;
            this.lbl_BookGenre.Text = "Genre";
            // 
            // lbl_BookISBN
            // 
            this.lbl_BookISBN.AutoSize = true;
            this.lbl_BookISBN.Location = new System.Drawing.Point(456, 357);
            this.lbl_BookISBN.Name = "lbl_BookISBN";
            this.lbl_BookISBN.Size = new System.Drawing.Size(38, 16);
            this.lbl_BookISBN.TabIndex = 15;
            this.lbl_BookISBN.Text = "ISBN";
            // 
            // lbl_BookAvail
            // 
            this.lbl_BookAvail.AutoSize = true;
            this.lbl_BookAvail.Location = new System.Drawing.Point(456, 382);
            this.lbl_BookAvail.Name = "lbl_BookAvail";
            this.lbl_BookAvail.Size = new System.Drawing.Size(31, 16);
            this.lbl_BookAvail.TabIndex = 16;
            this.lbl_BookAvail.Text = "Yes";
            // 
            // panel_MyLoans
            // 
            this.panel_MyLoans.Controls.Add(this.dgvReturnedBooks);
            this.panel_MyLoans.Controls.Add(this.lblTitle_ReturnedBooks);
            this.panel_MyLoans.Controls.Add(this.dgvUserLoans);
            this.panel_MyLoans.Controls.Add(this.lblTitle_MyLoans);
            this.panel_MyLoans.Location = new System.Drawing.Point(0, 31);
            this.panel_MyLoans.Name = "panel_MyLoans";
            this.panel_MyLoans.Size = new System.Drawing.Size(800, 419);
            this.panel_MyLoans.TabIndex = 17;
            // 
            // dgvReturnedBooks
            // 
            this.dgvReturnedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnedBooks.Location = new System.Drawing.Point(12, 243);
            this.dgvReturnedBooks.Name = "dgvReturnedBooks";
            this.dgvReturnedBooks.ReadOnly = true;
            this.dgvReturnedBooks.RowHeadersVisible = false;
            this.dgvReturnedBooks.RowHeadersWidth = 51;
            this.dgvReturnedBooks.RowTemplate.Height = 24;
            this.dgvReturnedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturnedBooks.Size = new System.Drawing.Size(776, 155);
            this.dgvReturnedBooks.TabIndex = 6;
            // 
            // lblTitle_ReturnedBooks
            // 
            this.lblTitle_ReturnedBooks.AutoSize = true;
            this.lblTitle_ReturnedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_ReturnedBooks.Location = new System.Drawing.Point(7, 211);
            this.lblTitle_ReturnedBooks.Name = "lblTitle_ReturnedBooks";
            this.lblTitle_ReturnedBooks.Size = new System.Drawing.Size(200, 29);
            this.lblTitle_ReturnedBooks.TabIndex = 5;
            this.lblTitle_ReturnedBooks.Text = "Returned Books";
            // 
            // dgvUserLoans
            // 
            this.dgvUserLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserLoans.Location = new System.Drawing.Point(12, 42);
            this.dgvUserLoans.Name = "dgvUserLoans";
            this.dgvUserLoans.ReadOnly = true;
            this.dgvUserLoans.RowHeadersVisible = false;
            this.dgvUserLoans.RowHeadersWidth = 51;
            this.dgvUserLoans.RowTemplate.Height = 24;
            this.dgvUserLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserLoans.Size = new System.Drawing.Size(776, 155);
            this.dgvUserLoans.TabIndex = 4;
            // 
            // lblTitle_MyLoans
            // 
            this.lblTitle_MyLoans.AutoSize = true;
            this.lblTitle_MyLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_MyLoans.Location = new System.Drawing.Point(7, 10);
            this.lblTitle_MyLoans.Name = "lblTitle_MyLoans";
            this.lblTitle_MyLoans.Size = new System.Drawing.Size(123, 29);
            this.lblTitle_MyLoans.TabIndex = 0;
            this.lblTitle_MyLoans.Text = "My Loans";
            // 
            // btnLoan
            // 
            this.btnLoan.Location = new System.Drawing.Point(713, 405);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(75, 23);
            this.btnLoan.TabIndex = 3;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // lbl_TitleOverdue
            // 
            this.lbl_TitleOverdue.AutoSize = true;
            this.lbl_TitleOverdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleOverdue.ForeColor = System.Drawing.Color.Red;
            this.lbl_TitleOverdue.Location = new System.Drawing.Point(312, 407);
            this.lbl_TitleOverdue.Name = "lbl_TitleOverdue";
            this.lbl_TitleOverdue.Size = new System.Drawing.Size(74, 16);
            this.lbl_TitleOverdue.TabIndex = 19;
            this.lbl_TitleOverdue.Text = "Overdue :";
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.ForeColor = System.Drawing.Color.Red;
            this.lblOverdue.Location = new System.Drawing.Point(456, 407);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(25, 16);
            this.lblOverdue.TabIndex = 20;
            this.lblOverdue.Text = "No";
            // 
            // picBoxBook
            // 
            this.picBoxBook.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBook.Image")));
            this.picBoxBook.Location = new System.Drawing.Point(485, 46);
            this.picBoxBook.Name = "picBoxBook";
            this.picBoxBook.Size = new System.Drawing.Size(107, 169);
            this.picBoxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBook.TabIndex = 3;
            this.picBoxBook.TabStop = false;
            // 
            // userHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_MyLoans);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.lbl_BookAvail);
            this.Controls.Add(this.lbl_BookISBN);
            this.Controls.Add(this.lbl_BookGenre);
            this.Controls.Add(this.lbl_BookYear);
            this.Controls.Add(this.lbl_BookPublisher);
            this.Controls.Add(this.lbl_BookAuthor);
            this.Controls.Add(this.lbl_TitleAvail);
            this.Controls.Add(this.lbl_TitleISBN);
            this.Controls.Add(this.lblTitle_Genre);
            this.Controls.Add(this.lbl_TitleYear);
            this.Controls.Add(this.lbl_TitlePublisher);
            this.Controls.Add(this.lbl_TitleAuthor);
            this.Controls.Add(this.lbl_BookTitle);
            this.Controls.Add(this.picBoxBook);
            this.Controls.Add(this.listBox_AvailableBooks);
            this.Controls.Add(this.lblUser_TitleHome);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_TitleOverdue);
            this.Controls.Add(this.lblOverdue);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "userHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userHomePage_FormClosing);
            this.Load += new System.EventHandler(this.userHomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_MyLoans.ResumeLayout(false);
            this.panel_MyLoans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser_TitleHome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userHome;
        private System.Windows.Forms.ToolStripMenuItem userLogout;
        private System.Windows.Forms.ListBox listBox_AvailableBooks;
        private System.Windows.Forms.PictureBox picBoxBook;
        private System.Windows.Forms.Label lbl_BookTitle;
        private System.Windows.Forms.Label lbl_TitleAuthor;
        private System.Windows.Forms.Label lbl_TitlePublisher;
        private System.Windows.Forms.Label lbl_TitleYear;
        private System.Windows.Forms.Label lblTitle_Genre;
        private System.Windows.Forms.Label lbl_TitleISBN;
        private System.Windows.Forms.Label lbl_TitleAvail;
        private System.Windows.Forms.Label lbl_BookAuthor;
        private System.Windows.Forms.Label lbl_BookPublisher;
        private System.Windows.Forms.Label lbl_BookYear;
        private System.Windows.Forms.Label lbl_BookGenre;
        private System.Windows.Forms.Label lbl_BookISBN;
        private System.Windows.Forms.Label lbl_BookAvail;
        private System.Windows.Forms.ToolStripMenuItem userLoans;
        private System.Windows.Forms.Panel panel_MyLoans;
        private System.Windows.Forms.Label lblTitle_MyLoans;
        private System.Windows.Forms.DataGridView dgvUserLoans;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.DataGridView dgvReturnedBooks;
        private System.Windows.Forms.Label lblTitle_ReturnedBooks;
        private System.Windows.Forms.Label lbl_TitleOverdue;
        private System.Windows.Forms.Label lblOverdue;
    }
}