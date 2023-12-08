using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using System;



namespace PROD_ACTIVITYY
{
    public partial class Form2 : Form
    {
        private int loggedInUserId;
        private List<Note> notes = new List<Note>();
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\jessa\Documents\prod activty.accdb;Persist Security Info=False";
       

        private List<System.Windows.Forms.CheckBox> checkboxes;
        private List<System.Windows.Forms.TextBox> notesTextBoxes;

        public Form2(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            LoadNotes();

            checkboxes = new List<System.Windows.Forms.CheckBox> { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };
            notesTextBoxes = new List<System.Windows.Forms.TextBox> { note1, note2, note3, note4, note5 };
            LoadTasks(); // Load tasks when the form is initialized
        }

        private void savenote_Click(object sender, EventArgs e)
        {
            SaveNoteToDatabase(yournote.Text);
            LoadNotes();
        }

        private void updatenote_Click(object sender, EventArgs e)
        {
            if (mynotes.SelectedIndex != -1 && mynotes.SelectedIndex < notes.Count)
            {
                Note selectedNote = notes[mynotes.SelectedIndex];
                UpdateNoteInDatabase(selectedNote, yournote.Text);
                LoadNotes();
            }
        }

        private void deletenote_Click(object sender, EventArgs e)
        {
            if (mynotes.SelectedIndex != -1 && mynotes.SelectedIndex < notes.Count)
            {
                Note selectedNote = notes[mynotes.SelectedIndex];
                DeleteNoteFromDatabase(selectedNote);
                LoadNotes();
            }
        }

        private void yournote_TextChanged(object sender, EventArgs e)
        {
            // Your event handling code here
        }

        private void mynotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Your event handling code here
        }

        private int GetUserId()
        {
            return loggedInUserId;
        }

        private void LoadNotes()
        {
            notes.Clear();
            mynotes.Items.Clear();

            int userId = GetUserId();

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM NOTES WHERE user_id = @user_id";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", userId);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Note note = new Note
                                {
                                    user_Id = Convert.ToInt32(reader["user_id"]),
                                    title = reader["title"].ToString(),
                                    date_created = reader["date_created"].ToString(),
                                    Content = reader["content"].ToString()
                                };

