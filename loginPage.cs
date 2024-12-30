using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class loginPage : Form
    {
        // String koneksi ke database MySQL
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=Library";
        private MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        
        public loginPage()
        {
            InitializeComponent();
            txtBox_Password.KeyDown += txtBox_Password_KeyDown;
            txtBox_ConfirmPassword.KeyDown += txtBox_ConfirmPassword_KeyDown;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                // Buka koneksi ke database
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                // Query untuk memeriksa username dan password
                string sqlQuery = "SELECT role, username FROM Users WHERE username = @username AND password = @password";
                MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@username", txtBox_Username.Text);
                sqlCommand.Parameters.AddWithValue("@password", txtBox_Password.Text);

                // Eksekusi query dan baca hasilnya
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    // Login berhasil, ambil peran pengguna dan username
                    string role = reader["role"].ToString();
                    string username = reader["username"].ToString();

                    MessageBox.Show($"Login successful as {role}!");

                    this.Visible = false;

                    if (role == "admin")
                    {
                        adminHomePage adminForm = new adminHomePage();
                        adminForm.ShowDialog();
                    }
                    else if (role == "member")
                    {
                        userHomePage userForm = new userHomePage(username);
                        userForm.ShowDialog();
                    }

                    // Tutup form login setelah selesai
                    this.Close();
                }
                else
                {
                    // Login gagal
                    MessageBox.Show("Invalid Username or Password!");
                    txtBox_Username.Clear();
                    txtBox_Password.Clear();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Tutup koneksi
                if (sqlConnect.State == ConnectionState.Open)
                {
                    sqlConnect.Close();
                }
            }
        }

        private void loginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            panel_Register.Visible = false;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            panel_Register.Visible = true;
        }

        private void btn_RegisterAccount_Click(object sender, EventArgs e)
        {
            // Ambil username dan password dari TextBox
            string username = txtBox_NewUsername.Text.Trim();
            string newPassword = txtBox_NewPassword.Text.Trim();
            string confirmPassword = txtBox_ConfirmPassword.Text.Trim();

            try
            {
                // Validasi apakah password dan confirm password cocok
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Kosongkan TextBox password
                    txtBox_NewPassword.Clear();
                    txtBox_ConfirmPassword.Clear();
                    return;
                }

                // Buka koneksi jika belum terbuka
                if (sqlConnect.State == ConnectionState.Closed)
                {
                    sqlConnect.Open();
                }

                // Periksa apakah username sudah ada
                string checkUsernameQuery = "SELECT COUNT(*) FROM Users WHERE username = @username";
                MySqlCommand checkCommand = new MySqlCommand(checkUsernameQuery, sqlConnect);
                checkCommand.Parameters.AddWithValue("@username", username);
                int userExists = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (userExists > 0)
                {
                    MessageBox.Show("Username already exists. Please choose another username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Kosongkan TextBox username
                    txtBox_NewUsername.Clear();
                    return;
                }

                // Query untuk menambahkan username dan password ke tabel Users
                string insertQuery = "INSERT INTO Users (username, password, role) VALUES (@username, @password, 'member')";
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, sqlConnect);
                insertCommand.Parameters.AddWithValue("@username", username);
                insertCommand.Parameters.AddWithValue("@password", newPassword);
                insertCommand.ExecuteNonQuery();

                // Berhasil menambahkan akun
                MessageBox.Show("Account successfully registered! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sembunyikan panel registrasi dan kembali ke login
                panel_Register.Visible = false;

                // Kosongkan semua input
                txtBox_NewUsername.Clear();
                txtBox_NewPassword.Clear();
                txtBox_ConfirmPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Tutup koneksi
                if (sqlConnect.State == ConnectionState.Open)
                {
                    sqlConnect.Close();
                }
            }
        }

        private void txtBox_ConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }
    }
}
