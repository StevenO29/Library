using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System;

namespace LibraryAppUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        private static string sqlConnection = "server=localhost;uid=root;pwd=;database=Library";

        [TestMethod]
        public void Test_Login_Success()
        {
            // Arrange
            string username = "admin";
            string password = "admin123";
            bool loginSuccess = false;

            // Act
            using (MySqlConnection sqlConnect = new MySqlConnection(sqlConnection))
            {
                try
                {
                    sqlConnect.Open();
                    string sqlQuery = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password";
                    MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.Parameters.AddWithValue("@username", username);
                    sqlCommand.Parameters.AddWithValue("@password", password);

                    int result = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    loginSuccess = result > 0;
                }
                catch (Exception ex)
                {
                    Assert.Fail("Error during database connection: " + ex.Message);
                }
                finally
                {
                    sqlConnect.Close();
                }
            }

            // Assert
            Assert.IsTrue(loginSuccess, "Login failed for valid username and password.");
        }

        [TestMethod]
        public void Test_Login_Failure()
        {
            // Arrange
            string username = "invalidUser";
            string password = "invalidPassword";
            bool loginSuccess = false;

            // Act
            using (MySqlConnection sqlConnect = new MySqlConnection(sqlConnection))
            {
                try
                {
                    sqlConnect.Open();
                    string sqlQuery = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password";
                    MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.Parameters.AddWithValue("@username", username);
                    sqlCommand.Parameters.AddWithValue("@password", password);

                    int result = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    loginSuccess = result > 0;
                }
                catch (Exception ex)
                {
                    Assert.Fail("Error during database connection: " + ex.Message);
                }
                finally
                {
                    sqlConnect.Close();
                }
            }

            // Assert
            Assert.IsFalse(loginSuccess, "Login succeeded for invalid username and password.");
        }
    }
}