                                notes.Add(note);
                                mynotes.Items.Add(note.title);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading notes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveNoteToDatabase(string content)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO NOTES (user_id, title, date_created, content) VALUES (@user_id, @title, @date_created, @content)";
                using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@user_id", GetUserId());
                    insertCommand.Parameters.AddWithValue("@title", $"New Note {DateTime.Now.Ticks}");
                    insertCommand.Parameters.AddWithValue("@date_created", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    insertCommand.Parameters.AddWithValue("@content", content);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        private void UpdateNoteInDatabase(Note note, string newContent)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE NOTES SET content = ? WHERE user_id = ? AND title = ? AND date_created = ?";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@content", newContent);
                    command.Parameters.AddWithValue("@user_id", note.user_Id);
                    command.Parameters.AddWithValue("@title", note.title);
                    command.Parameters.AddWithValue("@date_created", note.date_created);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void DeleteNoteFromDatabase(Note note)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM NOTES WHERE user_id = ? AND title = ? AND date_created = ?";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_id", note.user_Id);
                    command.Parameters.AddWithValue("@title", note.title);
                    command.Parameters.AddWithValue("@date_created", note.date_created);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void viewnotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mynotes.SelectedIndex != -1)
            {
                Note selectedNote = notes[mynotes.SelectedIndex];
                MessageBox.Show($"Content: {selectedNote.Content}", "Note Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private class Note
        {
            public int user_Id { get; set; }
            public string title { get; set; }
            public string date_created { get; set; }
            public string Content { get; set; }
        }

        private void exit1_Click(object sender, EventArgs e)
        {


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Your checkbox event handling code here
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Your checkbox event handling code here
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Your textbox event handling code here
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Your textbox event handling code here
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Your textbox event handling code here
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Your textbox event handling code here
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Your textbox event handling code here
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // Your checkbox event handling code here
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // Your checkbox event handling code here
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            // Your checkbox event handling code here
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Your picturebox event handling code here
        }

        private void UpdateCheckboxesAndNotes(string noteContent)
        {
            string[] lines = noteContent.Split('\n');

            for (int i = 0; i < Math.Min(lines.Length, checkboxes.Count); i++)
            {
                checkboxes[i].Checked = lines[i].Contains("[x]");
                string noteText = lines[i].Replace("[/]", "").Replace("[ ]", "").Trim();
                if (i < notesTextBoxes.Count)
                {
                    notesTextBoxes[i].Text = noteText;
                }
            }
        }

        private string GetChecklistContent()
        {
            StringBuilder checklistContent = new StringBuilder();

            for (int i = 0; i < Math.Min(checkboxes.Count, notesTextBoxes.Count); i++)
            {
                checklistContent.AppendLine($"{(checkboxes[i].Checked ? "[/]" : "[ ]")} {notesTextBoxes[i].Text}");
            }

            return checklistContent.ToString();
        }

        private void LoadTasks()
        {
            // Clear existing data
            foreach (var checkbox in checkboxes)
            {
                checkbox.Checked = false;
            }

            foreach (var textBox in notesTextBoxes)
            {
                textBox.Text = "";
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Tasks WHERE user_id = @user_id";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", GetUserId());

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read() && i < checkboxes.Count)
                            {
                                string taskCheck = reader["task_check"].ToString();
                                string taskDescription = reader["task_description"].ToString();

                                // Update the corresponding checkbox and textbox based on the database values
                                checkboxes[i].Checked = (taskCheck == "[/]"); // Only check if task_check is [/]
                                notesTextBoxes[i].Text = taskDescription;

                                i++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading tasks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveTasksToDatabase(string taskCheck, string taskDescription)
        {
            // Skip saving if the task description is null or empty
            if (string.IsNullOrEmpty(taskDescription))
            {
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Continue with the insert logic
                string insertQuery = "INSERT INTO Tasks (user_id, task_check, task_description) VALUES (@user_id, @task_check, @task_description)";
                using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@user_id", GetUserId());
                    insertCommand.Parameters.AddWithValue("@task_check", taskCheck);
                    insertCommand.Parameters.AddWithValue("@task_description", taskDescription);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        private void UpdateTaskInDatabase(int taskId, string taskDescription, bool isChecked)
        {
            if (taskId <= 0)
            {
                // Invalid task ID, handle the error accordingly (you can customize this part)
                Console.WriteLine("Invalid task ID.");
                return;
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Tasks SET task_check = ?, task_description = ? WHERE user_id = ? AND task_id = ?";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@task_check", isChecked ? "[/]" : "[ ]");
                    command.Parameters.AddWithValue("@task_description", taskDescription);
                    command.Parameters.AddWithValue("@user_id", GetUserId());
                    command.Parameters.AddWithValue("@task_id", taskId);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void updatetask_Click(object sender, EventArgs e)
        {
            SaveOrUpdateTask();
            LoadTasks(); // Refresh the tasks after saving or updating
        }

        private void SaveOrUpdateTask()
        {
            // Iterate through checkboxes and corresponding textboxes to save or update tasks
            for (int i = 0; i < checkboxes.Count; i++)
            {
                string taskCheck = checkboxes[i].Checked ? "[/]" : "[ ]";
                string taskDescription = notesTextBoxes[i].Text;

                // Check if the task already exists in the database
                int taskId = GetTaskId(taskDescription);

                if (taskId > 0)
                {
                    // If the task exists, update the condition
                    UpdateTaskInDatabase(taskId, taskDescription, checkboxes[i].Checked);
                }
                else
                {
                    // If the task doesn't exist, save it
                    SaveTasksToDatabase(taskCheck, taskDescription);
                }
            }
        }
        private int GetTaskId(string taskDescription)
        {
            // Check if a task with the given task description exists in the database
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT TOP 1 task_id FROM Tasks WHERE user_id = @user_id AND TRIM(UPPER(task_description)) = TRIM(UPPER(@task_description))";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", GetUserId());
                        command.Parameters.AddWithValue("@task_description", taskDescription);

                        object result = command.ExecuteScalar();

                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while getting the task ID: {ex.Message}");
                return 0;
            }
        }

        private bool TaskExists(int taskId)
        {
            // Check if a task with the given taskId exists in the database
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Tasks WHERE task_id = @task_id AND user_id = @user_id";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@task_id", taskId);
                        command.Parameters.AddWithValue("@user_id", GetUserId());

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking if the task exists: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Hide the current form
                this.Hide();

                // Create an instance of Form4 and pass the loggedInUserId
                Form4 mydiaryPage = new Form4(loggedInUserId);

                // Show Form4
                mydiaryPage.Show();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}