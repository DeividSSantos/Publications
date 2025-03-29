using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
namespace Publications
{
    internal static class DataBaseManager
    {
        public static DataTable Publications => PublicationsData();
        private static SqlConnection Connection()
        {
            SqlConnection connection = new SqlConnection("Server = ./; Database = Publications; User Id = DSS; Password = A@98@aa@A;");
            connection.Open();
            return connection;
        }
        private static DataTable PublicationsData()
        {
            DataTable table = new DataTable();
            try
            {
                using(SqlConnection connection = Connection())
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT * FROM Publications;";
                    SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection);
                    adapter.Fill(table);
                    connection.Close();
                }
                return table;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        public static bool AddPublication(string title, string imagePath, string content)
        {
            try
            {
                using(SqlConnection connection = Connection())
                {
                    byte[] byteImage;
                    using(Image image = Image.FromFile(imagePath))
                    {
                        using(MemoryStream memory = new MemoryStream())
                        {
                            image.Save(memory, image.RawFormat);
                            byteImage = memory.ToArray();
                        }
                    }
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText =
                        "INSERT INTO Publications (Index, Title, Image, Content, SendDate) VALUES (@index, @title, @image, @content, @sendDate);";
                    command.Parameters.AddWithValue("@index", PublicationsData().Rows.Count + 1);
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@image", byteImage);
                    command.Parameters.AddWithValue("@content", content);
                    command.Parameters.AddWithValue("@sendDate", DateTime.Today);
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }
        public static bool AlterPublication(int index, string title, string imagePath, string content)
        {
            try
            {
                using(SqlConnection connection = Connection())
                {
                    if(imagePath != "")
                    {
                        byte[] byteImage;
                        using(Image image = Image.FromFile(imagePath))
                        {
                            using(MemoryStream memory = new MemoryStream())
                            {
                                image.Save(memory, image.RawFormat);
                                byteImage = memory.ToArray();
                            }
                        }
                        SqlCommand command0 = connection.CreateCommand();
                        command0.CommandText = "UPDATE Publications SET Title = @title, Image = @image, Content = @content WHERE Index = @index;";
                        command0.Parameters.AddWithValue("@index", index + 1);
                        command0.Parameters.AddWithValue("@title", title);
                        command0.Parameters.AddWithValue("@image", byteImage);
                        command0.Parameters.AddWithValue("@content", content);
                        command0.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                    SqlCommand command1 = connection.CreateCommand();
                    command1.CommandText = "UPDATE Publications SET Title = @title, Content = @content WHERE Index = @index;";
                    command1.Parameters.AddWithValue("@index", index + 1);
                    command1.Parameters.AddWithValue("@title", title);
                    command1.Parameters.AddWithValue("@content", content);
                    command1.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }
        public static bool RemovePublication(int index)
        {
            try
            {
                using(SqlConnection connection = Connection())
                {
                    SqlCommand command0 = connection.CreateCommand();
                    command0.CommandText = "DELETE FROM Publications WHERE Index = @index";
                    command0.Parameters.AddWithValue("@index", index + 1);
                    command0.ExecuteNonQuery();
                    SqlCommand command1 = connection.CreateCommand();
                    command1.CommandText = "UPDATE Publications SET Index = (Index - 1) WHERE Index > @index";
                    command1.Parameters.AddWithValue("@index", index + 1);
                    command1.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }
    };
};