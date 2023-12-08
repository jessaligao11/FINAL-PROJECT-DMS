using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PROD_ACTIVITYY
{
    public partial class Form1 : Form
    {
        private int loggedInUserId; // Variable to store the logged-in user's ID
        private OleDbConnection con;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\jessa\Documents\prod activty.accdb;Persist Security Info=False";

        public Form1()
        {
            InitializeComponent();

            con = new OleDbConnection(connectionString);

            // make a password hidden by using "*"
            signpass.PasswordChar = '*';
            logpass.PasswordChar = '*';

            // checkbox to make the password visible
            signshowpass.CheckedChanged += signshowpass_CheckedChanged;
            showpass.CheckedChanged += showpass_CheckedChanged;
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            // Your existing code for logbtn_Click
        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            // Your existing code for signbtn_Click
        }

        private void signtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    if (string.IsNullOrEmpty(signuser.Text) || string.IsNullOrEmpty(signid.Text))
                    {
                        MessageBox.Show("Please enter both username and user ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if the username or user_id already exists
                    using (OleDbCommand checkCmd = new OleDbCommand("SELECT COUNT(*) FROM PERSON WHERE [username] = @username OR [user_id] = @user_id", connection))
                    {
                        checkCmd.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = signuser.Text.Trim();
                        checkCmd.Parameters.AddWithValue("@user_id", OleDbType.VarChar).Value = signid.Text.Trim();

                        connection.Open();
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        connection.Close();

                        if (count > 0)
                        {
                            MessageBox.Show("Inputs have already been taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // If the username and user_id are unique, insert the new account into the database
                    using (OleDbCommand insertCmd = new OleDbCommand("INSERT INTO PERSON ([username], [password], [user_id]) VALUES (@username, @password, @user_id)", connection))
                    {
                        // Adjust these parameter types based on your actual database schema
                        insertCmd.Parameters.Add("@username", OleDbType.VarChar).Value = signuser.Text.Trim();
                        insertCmd.Parameters.Add("@password", OleDbType.VarChar).Value = signpass.Text.Trim(); // Password is now masked
                        insertCmd.Parameters.Add("@user_id", OleDbType.Integer).Value = Convert.ToInt32(signid.Text.Trim());

                        connection.Open(); // Open the connection here
                        int rowsAffected = insertCmd.ExecuteNonQuery(); // Execute the command without explicit transactions
                        connection.Close(); // Close the connection here

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error creating account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logbtn_Click_1(object sender, EventArgs e)
        {
            int maxLoginAttempts = 3;
            int failedLoginAttempts = 0;

            loggedInUserId = GetUserIdFromDatabase(loguser.Text, logpass.Text);

            try
            {
                con.Open();

                using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM PERSON WHERE [username] = @username AND [password] = @password", con))
                {
                    cmd.Parameters.AddWithValue("@username", loguser.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", logpass.Text.Trim());

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        this.Hide();
                        Form2 homePage = new Form2(loggedInUserId); // Pass the user ID to Form2
                        homePage.Show();
                    }
                    else
                    {
                        failedLoginAttempts++;

                        if (failedLoginAttempts >= maxLoginAttempts)
                        {
                            MessageBox.Show("Account locked. Too many unsuccessful login attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // You may want to implement additional logic here, such as disabling the login controls.
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private int GetUserIdFromDatabase(string username, string password)
        {
            int userId = -1; // Default value if user not found or login fails

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT user_id FROM PERSON WHERE username = @username AND password = @password";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception, e.g., log or display an error message
                Console.WriteLine($"Error getting user ID from database: {ex.Message}");
            }

            return userId;
        }

        private void signshowpass_CheckedChanged(object sender, EventArgs e)
        {
            signpass.PasswordChar = signshowpass.Checked ? '\0' : '*';
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            logpass.PasswordChar = showpass.Checked ? '\0' : '*';
        }

        private void signpass_TextChanged(object sender, EventArgs e)
        {
            // Your existing code for signpass_TextChanged
        }

        private void loguser_TextChanged(object sender, EventArgs e)
        {
            // Your existing code for loguser_TextChanged
        }

        private void signuser_TextChanged(object sender, EventArgs e)
        {

        }


    }
}