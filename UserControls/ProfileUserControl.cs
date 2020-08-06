using P4_Projekt.Model;
using System;
using System.Windows.Forms;

namespace P4_Projekt.UserControls
{
    public partial class ProfileUserControl : UserControl
    {
        public static bool _isAllDataRight;

        private Client _client;
        private bool _changingData;

        public ProfileUserControl()
        {
            InitializeComponent();
            _changingData = false;
        }

        /// <summary>
        /// Ustawia wartości dla wszystkich TextBox które zostały pobrane z nowego obiektu.
        /// </summary>
        public void SetValues()
        {
            EnableTextBoxes(false);
            _client = MainForm._me;
            lblLoginEdit.Text = _client.Login;
            txtBoxFirstName.Text = _client.FirstName;
            tBoxLastName.Text = _client.LastName;
            tBoxStreet.Text = _client.Street;
            tBoxHouseNumber.Text = _client.HouseNumber;
            tBoxVoivodeship.Text = _client.Voivodeship;
            tBoxZIP.Text = _client.ZIP;
            tBoxPhone.Text = _client.Phone;
            tBoxMail.Text = _client.Mail;
            tBoxCity.Text = _client.City;
            lblLoginEdit.Text = _client.Login;
            lblMoneySpentEdit.Text = _client.MoneySpent.ToString();
            lblPointsEdit.Text = _client.Points.ToString();
        }

        /// <summary>
        /// Przycisk odpowiedzialny za zmiane danych obecnie zalogowanego klienta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            if (_changingData == true)
            {
                EnableTextBoxes(false);

                btnEditPerson.Text = "Edit";
                _changingData = false;

                // Pobiera obiekt klienta
                _client = new Client
                {
                    Login = MainForm.Login,
                    FirstName = txtBoxFirstName.Text,
                    LastName = tBoxLastName.Text,
                    City = tBoxCity.Text,
                    Street = tBoxStreet.Text,
                    Voivodeship = tBoxVoivodeship.Text,
                    Phone = tBoxPhone.Text,
                    Mail = tBoxMail.Text,
                    ZIP = tBoxZIP.Text,
                    HouseNumber = tBoxHouseNumber.Text,
                    MoneySpent = float.Parse(lblMoneySpentEdit.Text.ToString()),
                    Points = Convert.ToInt32(lblPointsEdit.Text)
                };

                // Metoda do zmiany danych klienta w głównym formie.
                MainForm.ChangeClient(_client);
            }
            else
            {
                EnableTextBoxes(true);

                _changingData = true;
                btnEditPerson.Text = "Save";
            }

            CheckIfAllRight();
        }

        /// <summary>
        /// Decyduje o tym czy TextBox'y są dostępne
        /// </summary>
        /// <param name="whatToDo"></param>
        private void EnableTextBoxes(bool whatToDo)
        {
            // Znajduje wszystkie kontrolki które są typu TextBox.
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is TextBox)
                {
                    var textBox = item as TextBox;
                    textBox.Enabled = whatToDo;
                }
            }
        }

        /// <summary>
        /// Sprawdza czy którakolwiek kontrolka z ProfileUserControl nie była edytowana, czyli Text = "-".
        /// </summary>
        /// <returns></returns>
        public void CheckIfAllRight()
        {
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is TextBox)
                {
                    var tBoxControl = item as TextBox;
                    if (tBoxControl.Text.StartsWith("-"))
                    {
                        _isAllDataRight = false;
                        return;
                    }

                    _isAllDataRight = true;
                }
            }
        }
    }
}
