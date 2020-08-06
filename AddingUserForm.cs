using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace P4_Projekt
{
    public partial class AddingUserForm : Form
    {
        public AddingUserForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk sprawdza i analizuje podane dane czy są prawidłowe. 
        /// Kiedy wszystko się zgadza to dodaje użytkownika do pliku JSON a następnie do bazy danych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var log = tBoxLogin.Text;
            var pass = tBoxPassword.Text;
            var pass2 = tBoxPassword2.Text;

            var list = JsonConvert.DeserializeObject<UsersData>(File.ReadAllText("UsersData.json"));

            bool newLogin = list.Users.Any(z => z.Login == log) ? false : true;
            bool areSamePasword = pass.Equals(pass2) && !string.IsNullOrEmpty(pass) && !string.IsNullOrWhiteSpace(pass) ? true : false;

            if (newLogin && !string.IsNullOrEmpty(log))
            {
                if (chckBox.Checked)
                {
                    if (areSamePasword)
                    {
                        list.Users.Add(new User
                        {
                            Login = log,
                            Password = pass
                        });

                        // Dodanie nowego klienta do bazy danych żeby mógł się logować.
                        using (var contextAdd = new myShopContext())
                        {
                            contextAdd.Clients.Add(new Model.Client
                            {
                                Login = log,
                                FirstName = "-",
                                LastName = "-",
                                Street = "-",
                                HouseNumber = "-",
                                City = "-",
                                Voivodeship = "-",
                                ZIP = "-",
                                Points = 0,
                                MoneySpent = 0.0F,
                                Phone = "-",
                                Mail = "-"
                            });
                            contextAdd.SaveChanges();
                        }
                        var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
                        File.WriteAllText("UsersData.json", convertedJson);

                        this.Close();
                    }
                    else
                        MessageBox.Show("Podane hasła nie zgadzają się!", "Błąd tworzenia nowego profilu.");
                }
                else
                    MessageBox.Show("Musisz potwierdzić zapoznanie się z regulaminem!", "Błąd tworzenia nowego profilu.");
            }
            else
                MessageBox.Show("Login już zajęty. Wybierz inny.", "Błąd tworzenia nowego profilu.");
        }

        /// <summary>
        /// Wraca do poprzedniej formatki logowania.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
