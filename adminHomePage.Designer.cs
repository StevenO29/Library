namespace Library
{
    partial class adminHomePage
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
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminHome = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_Books = new System.Windows.Forms.DataGridView();
            this.dgvUsersLoan = new System.Windows.Forms.DataGridView();
            this.panel_AllBooks = new System.Windows.Forms.Panel();
            this.dgv_AllBooks = new System.Windows.Forms.DataGridView();
            this.lbl_TitleAllBooks = new System.Windows.Forms.Label();
            this.panel_SelectBooks = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txtBox_Title = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_EditDetailBook = new System.Windows.Forms.Button();
            this.btn_SaveDetailBook = new System.Windows.Forms.Button();
            this.txtBox_ISBN = new System.Windows.Forms.TextBox();
            this.txtBox_Quantity = new System.Windows.Forms.TextBox();
            this.txtBox_Genre = new System.Windows.Forms.TextBox();
            this.txtBox_Year = new System.Windows.Forms.TextBox();
            this.txtBox_Publisher = new System.Windows.Forms.TextBox();
            this.txtBox_Author = new System.Windows.Forms.TextBox();
            this.txtBox_BookID = new System.Windows.Forms.TextBox();
            this.lbl_TitleISBN = new System.Windows.Forms.Label();
            this.lbl_TitleQuantity = new System.Windows.Forms.Label();
            this.lbl_TitleGenre = new System.Windows.Forms.Label();
            this.lbl_TitlePublicationYear = new System.Windows.Forms.Label();
            this.lbl_TitlePublisher = new System.Windows.Forms.Label();
            this.lbl_TitleAuthor = new System.Windows.Forms.Label();
            this.lbl_TitleBookID = new System.Windows.Forms.Label();
            this.cmbBox_BooksTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_AddBook = new System.Windows.Forms.Panel();
            this.btn_SaveNewBook = new System.Windows.Forms.Button();
            this.btn_AddImage = new System.Windows.Forms.Button();
            this.txtBox_AddISBN = new System.Windows.Forms.TextBox();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbBox_AddGenre = new System.Windows.Forms.ComboBox();
            this.txtBox_AddYear = new System.Windows.Forms.TextBox();
            this.txtBox_AddPublisher = new System.Windows.Forms.TextBox();
            this.txtBox_AddAuthor = new System.Windows.Forms.TextBox();
            this.txtBox_AddTitle = new System.Windows.Forms.TextBox();
            this.lblTitle_NewImage = new System.Windows.Forms.Label();
            this.lblTitle_NewTitle = new System.Windows.Forms.Label();
            this.lblTitle_NewISBN = new System.Windows.Forms.Label();
            this.lblTitle_NewQuantity = new System.Windows.Forms.Label();
            this.lblTitle_NewGenre = new System.Windows.Forms.Label();
            this.lblTitle_NewYear = new System.Windows.Forms.Label();
            this.lblTitle_NewPublisher = new System.Windows.Forms.Label();
            this.lblTitle_NewAuthor = new System.Windows.Forms.Label();
            this.lblTitle_AddNewBook = new System.Windows.Forms.Label();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_ReturnBook = new System.Windows.Forms.Panel();
            this.lblTitle_ReturnBook = new System.Windows.Forms.Label();
            this.lblTitle_Borrower = new System.Windows.Forms.Label();
            this.dgvBorrower = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.lblTitle_History = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersLoan)).BeginInit();
            this.panel_AllBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllBooks)).BeginInit();
            this.panel_SelectBooks.SuspendLayout();
            this.panel_AddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.panel_ReturnBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(12, 38);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(129, 29);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Welcome!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminHome,
            this.catalogToolStripMenuItem,
            this.adminLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminHome
            // 
            this.adminHome.Name = "adminHome";
            this.adminHome.Size = new System.Drawing.Size(64, 24);
            this.adminHome.Text = "Home";
            this.adminHome.Click += new System.EventHandler(this.adminHome_Click);
            // 
            // catalogToolStripMenuItem
            // 
            this.catalogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allBooksToolStripMenuItem,
            this.addBookToolStripMenuItem,
            this.editBooksToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.catalogToolStripMenuItem.Name = "catalogToolStripMenuItem";
            this.catalogToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.catalogToolStripMenuItem.Text = "Catalog";
            // 
            // allBooksToolStripMenuItem
            // 
            this.allBooksToolStripMenuItem.Name = "allBooksToolStripMenuItem";
            this.allBooksToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.allBooksToolStripMenuItem.Text = "All Books";
            this.allBooksToolStripMenuItem.Click += new System.EventHandler(this.allBooksToolStripMenuItem_Click);
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // editBooksToolStripMenuItem
            // 
            this.editBooksToolStripMenuItem.Name = "editBooksToolStripMenuItem";
            this.editBooksToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editBooksToolStripMenuItem.Text = "Edit Book";
            this.editBooksToolStripMenuItem.Click += new System.EventHandler(this.editBooksToolStripMenuItem_Click);
            // 
            // adminLogout
            // 
            this.adminLogout.Name = "adminLogout";
            this.adminLogout.Size = new System.Drawing.Size(70, 24);
            this.adminLogout.Text = "Logout";
            this.adminLogout.Click += new System.EventHandler(this.adminLogout_Click);
            // 
            // dgv_Books
            // 
            this.dgv_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Books.Location = new System.Drawing.Point(17, 70);
            this.dgv_Books.Name = "dgv_Books";
            this.dgv_Books.ReadOnly = true;
            this.dgv_Books.RowHeadersVisible = false;
            this.dgv_Books.RowHeadersWidth = 51;
            this.dgv_Books.RowTemplate.Height = 24;
            this.dgv_Books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Books.Size = new System.Drawing.Size(380, 368);
            this.dgv_Books.TabIndex = 2;
            // 
            // dgvUsersLoan
            // 
            this.dgvUsersLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersLoan.Location = new System.Drawing.Point(408, 70);
            this.dgvUsersLoan.Name = "dgvUsersLoan";
            this.dgvUsersLoan.ReadOnly = true;
            this.dgvUsersLoan.RowHeadersVisible = false;
            this.dgvUsersLoan.RowHeadersWidth = 51;
            this.dgvUsersLoan.RowTemplate.Height = 24;
            this.dgvUsersLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersLoan.Size = new System.Drawing.Size(380, 368);
            this.dgvUsersLoan.TabIndex = 3;
            // 
            // panel_AllBooks
            // 
            this.panel_AllBooks.Controls.Add(this.dgv_AllBooks);
            this.panel_AllBooks.Controls.Add(this.lbl_TitleAllBooks);
            this.panel_AllBooks.Location = new System.Drawing.Point(0, 31);
            this.panel_AllBooks.Name = "panel_AllBooks";
            this.panel_AllBooks.Size = new System.Drawing.Size(800, 419);
            this.panel_AllBooks.TabIndex = 4;
            // 
            // dgv_AllBooks
            // 
            this.dgv_AllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllBooks.Location = new System.Drawing.Point(17, 39);
            this.dgv_AllBooks.Name = "dgv_AllBooks";
            this.dgv_AllBooks.ReadOnly = true;
            this.dgv_AllBooks.RowHeadersVisible = false;
            this.dgv_AllBooks.RowHeadersWidth = 51;
            this.dgv_AllBooks.RowTemplate.Height = 24;
            this.dgv_AllBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AllBooks.Size = new System.Drawing.Size(771, 368);
            this.dgv_AllBooks.TabIndex = 1;
            // 
            // lbl_TitleAllBooks
            // 
            this.lbl_TitleAllBooks.AutoSize = true;
            this.lbl_TitleAllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleAllBooks.Location = new System.Drawing.Point(12, 7);
            this.lbl_TitleAllBooks.Name = "lbl_TitleAllBooks";
            this.lbl_TitleAllBooks.Size = new System.Drawing.Size(123, 29);
            this.lbl_TitleAllBooks.TabIndex = 0;
            this.lbl_TitleAllBooks.Text = "All Books";
            // 
            // panel_SelectBooks
            // 
            this.panel_SelectBooks.Controls.Add(this.btn_Delete);
            this.panel_SelectBooks.Controls.Add(this.txtBox_Title);
            this.panel_SelectBooks.Controls.Add(this.lbl_Title);
            this.panel_SelectBooks.Controls.Add(this.btn_EditDetailBook);
            this.panel_SelectBooks.Controls.Add(this.btn_SaveDetailBook);
            this.panel_SelectBooks.Controls.Add(this.txtBox_ISBN);
            this.panel_SelectBooks.Controls.Add(this.txtBox_Quantity);
            this.panel_SelectBooks.Controls.Add(this.txtBox_Genre);
            this.panel_SelectBooks.Controls.Add(this.txtBox_Year);
            this.panel_SelectBooks.Controls.Add(this.txtBox_Publisher);
            this.panel_SelectBooks.Controls.Add(this.txtBox_Author);
            this.panel_SelectBooks.Controls.Add(this.txtBox_BookID);
            this.panel_SelectBooks.Controls.Add(this.lbl_TitleISBN);
            this.panel_SelectBooks.Controls.Add(this.lbl_TitleQuantity);
            this.panel_SelectBooks.Controls.Add(this.lbl_TitleGenre);
            this.panel_SelectBooks.Controls.Add(this.lbl_TitlePublicationYear);
            this.panel_SelectBooks.Controls.Add(this.lbl_TitlePublisher);
            this.panel_SelectBooks.Controls.Add(this.lbl_TitleAuthor);
            this.panel_SelectBooks.Controls.Add(this.lbl_TitleBookID);
            this.panel_SelectBooks.Controls.Add(this.cmbBox_BooksTitle);
            this.panel_SelectBooks.Controls.Add(this.label1);
            this.panel_SelectBooks.Location = new System.Drawing.Point(0, 31);
            this.panel_SelectBooks.Name = "panel_SelectBooks";
            this.panel_SelectBooks.Size = new System.Drawing.Size(800, 419);
            this.panel_SelectBooks.TabIndex = 5;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(538, 370);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(79, 28);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txtBox_Title
            // 
            this.txtBox_Title.Location = new System.Drawing.Point(192, 96);
            this.txtBox_Title.Name = "txtBox_Title";
            this.txtBox_Title.Size = new System.Drawing.Size(253, 22);
            this.txtBox_Title.TabIndex = 19;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(14, 93);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(60, 25);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "Title :";
            // 
            // btn_EditDetailBook
            // 
            this.btn_EditDetailBook.Location = new System.Drawing.Point(623, 370);
            this.btn_EditDetailBook.Name = "btn_EditDetailBook";
            this.btn_EditDetailBook.Size = new System.Drawing.Size(79, 28);
            this.btn_EditDetailBook.TabIndex = 17;
            this.btn_EditDetailBook.Text = "Edit";
            this.btn_EditDetailBook.UseVisualStyleBackColor = true;
            this.btn_EditDetailBook.Click += new System.EventHandler(this.btn_EditDetailBook_Click);
            // 
            // btn_SaveDetailBook
            // 
            this.btn_SaveDetailBook.BackColor = System.Drawing.Color.Transparent;
            this.btn_SaveDetailBook.Enabled = false;
            this.btn_SaveDetailBook.Location = new System.Drawing.Point(709, 370);
            this.btn_SaveDetailBook.Name = "btn_SaveDetailBook";
            this.btn_SaveDetailBook.Size = new System.Drawing.Size(79, 28);
            this.btn_SaveDetailBook.TabIndex = 16;
            this.btn_SaveDetailBook.Text = "Save";
            this.btn_SaveDetailBook.UseVisualStyleBackColor = false;
            this.btn_SaveDetailBook.Click += new System.EventHandler(this.btn_SaveDetailBook_Click);
            // 
            // txtBox_ISBN
            // 
            this.txtBox_ISBN.Location = new System.Drawing.Point(192, 372);
            this.txtBox_ISBN.Name = "txtBox_ISBN";
            this.txtBox_ISBN.Size = new System.Drawing.Size(253, 22);
            this.txtBox_ISBN.TabIndex = 15;
            // 
            // txtBox_Quantity
            // 
            this.txtBox_Quantity.Location = new System.Drawing.Point(192, 324);
            this.txtBox_Quantity.Name = "txtBox_Quantity";
            this.txtBox_Quantity.Size = new System.Drawing.Size(253, 22);
            this.txtBox_Quantity.TabIndex = 14;
            // 
            // txtBox_Genre
            // 
            this.txtBox_Genre.Location = new System.Drawing.Point(192, 280);
            this.txtBox_Genre.Name = "txtBox_Genre";
            this.txtBox_Genre.Size = new System.Drawing.Size(253, 22);
            this.txtBox_Genre.TabIndex = 13;
            // 
            // txtBox_Year
            // 
            this.txtBox_Year.Location = new System.Drawing.Point(192, 234);
            this.txtBox_Year.Name = "txtBox_Year";
            this.txtBox_Year.Size = new System.Drawing.Size(253, 22);
            this.txtBox_Year.TabIndex = 12;
            // 
            // txtBox_Publisher
            // 
            this.txtBox_Publisher.Location = new System.Drawing.Point(192, 188);
            this.txtBox_Publisher.Name = "txtBox_Publisher";
            this.txtBox_Publisher.Size = new System.Drawing.Size(253, 22);
            this.txtBox_Publisher.TabIndex = 11;
            // 
            // txtBox_Author
            // 
            this.txtBox_Author.Location = new System.Drawing.Point(192, 142);
            this.txtBox_Author.Name = "txtBox_Author";
            this.txtBox_Author.Size = new System.Drawing.Size(253, 22);
            this.txtBox_Author.TabIndex = 10;
            // 
            // txtBox_BookID
            // 
            this.txtBox_BookID.Location = new System.Drawing.Point(192, 56);
            this.txtBox_BookID.Name = "txtBox_BookID";
            this.txtBox_BookID.Size = new System.Drawing.Size(253, 22);
            this.txtBox_BookID.TabIndex = 9;
            // 
            // lbl_TitleISBN
            // 
            this.lbl_TitleISBN.AutoSize = true;
            this.lbl_TitleISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleISBN.Location = new System.Drawing.Point(14, 369);
            this.lbl_TitleISBN.Name = "lbl_TitleISBN";
            this.lbl_TitleISBN.Size = new System.Drawing.Size(69, 25);
            this.lbl_TitleISBN.TabIndex = 8;
            this.lbl_TitleISBN.Text = "ISBN :";
            // 
            // lbl_TitleQuantity
            // 
            this.lbl_TitleQuantity.AutoSize = true;
            this.lbl_TitleQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleQuantity.Location = new System.Drawing.Point(14, 321);
            this.lbl_TitleQuantity.Name = "lbl_TitleQuantity";
            this.lbl_TitleQuantity.Size = new System.Drawing.Size(96, 25);
            this.lbl_TitleQuantity.TabIndex = 7;
            this.lbl_TitleQuantity.Text = "Quantity :";
            // 
            // lbl_TitleGenre
            // 
            this.lbl_TitleGenre.AutoSize = true;
            this.lbl_TitleGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleGenre.Location = new System.Drawing.Point(14, 277);
            this.lbl_TitleGenre.Name = "lbl_TitleGenre";
            this.lbl_TitleGenre.Size = new System.Drawing.Size(77, 25);
            this.lbl_TitleGenre.TabIndex = 6;
            this.lbl_TitleGenre.Text = "Genre :";
            // 
            // lbl_TitlePublicationYear
            // 
            this.lbl_TitlePublicationYear.AutoSize = true;
            this.lbl_TitlePublicationYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitlePublicationYear.Location = new System.Drawing.Point(14, 231);
            this.lbl_TitlePublicationYear.Name = "lbl_TitlePublicationYear";
            this.lbl_TitlePublicationYear.Size = new System.Drawing.Size(164, 25);
            this.lbl_TitlePublicationYear.TabIndex = 5;
            this.lbl_TitlePublicationYear.Text = "Publication Year :";
            // 
            // lbl_TitlePublisher
            // 
            this.lbl_TitlePublisher.AutoSize = true;
            this.lbl_TitlePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitlePublisher.Location = new System.Drawing.Point(14, 185);
            this.lbl_TitlePublisher.Name = "lbl_TitlePublisher";
            this.lbl_TitlePublisher.Size = new System.Drawing.Size(104, 25);
            this.lbl_TitlePublisher.TabIndex = 4;
            this.lbl_TitlePublisher.Text = "Publisher :";
            // 
            // lbl_TitleAuthor
            // 
            this.lbl_TitleAuthor.AutoSize = true;
            this.lbl_TitleAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleAuthor.Location = new System.Drawing.Point(14, 139);
            this.lbl_TitleAuthor.Name = "lbl_TitleAuthor";
            this.lbl_TitleAuthor.Size = new System.Drawing.Size(81, 25);
            this.lbl_TitleAuthor.TabIndex = 3;
            this.lbl_TitleAuthor.Text = "Author :";
            // 
            // lbl_TitleBookID
            // 
            this.lbl_TitleBookID.AutoSize = true;
            this.lbl_TitleBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleBookID.Location = new System.Drawing.Point(14, 53);
            this.lbl_TitleBookID.Name = "lbl_TitleBookID";
            this.lbl_TitleBookID.Size = new System.Drawing.Size(92, 25);
            this.lbl_TitleBookID.TabIndex = 2;
            this.lbl_TitleBookID.Text = "Book ID :";
            // 
            // cmbBox_BooksTitle
            // 
            this.cmbBox_BooksTitle.FormattingEnabled = true;
            this.cmbBox_BooksTitle.Location = new System.Drawing.Point(192, 12);
            this.cmbBox_BooksTitle.Name = "cmbBox_BooksTitle";
            this.cmbBox_BooksTitle.Size = new System.Drawing.Size(253, 24);
            this.cmbBox_BooksTitle.TabIndex = 1;
            this.cmbBox_BooksTitle.SelectedIndexChanged += new System.EventHandler(this.cmbBox_BooksTitle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Book:";
            // 
            // panel_AddBook
            // 
            this.panel_AddBook.Controls.Add(this.btn_SaveNewBook);
            this.panel_AddBook.Controls.Add(this.btn_AddImage);
            this.panel_AddBook.Controls.Add(this.txtBox_AddISBN);
            this.panel_AddBook.Controls.Add(this.numericQuantity);
            this.panel_AddBook.Controls.Add(this.cmbBox_AddGenre);
            this.panel_AddBook.Controls.Add(this.txtBox_AddYear);
            this.panel_AddBook.Controls.Add(this.txtBox_AddPublisher);
            this.panel_AddBook.Controls.Add(this.txtBox_AddAuthor);
            this.panel_AddBook.Controls.Add(this.txtBox_AddTitle);
            this.panel_AddBook.Controls.Add(this.lblTitle_NewImage);
            this.panel_AddBook.Controls.Add(this.lblTitle_NewTitle);
            this.panel_AddBook.Controls.Add(this.lblTitle_NewISBN);
            this.panel_AddBook.Controls.Add(this.lblTitle_NewQuantity);
            this.panel_AddBook.Controls.Add(this.lblTitle_NewGenre);
            this.panel_AddBook.Controls.Add(this.lblTitle_NewYear);
            this.panel_AddBook.Controls.Add(this.lblTitle_NewPublisher);
            this.panel_AddBook.Controls.Add(this.lblTitle_NewAuthor);
            this.panel_AddBook.Controls.Add(this.lblTitle_AddNewBook);
            this.panel_AddBook.Location = new System.Drawing.Point(0, 31);
            this.panel_AddBook.Name = "panel_AddBook";
            this.panel_AddBook.Size = new System.Drawing.Size(800, 419);
            this.panel_AddBook.TabIndex = 21;
            // 
            // btn_SaveNewBook
            // 
            this.btn_SaveNewBook.Location = new System.Drawing.Point(713, 359);
            this.btn_SaveNewBook.Name = "btn_SaveNewBook";
            this.btn_SaveNewBook.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveNewBook.TabIndex = 35;
            this.btn_SaveNewBook.Text = "Save";
            this.btn_SaveNewBook.UseVisualStyleBackColor = true;
            this.btn_SaveNewBook.Click += new System.EventHandler(this.btn_SaveNewBook_Click);
            // 
            // btn_AddImage
            // 
            this.btn_AddImage.Location = new System.Drawing.Point(220, 360);
            this.btn_AddImage.Name = "btn_AddImage";
            this.btn_AddImage.Size = new System.Drawing.Size(75, 23);
            this.btn_AddImage.TabIndex = 34;
            this.btn_AddImage.Text = "Upload";
            this.btn_AddImage.UseVisualStyleBackColor = true;
            this.btn_AddImage.Click += new System.EventHandler(this.btn_AddImage_Click);
            // 
            // txtBox_AddISBN
            // 
            this.txtBox_AddISBN.Location = new System.Drawing.Point(220, 321);
            this.txtBox_AddISBN.Name = "txtBox_AddISBN";
            this.txtBox_AddISBN.Size = new System.Drawing.Size(285, 22);
            this.txtBox_AddISBN.TabIndex = 33;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(220, 280);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(120, 22);
            this.numericQuantity.TabIndex = 32;
            // 
            // cmbBox_AddGenre
            // 
            this.cmbBox_AddGenre.FormattingEnabled = true;
            this.cmbBox_AddGenre.Location = new System.Drawing.Point(220, 234);
            this.cmbBox_AddGenre.Name = "cmbBox_AddGenre";
            this.cmbBox_AddGenre.Size = new System.Drawing.Size(285, 24);
            this.cmbBox_AddGenre.TabIndex = 31;
            // 
            // txtBox_AddYear
            // 
            this.txtBox_AddYear.Location = new System.Drawing.Point(220, 188);
            this.txtBox_AddYear.Name = "txtBox_AddYear";
            this.txtBox_AddYear.Size = new System.Drawing.Size(285, 22);
            this.txtBox_AddYear.TabIndex = 30;
            // 
            // txtBox_AddPublisher
            // 
            this.txtBox_AddPublisher.Location = new System.Drawing.Point(220, 143);
            this.txtBox_AddPublisher.Name = "txtBox_AddPublisher";
            this.txtBox_AddPublisher.Size = new System.Drawing.Size(285, 22);
            this.txtBox_AddPublisher.TabIndex = 29;
            // 
            // txtBox_AddAuthor
            // 
            this.txtBox_AddAuthor.Location = new System.Drawing.Point(220, 96);
            this.txtBox_AddAuthor.Name = "txtBox_AddAuthor";
            this.txtBox_AddAuthor.Size = new System.Drawing.Size(285, 22);
            this.txtBox_AddAuthor.TabIndex = 28;
            // 
            // txtBox_AddTitle
            // 
            this.txtBox_AddTitle.Location = new System.Drawing.Point(220, 53);
            this.txtBox_AddTitle.Name = "txtBox_AddTitle";
            this.txtBox_AddTitle.Size = new System.Drawing.Size(285, 22);
            this.txtBox_AddTitle.TabIndex = 27;
            // 
            // lblTitle_NewImage
            // 
            this.lblTitle_NewImage.AutoSize = true;
            this.lblTitle_NewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_NewImage.Location = new System.Drawing.Point(14, 359);
            this.lblTitle_NewImage.Name = "lblTitle_NewImage";
            this.lblTitle_NewImage.Size = new System.Drawing.Size(126, 25);
            this.lblTitle_NewImage.TabIndex = 26;
            this.lblTitle_NewImage.Text = "Book Cover :";
            // 
            // lblTitle_NewTitle
            // 
            this.lblTitle_NewTitle.AutoSize = true;
            this.lblTitle_NewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_NewTitle.Location = new System.Drawing.Point(14, 50);
            this.lblTitle_NewTitle.Name = "lblTitle_NewTitle";
            this.lblTitle_NewTitle.Size = new System.Drawing.Size(60, 25);
            this.lblTitle_NewTitle.TabIndex = 25;
            this.lblTitle_NewTitle.Text = "Title :";
            // 
            // lblTitle_NewISBN
            // 
            this.lblTitle_NewISBN.AutoSize = true;
            this.lblTitle_NewISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_NewISBN.Location = new System.Drawing.Point(14, 318);
            this.lblTitle_NewISBN.Name = "lblTitle_NewISBN";
            this.lblTitle_NewISBN.Size = new System.Drawing.Size(69, 25);
            this.lblTitle_NewISBN.TabIndex = 24;
            this.lblTitle_NewISBN.Text = "ISBN :";
            // 
            // lblTitle_NewQuantity
            // 
            this.lblTitle_NewQuantity.AutoSize = true;
            this.lblTitle_NewQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_NewQuantity.Location = new System.Drawing.Point(14, 275);
            this.lblTitle_NewQuantity.Name = "lblTitle_NewQuantity";
            this.lblTitle_NewQuantity.Size = new System.Drawing.Size(96, 25);
            this.lblTitle_NewQuantity.TabIndex = 23;
            this.lblTitle_NewQuantity.Text = "Quantity :";
            // 
            // lblTitle_NewGenre
            // 
            this.lblTitle_NewGenre.AutoSize = true;
            this.lblTitle_NewGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_NewGenre.Location = new System.Drawing.Point(14, 234);
            this.lblTitle_NewGenre.Name = "lblTitle_NewGenre";
            this.lblTitle_NewGenre.Size = new System.Drawing.Size(77, 25);
            this.lblTitle_NewGenre.TabIndex = 22;
            this.lblTitle_NewGenre.Text = "Genre :";
            // 
            // lblTitle_NewYear
            // 
            this.lblTitle_NewYear.AutoSize = true;
            this.lblTitle_NewYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_NewYear.Location = new System.Drawing.Point(14, 188);
            this.lblTitle_NewYear.Name = "lblTitle_NewYear";
            this.lblTitle_NewYear.Size = new System.Drawing.Size(164, 25);
            this.lblTitle_NewYear.TabIndex = 21;
            this.lblTitle_NewYear.Text = "Publication Year :";
            // 
            // lblTitle_NewPublisher
            // 
            this.lblTitle_NewPublisher.AutoSize = true;
            this.lblTitle_NewPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_NewPublisher.Location = new System.Drawing.Point(14, 142);
            this.lblTitle_NewPublisher.Name = "lblTitle_NewPublisher";
            this.lblTitle_NewPublisher.Size = new System.Drawing.Size(104, 25);
            this.lblTitle_NewPublisher.TabIndex = 20;
            this.lblTitle_NewPublisher.Text = "Publisher :";
            // 
            // lblTitle_NewAuthor
            // 
            this.lblTitle_NewAuthor.AutoSize = true;
            this.lblTitle_NewAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_NewAuthor.Location = new System.Drawing.Point(14, 96);
            this.lblTitle_NewAuthor.Name = "lblTitle_NewAuthor";
            this.lblTitle_NewAuthor.Size = new System.Drawing.Size(81, 25);
            this.lblTitle_NewAuthor.TabIndex = 19;
            this.lblTitle_NewAuthor.Text = "Author :";
            // 
            // lblTitle_AddNewBook
            // 
            this.lblTitle_AddNewBook.AutoSize = true;
            this.lblTitle_AddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_AddNewBook.Location = new System.Drawing.Point(12, 7);
            this.lblTitle_AddNewBook.Name = "lblTitle_AddNewBook";
            this.lblTitle_AddNewBook.Size = new System.Drawing.Size(193, 29);
            this.lblTitle_AddNewBook.TabIndex = 1;
            this.lblTitle_AddNewBook.Text = "Add New Book:";
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // panel_ReturnBook
            // 
            this.panel_ReturnBook.Controls.Add(this.lblTitle_History);
            this.panel_ReturnBook.Controls.Add(this.dgvHistory);
            this.panel_ReturnBook.Controls.Add(this.btnReturn);
            this.panel_ReturnBook.Controls.Add(this.dgvBorrower);
            this.panel_ReturnBook.Controls.Add(this.lblTitle_Borrower);
            this.panel_ReturnBook.Controls.Add(this.lblTitle_ReturnBook);
            this.panel_ReturnBook.Location = new System.Drawing.Point(0, 31);
            this.panel_ReturnBook.Name = "panel_ReturnBook";
            this.panel_ReturnBook.Size = new System.Drawing.Size(800, 419);
            this.panel_ReturnBook.TabIndex = 36;
            // 
            // lblTitle_ReturnBook
            // 
            this.lblTitle_ReturnBook.AutoSize = true;
            this.lblTitle_ReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_ReturnBook.Location = new System.Drawing.Point(12, 7);
            this.lblTitle_ReturnBook.Name = "lblTitle_ReturnBook";
            this.lblTitle_ReturnBook.Size = new System.Drawing.Size(157, 29);
            this.lblTitle_ReturnBook.TabIndex = 0;
            this.lblTitle_ReturnBook.Text = "Return Book";
            // 
            // lblTitle_Borrower
            // 
            this.lblTitle_Borrower.AutoSize = true;
            this.lblTitle_Borrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_Borrower.Location = new System.Drawing.Point(13, 39);
            this.lblTitle_Borrower.Name = "lblTitle_Borrower";
            this.lblTitle_Borrower.Size = new System.Drawing.Size(88, 20);
            this.lblTitle_Borrower.TabIndex = 1;
            this.lblTitle_Borrower.Text = "Borrower :";
            // 
            // dgvBorrower
            // 
            this.dgvBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrower.Location = new System.Drawing.Point(17, 62);
            this.dgvBorrower.Name = "dgvBorrower";
            this.dgvBorrower.RowHeadersVisible = false;
            this.dgvBorrower.RowHeadersWidth = 51;
            this.dgvBorrower.RowTemplate.Height = 24;
            this.dgvBorrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrower.Size = new System.Drawing.Size(307, 345);
            this.dgvBorrower.TabIndex = 2;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(365, 212);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 30);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(481, 62);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(307, 345);
            this.dgvHistory.TabIndex = 4;
            // 
            // lblTitle_History
            // 
            this.lblTitle_History.AutoSize = true;
            this.lblTitle_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle_History.Location = new System.Drawing.Point(477, 39);
            this.lblTitle_History.Name = "lblTitle_History";
            this.lblTitle_History.Size = new System.Drawing.Size(73, 20);
            this.lblTitle_History.TabIndex = 5;
            this.lblTitle_History.Text = "History :";
            // 
            // adminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_ReturnBook);
            this.Controls.Add(this.panel_AddBook);
            this.Controls.Add(this.panel_SelectBooks);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.dgvUsersLoan);
            this.Controls.Add(this.dgv_Books);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_AllBooks);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminHomePage_FormClosing);
            this.Load += new System.EventHandler(this.adminHomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersLoan)).EndInit();
            this.panel_AllBooks.ResumeLayout(false);
            this.panel_AllBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllBooks)).EndInit();
            this.panel_SelectBooks.ResumeLayout(false);
            this.panel_SelectBooks.PerformLayout();
            this.panel_AddBook.ResumeLayout(false);
            this.panel_AddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.panel_ReturnBook.ResumeLayout(false);
            this.panel_ReturnBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminHome;
        private System.Windows.Forms.ToolStripMenuItem catalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminLogout;
        private System.Windows.Forms.DataGridView dgv_Books;
        private System.Windows.Forms.DataGridView dgvUsersLoan;
        private System.Windows.Forms.ToolStripMenuItem allBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBooksToolStripMenuItem;
        private System.Windows.Forms.Panel panel_AllBooks;
        private System.Windows.Forms.DataGridView dgv_AllBooks;
        private System.Windows.Forms.Label lbl_TitleAllBooks;
        private System.Windows.Forms.Panel panel_SelectBooks;
        private System.Windows.Forms.ComboBox cmbBox_BooksTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TitleAuthor;
        private System.Windows.Forms.Label lbl_TitleBookID;
        private System.Windows.Forms.Button btn_EditDetailBook;
        private System.Windows.Forms.Button btn_SaveDetailBook;
        private System.Windows.Forms.TextBox txtBox_ISBN;
        private System.Windows.Forms.TextBox txtBox_Quantity;
        private System.Windows.Forms.TextBox txtBox_Genre;
        private System.Windows.Forms.TextBox txtBox_Year;
        private System.Windows.Forms.TextBox txtBox_Publisher;
        private System.Windows.Forms.TextBox txtBox_Author;
        private System.Windows.Forms.TextBox txtBox_BookID;
        private System.Windows.Forms.Label lbl_TitleISBN;
        private System.Windows.Forms.Label lbl_TitleQuantity;
        private System.Windows.Forms.Label lbl_TitleGenre;
        private System.Windows.Forms.Label lbl_TitlePublicationYear;
        private System.Windows.Forms.Label lbl_TitlePublisher;
        private System.Windows.Forms.TextBox txtBox_Title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.Panel panel_AddBook;
        private System.Windows.Forms.Button btn_SaveNewBook;
        private System.Windows.Forms.Button btn_AddImage;
        private System.Windows.Forms.TextBox txtBox_AddISBN;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.ComboBox cmbBox_AddGenre;
        private System.Windows.Forms.TextBox txtBox_AddYear;
        private System.Windows.Forms.TextBox txtBox_AddPublisher;
        private System.Windows.Forms.TextBox txtBox_AddAuthor;
        private System.Windows.Forms.TextBox txtBox_AddTitle;
        private System.Windows.Forms.Label lblTitle_NewImage;
        private System.Windows.Forms.Label lblTitle_NewTitle;
        private System.Windows.Forms.Label lblTitle_NewISBN;
        private System.Windows.Forms.Label lblTitle_NewQuantity;
        private System.Windows.Forms.Label lblTitle_NewGenre;
        private System.Windows.Forms.Label lblTitle_NewYear;
        private System.Windows.Forms.Label lblTitle_NewPublisher;
        private System.Windows.Forms.Label lblTitle_NewAuthor;
        private System.Windows.Forms.Label lblTitle_AddNewBook;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.Panel panel_ReturnBook;
        private System.Windows.Forms.Label lblTitle_History;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvBorrower;
        private System.Windows.Forms.Label lblTitle_Borrower;
        private System.Windows.Forms.Label lblTitle_ReturnBook;
    }
}