using PlayerCommon;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace PMSDataPlayer
{
    public class DBDataPlayer : IPlayerDataSource
    {
        static string connectionString =
            "Data Source=LAPTOP-K9BIE3M3\\SQLEXPRESS; Initial Catalog=VballPlayerPMSDatabase; Integrated Security=True; TrustServerCertificate=True;";

        static SqlConnection sqlConnection;

        public DBDataPlayer()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public bool AddPlayer(Player player)
        {
            var insertStatement = "INSERT INTO Players VALUES (@Name, @Age, @Position)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@Name", player.Name);
            insertCommand.Parameters.AddWithValue("@Age", player.Age);
            insertCommand.Parameters.AddWithValue("@Position", player.Position.ToString());

            sqlConnection.Open();
            int rowsAffected = insertCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return rowsAffected > 0;

        }

        public bool DeletePlayer(string name)
        {
            var deleteStatement = "DELETE FROM Players WHERE Name = @Name";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            deleteCommand.Parameters.AddWithValue("@Name", name);

            sqlConnection.Open();
            int rowsAffected = deleteCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return rowsAffected > 0;
        }

        public List<Player> GetAllPlayers()
        {
            var players = new List<Player>();
            var selectStatement = "SELECT * FROM Players";
            SqlCommand command = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Player player = new Player
                {
                    Name = reader["Name"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Position = reader["Position"].ToString()
                };

                players.Add(player);
            }

            sqlConnection.Close();
            return players;
        }

        public Player GetPlayerByName(string name)
        {
            var selectStatement = "SELECT * FROM Players WHERE Name = @Name";
            SqlCommand command = new SqlCommand(selectStatement, sqlConnection);
            command.Parameters.AddWithValue("@Name", name);

            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Player player = null;
            if (reader.Read())
            {
                player = new Player
                {
                    Name = reader["Name"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Position = reader["Position"].ToString()
                };
            }

            sqlConnection.Close();
            return player;
        }

        public List<Player> SearchPlayersByName(string searchTerm)
        {
            var players = new List<Player>();
            var selectStatement = "SELECT * FROM Players WHERE Name LIKE @SearchTerm";
            SqlCommand command = new SqlCommand(selectStatement, sqlConnection);
            command.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Player player = new Player
                {
                    Name = reader["Name"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Position = reader["Position"].ToString()
                };

                players.Add(player);
            }

            sqlConnection.Close();
            return players;
        }

        public bool UpdatePlayer(string originalName, Player updatedPlayer)
        {
            var updateStatement = "UPDATE Players SET Name = @Name, Age = @Age, Position = @Position WHERE Name = @OriginalName";
            SqlCommand command = new SqlCommand(updateStatement, sqlConnection);

            command.Parameters.AddWithValue("@Name", updatedPlayer.Name);
            command.Parameters.AddWithValue("@Age", updatedPlayer.Age);
            command.Parameters.AddWithValue("@Position", updatedPlayer.Position.ToString());
            command.Parameters.AddWithValue("@OriginalName", originalName);

            sqlConnection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            sqlConnection.Close();

            return rowsAffected > 0;
        }
    }
}
