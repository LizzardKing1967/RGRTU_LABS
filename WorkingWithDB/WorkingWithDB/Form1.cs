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

namespace WorkingWithDB
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=A:\visual\WorkingWithDB\WorkingWithDB\Database.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Shops]", sqlConnection);
            bdOutput(sqlReader, command);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (label7.Visible)
                label7.Visible = false;

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && 
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text)
                )
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Shops] (ShopNumber, FIO, Profesion, Discharge, Experience)VALUES(@ShopNumber, @FIO, @Profesion, @Discharge, @Experience)", sqlConnection);

                command.Parameters.AddWithValue("ShopNumber", textBox1.Text);
                command.Parameters.AddWithValue("FIO", textBox2.Text);
                command.Parameters.AddWithValue("Profesion", textBox3.Text);
                command.Parameters.AddWithValue("Discharge", textBox4.Text);
                command.Parameters.AddWithValue("Experience", textBox5.Text);

                await command.ExecuteNonQueryAsync();
            }
            else
            {
                label7.Visible = true;

                label7.Text = "Поля 'Id', 'Номер цеха' и 'Профессия' и др должны быть заполнены!";
            }
        }




        private async void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Shops] ", sqlConnection);
            bdOutput(sqlReader, command);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (label8.Visible)
                label8.Visible = false;
            if (!string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text) &&
                          !string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) &&
                          !string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox9.Text) &&
                          !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox10.Text) &&
                          !string.IsNullOrEmpty(textBox11.Text) && !string.IsNullOrWhiteSpace(textBox11.Text)
                          )
            {
                SqlCommand command = new SqlCommand("UPDATE [Shops] SET [ShopNumber] = @ShopNumber, [FIO] = @FIO, [Profesion] = @Profesion, [Discharge] = @Discharge, Experience = @Experience WHERE [Id] = @Id ", sqlConnection);

                command.Parameters.AddWithValue("Id", textBox6.Text);
                command.Parameters.AddWithValue("ShopNumber", textBox7.Text);
                command.Parameters.AddWithValue("FIO", textBox8.Text);
                command.Parameters.AddWithValue("Profesion", textBox9.Text);
                command.Parameters.AddWithValue("Discharge", textBox10.Text);
                command.Parameters.AddWithValue("Experience", textBox11.Text);

                await command.ExecuteNonQueryAsync();
            }
            else if (!string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text))
            {
                label8.Visible = true;

                label8.Text = "Id должнен быть заполнен!";
            }
            else
            {
                label8.Visible = true;

                label8.Text = "Поля 'Id', 'Номер цеха' и 'Профессия' и др должны быть заполнены!";
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (label8.Visible)
                label8.Visible = false;

            if (!string.IsNullOrEmpty(textBox12.Text) && !string.IsNullOrWhiteSpace(textBox12.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM [Shops] WHERE [Id]=@Id", sqlConnection);

                command.Parameters.AddWithValue("Id", textBox12.Text);

                await command.ExecuteNonQueryAsync();
            }
            else
            {
                label8.Visible = true;

                label8.Text = "Id должнен быть заполнен!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void bdOutput(SqlDataReader sqlReader, SqlCommand command)
        {
            listBox1.Items.Clear();

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Id"]) + "    " + Convert.ToString(sqlReader["ShopNumber"]) +
                     "       " + Convert.ToString(sqlReader["FIO"]) + "       " + Convert.ToString(sqlReader["Profesion"]) +
                     "       " + Convert.ToString(sqlReader["Discharge"]) + "       " + Convert.ToString(sqlReader["Experience"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        

        private async void осортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Shops] ORDER BY [ShopNumber] ", sqlConnection);
            bdOutput(null, command); 
        }
    }
}
