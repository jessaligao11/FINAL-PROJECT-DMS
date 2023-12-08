using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PROD_ACTIVITYY
{
    public partial class Form4 : Form
    {
        private int loggedInUserId;
        private OleDbConnection con;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\jessa\Documents\prod activty.accdb;Persist Security Info=False";

        public Form4()
        {
            InitializeComponent();
            con = new OleDbConnection(connectionString);
        }

        public Form4(int userId) : this()
        {
            loggedInUserId = userId;
            // Any additional initialization based on user ID
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform logout or any other necessary actions before exiting
                // ...

                // Exit the application
                Environment.Exit(0);
            }
            // If the user clicks "No", do nothing and continue with the application
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 homePage = new Form2(loggedInUserId); // Pass the user ID to Form2
            homePage.Show();
        }

        private void savediary_Click(object sender, EventArgs e)
        {
            SaveDiaryEntry();
        }

        private void showdiary_Click(object sender, EventArgs e)
        {
            richTextBoxdiary.Clear(); // Clear the RichTextBox before loading new entries
            LoadDiaryEntries();
        }

        private void richTextBoxdiary_TextChanged(object sender, EventArgs e)
        {
            // You can add any specific logic when the content of the diary entry changes
        }

        private void SaveDiaryEntry()
        {
            try
            {
                con.Open();

                string insertQuery = "INSERT INTO DIARY (user_id, EntryDate, EntryText) VALUES (@user_id, @EntryDate, @EntryText)";

                using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, con))
                {
                    insertCommand.Parameters.AddWithValue("@user_id", loggedInUserId);

                    // Parse and validate the date components
                    if (int.TryParse(yeardiary.Text, out int year) &&
                        int.TryParse(monthdiary.Text, out int month) &&
                        int.TryParse(daydiary.Text, out int day))
                    {
                        insertCommand.Parameters.AddWithValue("@EntryDate", new DateTime(year, month, day));
                    }
                    else
                    {
                        MessageBox.Show("Invalid date components. Please enter valid numbers for day, month, and year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if the date is invalid
                    }

                    insertCommand.Parameters.AddWithValue("@EntryText", richTextBoxdiary.Text);

                    // For debugging purposes, display the parameters
                    MessageBox.Show($"Parameters:\nUser ID: {loggedInUserId}\nEntry Date: {year}-{month}-{day}\nEntry Text: {richTextBoxdiary.Text}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Your diary saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the diary entry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadDiaryEntries()
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM DIARY WHERE user_id = @user_id";

                using (OleDbCommand command = new OleDbCommand(query, con))
                {
                    command.Parameters.AddWithValue("@user_id", loggedInUserId);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string entryDate = reader["EntryDate"].ToString();
                            string entryContent = reader["EntryText"].ToString();

                            richTextBoxdiary.Text += $"Entry Date: {entryDate}\n\n{entryContent}\n\n---------------------------------------\n\n";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading diary entries: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void yeardiary_TextChanged(object sender, EventArgs e)
        {
            // You can add any specific logic when the year changes
        }

        private void monthdiary_TextChanged(object sender, EventArgs e)
        {
            // You can add any specific logic when the month changes
        }

        private void daydiary_TextChanged(object sender, EventArgs e)
        {
            // You can add any specific logic when the day changes
        }
    }
}