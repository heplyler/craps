using craps.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace craps
{
    public partial class login : Form
    {
        // connecting to azure sql database.
        AzureSqlDatabase database = new AzureSqlDatabase();
        Player newPlayer; // added a player reference.

        public login()
        {
            InitializeComponent();
            passwordTxt.PasswordChar = '*'; // adding safety for password.
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login();
        }


        // adding sha function for safety in password management.
        static string sha256(string str)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(str));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }

        // create user.
        private void createUserBtn_Click(object sender, EventArgs e)
        {
            database.CreateUser(userNameTxt.Text, sha256(passwordTxt.Text));
            Thread.Sleep(200); // giving time to make sure everything happens.
            Login();
        }

        private void Login()
        {
          newPlayer =  database.Login(userNameTxt.Text, sha256(passwordTxt.Text));
            Thread.Sleep(200);// giving time to make sure everything happens.
            Craps game = new Craps(newPlayer);
            game.Show();
            this.Close();
        }
    }
}
