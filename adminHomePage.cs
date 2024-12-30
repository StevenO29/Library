using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class adminHomePage : Form
    {

        public static string sqlConnection = "server = localhost;uid=root;pwd=;database=Library";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //Sebagai data koneksi ke DBMS
        public MySqlCommand sqlCommand; //Sebagai perintah SQL (select, insert, update, delete)
        public MySqlDataAdapter sqlAdapter; //Sebagai menampung hasil query
        public string sqlQuery; //Sebagai penampung query SQL

        // Array genre
        private string[] genres = { "Action", "Adventure", "Comedy", "Drama", "Fantasy", "Horror", "Mystery", "Romance", "Sci-Fi", "Thriller" };
        private string bookCoverPath = "";

        public adminHomePage()
        {
            InitializeComponent();
            cmbBox_BooksTitle.SelectedIndexChanged += cmbBox_BooksTitle_SelectedIndexChanged;
            txtBox_Year.KeyPress += txtBox_KeyPress_AllowOnlyNumbers;
            txtBox_Quantity.KeyPress += txtBox_KeyPress_AllowOnlyNumbers;
            txtBox_ISBN.KeyPress += txtBox_KeyPress_AllowOnlyNumbers;
        }

        private void adminHomePage_Load(object sender, EventArgs e)
        {
            cmbBox_AddGenre.Items.Clear(); // Bersihkan jika ada data sebelumnya
            cmbBox_AddGenre.Items.AddRange(genres);

            btn_SaveDetailBook.Enabled = false;
            txtBox_Title.ReadOnly = true;
            txtBox_BookID.ReadOnly = true;
            txtBox_Author.ReadOnly = true;
            txtBox_Publisher.ReadOnly = true;
            txtBox_Year.ReadOnly = true;
            txtBox_Genre.ReadOnly = true;
            txtBox_Quantity.ReadOnly = true;
            txtBox_ISBN.ReadOnly = true;

            LoadBooks();
            LoadUserLoans();

            try
            {
                panel_AllBooks.Visible = false;
                panel_SelectBooks.Visible = false;
                panel_AddBook.Visible = false;
                panel_ReturnBook.Visible = false;

                // Definisikan query SQL
                sqlQuery = "SELECT quantity AS \"Quantity\", title AS \"Title\", author AS \"Author\", genre AS \"Genre\" FROM books ORDER BY title;";

                // Siapkan command dan adapter
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                // Isi DataTable dengan hasil query
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);

                // Tampilkan DataTable ke DataGridView
                dgv_Books.DataSource = dataTable;
                dgv_Books.ClearSelection();
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika terjadi masalah
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void adminHome_Click(object sender, EventArgs e)
        {
            panel_AllBooks.Visible = false;
            panel_SelectBooks.Visible = false;
            panel_AddBook.Visible = false;
            panel_ReturnBook.Visible = false;
        }

        private void allBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel_SelectBooks.Visible = false;
                panel_AddBook.Visible = false;
                panel_AllBooks.Visible = true;
                panel_AllBooks.BringToFront();

                // Definisikan query SQL
                sqlQuery = "SELECT book_id AS \"BookID\", title AS \"Title\", author AS \"Author\", publisher AS \"Publisher\", publication_year AS \"Year\", genre AS \"Genre\", isbn AS \"ISBN\", quantity AS \"Quantity\" FROM books ORDER BY title;";

                // Siapkan command dan adapter
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                // Isi DataTable dengan hasil query
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);

                // Tampilkan DataTable ke DataGridView
                dgv_AllBooks.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika terjadi masalah
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_AllBooks.Visible = false;
            panel_SelectBooks.Visible = false;
            panel_ReturnBook.Visible = false;
            panel_AddBook.Visible = true;
            panel_AddBook.BringToFront();
        }

        private void editBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                panel_AllBooks.Visible = false;
                panel_AddBook.Visible = false;
                panel_SelectBooks.Visible = true;
                panel_SelectBooks.BringToFront();

                // Definisikan query SQL
                sqlQuery = "SELECT title AS \"Title\" FROM books ORDER BY title;";

                // Siapkan command dan adapter
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                // Isi DataTable dengan hasil query
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);

                // Tampilkan DataTable ke ComboBox
                cmbBox_BooksTitle.DisplayMember = "Title"; // Tentukan kolom yang ditampilkan
                cmbBox_BooksTitle.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika terjadi masalah
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbBox_BooksTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Ambil judul buku yang dipilih dari ComboBox
                string selectedTitle = cmbBox_BooksTitle.Text;

                // Definisikan query SQL untuk mendapatkan detail buku berdasarkan judul
                sqlQuery = "SELECT title, book_id, author, publisher, publication_year, genre, quantity, isbn FROM books WHERE title = @title";

                // Siapkan command
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@title", selectedTitle);

                // Eksekusi query dan baca hasilnya
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    // Isi TextBox dengan data dari hasil query
                    txtBox_Title.Text = reader["title"].ToString();
                    txtBox_BookID.Text = reader["book_id"].ToString();
                    txtBox_Author.Text = reader["author"].ToString();
                    txtBox_Publisher.Text = reader["publisher"].ToString();
                    txtBox_Year.Text = reader["publication_year"].ToString();
                    txtBox_Genre.Text = reader["genre"].ToString();
                    txtBox_Quantity.Text = reader["quantity"].ToString();
                    txtBox_ISBN.Text = reader["isbn"].ToString();
                }

                // Tutup reader
                reader.Close();
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika terjadi masalah
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_EditDetailBook_Click(object sender, EventArgs e)
        {
            btn_EditDetailBook.Enabled = false;
            btn_SaveDetailBook.Enabled = true;
            txtBox_Title.ReadOnly = false;
            txtBox_Author.ReadOnly = false;
            txtBox_Publisher.ReadOnly = false;
            txtBox_Year.ReadOnly = false;
            txtBox_Genre.ReadOnly = false;
            txtBox_Quantity.ReadOnly = false;
            txtBox_ISBN.ReadOnly = false;
            txtBox_BookID.ReadOnly = true;
        }

        private void txtBox_KeyPress_AllowOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_SaveDetailBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Definisikan query untuk update data
                sqlQuery = "UPDATE books SET title = @Title, author = @Author, publisher = @Publisher, publication_year = @Year, genre = @Genre, quantity = @Quantity, isbn = @ISBN WHERE book_id = @BookID";

                // Siapkan command
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@Title", txtBox_Title.Text);
                sqlCommand.Parameters.AddWithValue("@Author", txtBox_Author.Text);
                sqlCommand.Parameters.AddWithValue("@Publisher", txtBox_Publisher.Text);
                sqlCommand.Parameters.AddWithValue("@Year", txtBox_Year.Text);
                sqlCommand.Parameters.AddWithValue("@Genre", txtBox_Genre.Text);
                sqlCommand.Parameters.AddWithValue("@Quantity", txtBox_Quantity.Text);
                sqlCommand.Parameters.AddWithValue("@ISBN", txtBox_ISBN.Text);
                sqlCommand.Parameters.AddWithValue("@BookID", txtBox_BookID.Text);

                // Eksekusi query
                int rowsAffected = sqlCommand.ExecuteNonQuery();

                // Beri tahu pengguna jika data berhasil diperbarui
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book details updated successfully!");
                }
                else
                {
                    MessageBox.Show("No changes were made.");
                }

                // Kembalikan tombol ke kondisi semula
                btn_EditDetailBook.Enabled = true;
                btn_SaveDetailBook.Enabled = false;
                txtBox_Title.ReadOnly = true;
                txtBox_Author.ReadOnly = true;
                txtBox_Publisher.ReadOnly = true;
                txtBox_Year.ReadOnly = true;
                txtBox_Genre.ReadOnly = true;
                txtBox_Quantity.ReadOnly = true;
                txtBox_ISBN.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Ambil judul buku yang dipilih
            string selectedTitle = txtBox_Title.Text;

            if (string.IsNullOrEmpty(selectedTitle))
            {
                MessageBox.Show("Please select a book to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Konfirmasi penghapusan
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete the book '{selectedTitle}'?",
                                                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Buka koneksi jika belum terbuka
                    if (sqlConnect.State == ConnectionState.Closed)
                    {
                        sqlConnect.Open();
                    }

                    // Query untuk menghapus buku berdasarkan judul
                    sqlQuery = "DELETE FROM books WHERE title = @Title";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.Parameters.AddWithValue("@Title", selectedTitle);

                    // Eksekusi query
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"The book '{selectedTitle}' has been successfully deleted.",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh data di ComboBox dan DataGridView
                        LoadBooks();
                    }
                    else
                    {
                        MessageBox.Show("No changes were made. The book might not exist.",
                                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_AddImage_Click(object sender, EventArgs e)
        {
            // Dialog untuk memilih file gambar
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg",
                Title = "Select Book Cover"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bookCoverPath = openFileDialog.FileName;
                MessageBox.Show("Book cover added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_SaveNewBook_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrWhiteSpace(txtBox_AddTitle.Text) ||
                string.IsNullOrWhiteSpace(txtBox_AddAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtBox_AddPublisher.Text) ||
                string.IsNullOrWhiteSpace(txtBox_AddYear.Text) ||
                cmbBox_AddGenre.SelectedItem == null ||
                string.IsNullOrWhiteSpace(numericQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtBox_AddISBN.Text))
            {
                MessageBox.Show("Please fill in all the fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Periksa ISBN unik
            if (!IsISBNUnique(txtBox_AddISBN.Text))
            {
                MessageBox.Show("The ISBN you entered already exists. Please enter a unique ISBN.", "Duplicate ISBN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Buka koneksi jika belum terbuka
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                // Simpan gambar ke folder Properties/Resources
                string resourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties", "Resources");
                if (!Directory.Exists(resourcesPath))
                {
                    Directory.CreateDirectory(resourcesPath);
                }

                string newFileName = txtBox_Title.Text.Replace(" ", "_") + Path.GetExtension(bookCoverPath);
                string newFilePath = Path.Combine(resourcesPath, newFileName);

                if (!string.IsNullOrEmpty(bookCoverPath))
                {
                    File.Copy(bookCoverPath, newFilePath, true);
                }

                // Query untuk menambahkan buku baru
                sqlQuery = @"INSERT INTO books (title, author, publisher, publication_year, genre, quantity, isbn) 
                     VALUES (@Title, @Author, @Publisher, @Year, @Genre, @Quantity, @ISBN)";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);

                // Tambahkan parameter
                sqlCommand.Parameters.AddWithValue("@Title", txtBox_AddTitle.Text);
                sqlCommand.Parameters.AddWithValue("@Author", txtBox_AddAuthor.Text);
                sqlCommand.Parameters.AddWithValue("@Publisher", txtBox_AddPublisher.Text);
                sqlCommand.Parameters.AddWithValue("@Year", txtBox_AddYear.Text);
                sqlCommand.Parameters.AddWithValue("@Genre", cmbBox_AddGenre.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@Quantity", numericQuantity.Text);
                sqlCommand.Parameters.AddWithValue("@ISBN", txtBox_AddISBN.Text);

                // Eksekusi query
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("New book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset input form
                ResetAddBookForm();

                // Refresh data di panel lain
                LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding new book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_AddBook.Visible = false;
            panel_AllBooks.Visible = false;
            panel_SelectBooks.Visible = false;
            panel_ReturnBook.Visible = true;
            LoadBorrowerData();
            LoadHistoryData();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvBorrower.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a borrower to process the return.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string borrowerName = dgvBorrower.SelectedRows[0].Cells["Borrower Name"].Value.ToString();
            string bookTitle = dgvBorrower.SelectedRows[0].Cells["Book Title"].Value.ToString();
            string tableName = $"{borrowerName}_loans";

            try
            {
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                // Update status buku menjadi dikembalikan
                sqlQuery = $@"UPDATE `{tableName}` 
                             SET returned = 1 
                             WHERE book_title = @bookTitle AND returned = 0 LIMIT 1;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@bookTitle", bookTitle);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show($"'{bookTitle}' has been successfully returned by {borrowerName}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh data borrower dan history
                LoadBorrowerData();
                LoadHistoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing return: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBooks()
        {
            try
            {
                panel_AllBooks.Visible = false;
                panel_SelectBooks.Visible = false;
                panel_AddBook.Visible = false;
                panel_ReturnBook.Visible = false;

                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                sqlQuery = "SELECT book_id, title FROM books ORDER BY title;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);

                cmbBox_BooksTitle.DisplayMember = "title";
                cmbBox_BooksTitle.ValueMember = "book_id"; // Pastikan book_id digunakan sebagai ValueMember
                cmbBox_BooksTitle.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        private bool IsISBNUnique(string isbn)
        {
            try
            {
                // Buka koneksi jika belum terbuka
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                // Query untuk memeriksa apakah ISBN sudah ada
                sqlQuery = "SELECT COUNT(*) FROM books WHERE isbn = @ISBN";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@ISBN", isbn);

                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return count == 0; // ISBN unik jika count = 0
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking ISBN uniqueness: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ResetAddBookForm()
        {
            txtBox_AddTitle.Clear();
            txtBox_AddAuthor.Clear();
            txtBox_AddPublisher.Clear();
            txtBox_AddYear.Clear();
            cmbBox_AddGenre.SelectedIndex = -1;
            numericQuantity.ResetText();
            txtBox_AddISBN.Clear();
            bookCoverPath = "";
        }

        private void LoadUserLoans()
        {
            try
            {
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                // Ambil nama semua tabel loans dari INFORMATION_SCHEMA
                sqlQuery = @"
                    SELECT TABLE_NAME 
                    FROM INFORMATION_SCHEMA.TABLES
                    WHERE TABLE_SCHEMA = 'Library'
                    AND TABLE_NAME LIKE '%_loans';
                ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                List<string> loanTables = new List<string>();
                while (reader.Read())
                {
                    loanTables.Add(reader.GetString("TABLE_NAME"));
                }
                reader.Close();

                if (loanTables.Count == 0)
                {
                    MessageBox.Show("No loan tables found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Buat query gabungan dari tabel loans
                StringBuilder combinedQuery = new StringBuilder();
                for (int i = 0; i < loanTables.Count; i++)
                {
                    string table = loanTables[i];
                    string username = table.Replace("_loans", ""); // Ambil username dari nama tabel

                    combinedQuery.Append($@"
                        SELECT 
                            '{username}' AS `Borrower Name`, 
                            book_title AS `Book Title`, 
                            loan_date AS `Borrow Date`, 
                            due_date AS `Due Date`, 
                            CASE 
                                WHEN returned = 1 THEN 'Yes' 
                                ELSE 'No' 
                            END AS `is Returned` 
                        FROM `{table}`");

                    // Tambahkan UNION ALL jika bukan tabel terakhir
                    if (i < loanTables.Count - 1)
                    {
                        combinedQuery.Append(" UNION ALL ");
                    }
                }

                string finalQuery = combinedQuery.ToString();

                // Eksekusi query gabungan
                sqlCommand = new MySqlCommand(finalQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);

                dgvUsersLoan.DataSource = dataTable;
                dgvUsersLoan.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user loans: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBorrowerData()
        {
            try
            {
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                // Ambil semua tabel loans dari database
                sqlQuery = @"SELECT TABLE_NAME 
                             FROM INFORMATION_SCHEMA.TABLES
                             WHERE TABLE_SCHEMA = 'Library'
                             AND TABLE_NAME LIKE '%_loans';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                List<string> loanTables = new List<string>();
                while (reader.Read())
                {
                    loanTables.Add(reader.GetString("TABLE_NAME"));
                }
                reader.Close();

                if (loanTables.Count == 0)
                {
                    MessageBox.Show("No loan tables found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Query untuk borrower (belum mengembalikan buku)
                StringBuilder combinedQuery = new StringBuilder();
                for (int i = 0; i < loanTables.Count; i++)
                {
                    string table = loanTables[i];
                    string username = table.Replace("_loans", "");

                    combinedQuery.Append($@"
                        SELECT 
                            '{username}' AS `Borrower Name`, 
                            book_title AS `Book Title`, 
                            loan_date AS `Borrow Date`, 
                            due_date AS `Due Date`, 
                            CASE 
                                WHEN returned = 1 THEN 'Yes' 
                                ELSE 'No' 
                            END AS `is Returned` 
                        FROM `{table}`
                        WHERE returned = 0");

                    if (i < loanTables.Count - 1)
                    {
                        combinedQuery.Append(" UNION ALL ");
                    }
                }

                string finalQueryBorrower = combinedQuery.ToString();
                sqlCommand = new MySqlCommand(finalQueryBorrower, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                DataTable borrowerTable = new DataTable();
                sqlAdapter.Fill(borrowerTable);

                dgvBorrower.DataSource = borrowerTable;
                dgvBorrower.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading borrower data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadHistoryData()
        {
            try
            {
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                // Ambil semua tabel loans dari database
                sqlQuery = @"SELECT TABLE_NAME 
                             FROM INFORMATION_SCHEMA.TABLES
                             WHERE TABLE_SCHEMA = 'Library'
                             AND TABLE_NAME LIKE '%_loans';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                List<string> loanTables = new List<string>();
                while (reader.Read())
                {
                    loanTables.Add(reader.GetString("TABLE_NAME"));
                }
                reader.Close();

                if (loanTables.Count == 0)
                {
                    MessageBox.Show("No loan tables found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Query untuk history (sudah mengembalikan buku)
                StringBuilder combinedQuery = new StringBuilder();
                for (int i = 0; i < loanTables.Count; i++)
                {
                    string table = loanTables[i];
                    string username = table.Replace("_loans", "");

                    combinedQuery.Append($@"
                        SELECT 
                            '{username}' AS `Borrower Name`, 
                            book_title AS `Book Title`, 
                            loan_date AS `Borrow Date`, 
                            due_date AS `Due Date`, 
                            'Yes' AS `is Returned` 
                        FROM `{table}`
                        WHERE returned = 1");

                    if (i < loanTables.Count - 1)
                    {
                        combinedQuery.Append(" UNION ALL ");
                    }
                }

                string finalQueryHistory = combinedQuery.ToString();
                sqlCommand = new MySqlCommand(finalQueryHistory, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                DataTable historyTable = new DataTable();
                sqlAdapter.Fill(historyTable);
                
                dgvHistory.DataSource = historyTable;
                dgvHistory.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading history data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void adminLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            loginPage openForm = new loginPage();
            openForm.ShowDialog();
        }

        private void adminHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}