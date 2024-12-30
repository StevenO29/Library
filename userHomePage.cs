using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class userHomePage : Form
    {
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=Library";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private string username;

        public userHomePage(string username)
        {
            InitializeComponent();
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            this.username = textInfo.ToTitleCase(username.ToLower());
        }

        private void userHomePage_Load(object sender, EventArgs e)
        {
            CreateLoanTableForUser(username);
            lblUser_TitleHome.Text = $"Welcome, {username}!";
            panel_MyLoans.Visible = false;

            try
            {
                sqlConnect.Open();

                // Query untuk mengambil daftar buku
                sqlQuery = "SELECT title AS 'Title' FROM books ORDER BY title;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);

                listBox_AvailableBooks.DisplayMember = "Title";
                listBox_AvailableBooks.DataSource = dataTable;
                listBox_AvailableBooks.SelectedIndexChanged += listBox_AvailableBooks_SelectedIndexChanged;

                if (listBox_AvailableBooks.Items.Count > 0)
                {
                    listBox_AvailableBooks.SelectedIndex = 0;
                    ShowBookDetails(listBox_AvailableBooks.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books: {ex.Message}");
            }
            finally
            {
                if (sqlConnect.State == ConnectionState.Open)
                {
                    sqlConnect.Close();
                }
            }
        }

        private void userHome_Click(object sender, EventArgs e)
        {
            panel_MyLoans.Visible = false;
        }

        private void listBox_AvailableBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_AvailableBooks.SelectedItem == null)
                return;

            // Ambil judul buku yang dipilih dan tampilkan detailnya
            string selectedTitle = listBox_AvailableBooks.GetItemText(listBox_AvailableBooks.SelectedItem);
            ShowBookDetails(selectedTitle);

            var selectedRow = listBox_AvailableBooks.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                string selectedTitle2 = selectedRow["Title"].ToString();

                try
                {
                    // Akses gambar dari Resources
                    var resourceImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(selectedTitle2);

                    if (resourceImage != null)
                    {
                        picBoxBook.Image = resourceImage;
                    }
                    else
                    {
                        // Jika gambar tidak ditemukan di Resources
                        picBoxBook.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("images.jpg");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            string selectedTitle = lbl_BookTitle.Text;
            if (lbl_BookAvail.Text == "No")
            {
                MessageBox.Show("This book is not available for loan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                string loanTableName = $"{username}_loans";
                string insertQuery = $"INSERT INTO {loanTableName} (book_title, loan_date, due_date) VALUES (@book_title, CURDATE(), DATE_ADD(CURDATE(), INTERVAL 7 DAY));";
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, sqlConnect);
                insertCommand.Parameters.AddWithValue("@book_title", selectedTitle);
                insertCommand.ExecuteNonQuery();

                string updateBookQuery = "UPDATE books SET quantity = quantity - 1 WHERE title = @title";
                MySqlCommand updateBookCommand = new MySqlCommand(updateBookQuery, sqlConnect);
                updateBookCommand.Parameters.AddWithValue("@title", selectedTitle);
                updateBookCommand.ExecuteNonQuery();

                MessageBox.Show($"Successfully loaned '{selectedTitle}'. Please return within 7 days.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadLoanData();
                ShowBookDetails(selectedTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing loan: {ex.Message}");
            }
            finally
            {
                if (sqlConnect.State == ConnectionState.Open)
                {
                    sqlConnect.Close();
                }
            }
        }

        private void userLoans_Click(object sender, EventArgs e)
        {

            try
            {
                panel_MyLoans.Visible = true;
                LoadLoanData();

                // Clear DataGridView sebelum mengisi ulang
                dgvUserLoans.DataSource = null;
                dgvUserLoans.Rows.Clear();
                dgvReturnedBooks.DataSource = null;
                dgvReturnedBooks.Rows.Clear();

                // Buka koneksi jika belum terbuka
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                string loanTableName = $"{username}_loans";

                // Ambil data buku yang sedang dipinjam (returned = 0)
                string queryLoans = $"SELECT book_title AS 'Title', loan_date AS 'Loan Date', due_date AS 'Due Date' FROM {loanTableName} WHERE returned = 0;";
                MySqlDataAdapter loanAdapter = new MySqlDataAdapter(queryLoans, sqlConnect);
                DataTable loanTable = new DataTable();
                loanAdapter.Fill(loanTable);
                dgvUserLoans.DataSource = loanTable;
                dgvUserLoans.ClearSelection();

                // Ambil data buku yang telah dikembalikan (returned = 1)
                string queryReturned = $"SELECT book_title AS 'Title', loan_date AS 'Loan Date', due_date AS 'Due Date' FROM {loanTableName} WHERE returned = 1;";
                MySqlDataAdapter returnedAdapter = new MySqlDataAdapter(queryReturned, sqlConnect);
                DataTable returnedTable = new DataTable();
                returnedAdapter.Fill(returnedTable);
                dgvReturnedBooks.DataSource = returnedTable;
                dgvReturnedBooks.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading loans: {ex.Message}");
            }
            finally
            {
                if (sqlConnect.State == ConnectionState.Open)
                {
                    sqlConnect.Close();
                }
            }
        }

        private void ShowBookDetails(string title)
        {
            try
            {
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                sqlQuery = @"SELECT title, author, publisher, publication_year, genre, isbn, quantity 
                             FROM books WHERE title = @title";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@title", title);

                // Eksekusi query dan baca hasilnya
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    // Tampilkan detail buku di label
                    lbl_BookTitle.Text = reader["title"].ToString();
                    lbl_BookAuthor.Text = $"{reader["author"].ToString()}";
                    lbl_BookPublisher.Text = $"{reader["publisher"].ToString()}";
                    lbl_BookYear.Text = $"{reader["publication_year"].ToString()}";
                    lbl_BookGenre.Text = $"{reader["genre"].ToString()}";
                    lbl_BookISBN.Text = $"{reader["isbn"].ToString()}";

                    // Periksa quantity dan setel status available
                    int quantity = Convert.ToInt32(reader["quantity"]);
                    lbl_BookAvail.Text = $"{(quantity > 0 ? "True" : "False")}";
                }
                reader.Close();

                string loanTableName = $"{username}_loans";
                sqlQuery = $"SELECT COUNT(*) FROM {loanTableName} WHERE book_title = @title AND returned = 0";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@title", title);
                int loanedCount = Convert.ToInt32(sqlCommand.ExecuteScalar());

                if (loanedCount > 0)
                {
                    btnLoan.Enabled = false;
                }
                else
                {
                    btnLoan.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying book details: {ex.Message}");
            }
            finally
            {
                if (sqlConnect.State == ConnectionState.Open)
                {
                    sqlConnect.Close();
                }
            }
        }
        
        private void LoadLoanData()
        {
            try
            {
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                string loanTableName = $"{username}_loans";

                // Data buku yang sedang dipinjam
                string queryLoans = $@"
                    SELECT book_title AS 'Title', loan_date AS 'Loan Date', due_date AS 'Due Date', 
                           CASE 
                               WHEN due_date < CURDATE() THEN 'Yes' 
                               ELSE 'No' 
                           END AS Overdue 
                    FROM {loanTableName} 
                    WHERE returned = 0;";
                MySqlDataAdapter adapterLoans = new MySqlDataAdapter(queryLoans, sqlConnect);
                DataTable tableLoans = new DataTable();
                adapterLoans.Fill(tableLoans);
                dgvUserLoans.DataSource = tableLoans;

                // Periksa apakah ada buku yang overdue dan perbarui lblOverdue
                bool isOverdue = tableLoans.AsEnumerable().Any(row => row["Overdue"].ToString() == "Yes");
                lblOverdue.Text = isOverdue ? "Yes" : "No";

                // Data buku yang telah dikembalikan
                string queryReturned = $@"
                    SELECT book_title AS 'Title', loan_date AS 'Loan Date', due_date AS 'Due Date' 
                    FROM {loanTableName} 
                    WHERE returned = 1;";
                MySqlDataAdapter adapterReturned = new MySqlDataAdapter(queryReturned, sqlConnect);
                DataTable tableReturned = new DataTable();
                adapterReturned.Fill(tableReturned);
                dgvReturnedBooks.DataSource = tableReturned;

                // Hilangkan seleksi otomatis
                dgvUserLoans.ClearSelection();
                dgvReturnedBooks.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading loan data: {ex.Message}");
            }
            finally
            {
                if (sqlConnect.State == ConnectionState.Open)
                {
                    sqlConnect.Close();
                }
            }
        }
        
        private void CreateLoanTableForUser(string username)
        {
            try
            {
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                string loanTableName = $"{username}_loans";
                string createTableQuery = $@"
                    CREATE TABLE IF NOT EXISTS {loanTableName} (
                    loan_id INT AUTO_INCREMENT PRIMARY KEY,
                    book_title VARCHAR(100) NOT NULL,
                    loan_date DATE NOT NULL,
                    due_date DATE NOT NULL,
                    returned BOOLEAN DEFAULT FALSE
                    );";
                MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, sqlConnect);
                createTableCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating loan table: {ex.Message}");
            }
            finally
            {
                if (sqlConnect.State == ConnectionState.Open)
                {
                    sqlConnect.Close();
                }
            }
        }
        
        private void userLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            loginPage openForm = new loginPage();
            openForm.ShowDialog();
        }
        
        private void userHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}