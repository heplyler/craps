using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace craps.Database
{
    class AzureSqlDatabase
    {
        // creating this as a private static database variable.
        private static SqlConnection azureDatabase;

        private string connectionString = "You will need to replace this string with an appropriate string from microsoft.";

        public void TestDatabase()
        {
            // here we are going to connect to Azure cosmos sql database.
            try
            {
                // this is the connection string.
                azureDatabase = new SqlConnection(
                        "You will need to replace this string with an appropriate string from microsoft."
                   );
                azureDatabase.Open();
            }
            catch (Exception e)
            {
                // if for some reason there is an error we are going to 
                MessageBox.Show("there was a problem connecting to azure database " + e.ToString());
            }
            finally
            {

            }
        }

        // we're going to be using newtonsoft json objects to handle this.
        // so we just want to get a string.
        public string GetUserHistory(string userName)
        {
            string returnStr = "";
              return returnStr;
        }

        public List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();
            string sql = "Select * from Players";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Player newPlayer = new Player();
                            newPlayer.Username = reader["username"].ToString();
                            players.Add(newPlayer);
                        }

                    }

                }
                
            }
            return players;
        }

        public List<Game> GetGamesByUsername(string username)
        {
            string sql = "Select* From Games where username = '" + username + "'";
            List<Game> games = new List<Game>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Game newGame = new Game();
                            newGame.points = Int16.Parse(reader["point"].ToString());
                            newGame.sumArray = reader["SumArray"].ToString().Split(',').Select(a => Convert.ToInt32(a)).ToArray();
                            newGame.winStr = reader["Result"].ToString();
                            switch (newGame.winStr)
                            {
                                case "Win":
                                    newGame.won = 1;
                                    break;
                                case "Lose":
                                    newGame.won = 2;
                                    break;
                                default:
                                    newGame.won = 0;
                                    break;
                            }
                            games.Add(newGame);
                        }

                    }

                }

                return games;
            }
        }

        public bool SaveGame(string userName, int[] sumArray, int Point, string result)
        {
            bool success = false; // guilty until proven innocent.
            // here we are going to get the current game json for this user.
            string sql = "Insert Into Games (UserName,SumArray,Point,Result) Values ('"+ userName + "','"+ string.Join(",", sumArray) +"','"+Point.ToString()+"','"+result+"');";
            Insert(sql);
            return success;
        }

        public string GetAllUsers()
        {
            string returnStr = "";
            return returnStr;
        }

        public void DeleteUserHistory(string userName)
        {
            string sql = "Delete from Games Where Username = '" + userName + "';";
            Insert(sql);
        }

        public Player Login(string username, string password)
        {
            Player p = new Player();
            
            string checkPass = Query("Select Password from Players Where UserName = '"+ username + "';");
           
            if (checkPass == password)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "Select * from Players Where UserName = '" + username + "';";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                p.Username = reader["Username"].ToString();
                                p.totalGames = Int16.Parse(reader["TotalGames"].ToString());
                                p.wins = Int16.Parse(reader["Wins"].ToString());
                                p.loses  = Int16.Parse(reader["Loses"].ToString());
                                p.GetWinRate();

                            }

                        }

                    }
                }

            }
            else
            {
                MessageBox.Show("couldn't find the username with the password provided.");
            }


         
            return p;

        }

        public void CreateUser(string username, string password)
        {
            try
            {
                String sql = "INSERT INTO Players(PersonID, Rank, UserName, Password, Wins, Loses, TotalGames)" +
                             "VALUES(1, 0, '" + username + "', '" + password + "', 0, 0, 0);";

                Insert(sql);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void Insert(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public string Query(string sql)
        {
            string returnStr = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            returnStr += reader["Password"].ToString();

                        }

                    }

                }
            }
            return returnStr;
        }

        public bool DeleteUser(string username)
        {
            bool success = false; // guilty until proven innocent.
            Insert("Delete From Players Where UserName = '" + username + "';");
            return success;
        }
    }
}
