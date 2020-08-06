using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace P4_Projekt
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Do zainicjalizowania przykładowych danych do pracy. Jeśli baza jest pusta.
            //ExampleDataBaseInitializer.DatabaseInitializer();
        }

        /// <summary>
        /// Przycisk logowania "Sign Up".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var data = JsonConvert.DeserializeObject<UsersData>(File.ReadAllText("UsersData.json"));

            var log = tBoxLogin.Text;
            var pass = tBoxPassword.Text;

            CheckUser(data, log, pass);
        }

        /// <summary>
        /// Zakończenie pracy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Przycisk który przechodzi do nowej formatki w której można utworzyć nowego użytkownika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            // Otwiera formatke do tworzenia nowego użytkownika
            var form = new AddingUserForm();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            Hide();
        }

        /// <summary>
        /// Metoda która sprawdza czy dany login i hasło pasują do jakiegokolwiek użytkownika w pliku JSON i bazie danych.
        /// </summary>
        /// <param name="usersData"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        private void CheckUser(UsersData usersData, string login, string password)
        {
            foreach (var item in usersData.Users)
            {
                if (login.Equals(item.Login) && password.Equals(item.Password))
                {
                    // Pobiera loginy z bazy i daje do nowej listy.
                    var allLogins = new List<string>();
                    using (var context = new myShopContext())
                    {
                        foreach (var logins in context.Clients)
                        {
                            allLogins.Add(logins.Login);
                        }
                    }

                    // Sprawdza czy któryś login pasuje do podanego przez użytkownika.
                    if (allLogins.Any(logs => logs.Equals(item.Login)))
                    {
                        // Odpalenie nowej formatki Sklep
                        Hide();
                        var form = new MainForm(item.Login);
                        form.Location = this.Location;
                        form.StartPosition = FormStartPosition.CenterScreen;
                        form.FormClosing += delegate { this.Close(); };
                        form.Show();
                        return;
                    }
                }
            }
            MessageBox.Show("Nie ma takiego konta!", "Problem!?");
        }
    }
}
