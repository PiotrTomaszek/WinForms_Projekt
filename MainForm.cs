using P4_Projekt.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


/// <summary>
/// 
/// Piotr Tomaszek,
/// Informatyka/ semestr 4,
/// 
/// Przykładowe konto na które można się zalogować: 
/// login: admin
/// password: admin
/// 
/// </summary>
namespace P4_Projekt
{
    public partial class MainForm : Form
    {
        public static string Login;

        public static Client _me;
        public static ICollection<Order> _myOrders;
        public static ICollection<Category> _categories;
        public static ICollection<Product> _allProducts;
        public static ICollection<Chart> _charts;
        public static Dictionary<int, Image> _productsImages;

        public static bool _historyChange = false;
        public static float _totalPrice;
        public static bool _changeClient = false;


        public MainForm(string login)
        {
            Login = login;

            InitializeComponent();
            ControlSetter(null);

            _totalPrice = 0.0F;
            _charts = new List<Chart>();
            _productsImages = new Dictionary<int, Image>();

            using (var context = new myShopContext())
            {
                _myOrders = context
                       .Orders.
                       Where(x => x.IdClient == context
                       .Clients
                       .Where(z => z.Login.Equals(MainForm.Login))
                       .FirstOrDefault().IdClient).OrderByDescending(desc => desc.IdOrder).ToList();

                _me = context.Clients.Where(l => l.Login.Equals(MainForm.Login)).FirstOrDefault();

                _categories = context.Categories.ToList();

                _allProducts = context.Products.ToList();
            }

            InitializeAllImages();
            profileUserControl1.SetValues();
            shoppingUserControl1.InitializeListBoxCategory();
            shoppingUserControl1.InitializeProducts();
            historyUserControl1.InitializeAllOrders();
        }


        // Zdarzenia 

        /// <summary>
        /// Po kliknięciu tworzy się kontrolka odpowiedzialnia za pracę sklepu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShopping_Click(object sender, EventArgs e)
        {
            ControlSetter(shoppingUserControl1);
        }

        /// <summary>
        /// Historia zamówień dla danego klienta i update jeżeli zaistniała jakolwiek zmiana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (_historyChange)
            {
                historyUserControl1.ResetHistory();
                historyUserControl1.InitializeAllOrders();
                _historyChange = false;
            }

            ControlSetter(historyUserControl1);
        }

        /// <summary>
        /// Przełączenie na kontrolke z informacjami o sklepie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            ControlSetter(infoUserControl1);
        }

        /// <summary>
        /// Wyświetlanie profilu użytkownika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfle_Click(object sender, EventArgs e)
        {
            ControlSetter(profileUserControl1);
        }

        /// <summary>
        /// Wylogowanie klienta ze sklepu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Timer dla poprawnego odliczania zegara i aktualizacji paru elementów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Symulacja zegara w aplikacji.
            lblHours.Text = DateTime.Now.ToShortTimeString();
            lblTime.Text = DateTime.Now.ToShortDateString();

            // Sprawdza czy nie zostały zmienione dane dla użytkownika.
            profileUserControl1.CheckIfAllRight();

            // Update klieta
            if (_changeClient)
            {
                profileUserControl1.SetValues();
                _changeClient = false;
            }

            // Wywołanie metody by ciągle sprawdzała ilość obiektów w koszyku
            shoppingUserControl1.RefreshChart();
        }

        /// <summary>
        /// Resetuje na puste okno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLogo_Click(object sender, EventArgs e)
        {
            ControlSetter(null);
        }


        // Metody


        /// <summary>
        /// Tworzy słownik (Klucz = Id produktu, Value = obrazek), 
        /// żeby zlikwidować problem nadmiernego zużycia pamięci RAM alokowanej przez pobieranie obrazków z sieci
        /// oraz żeby nie trzeba było czekać na ponowne zaimportowanie obrazka przez URL.
        /// </summary>
        private static void InitializeAllImages()
        {
            foreach (var item in _allProducts)
            {
                var temporaryPicBox = new PictureBox();
                temporaryPicBox.Load(item.ImageUrl);
                _productsImages.Add(item.IdProduct, temporaryPicBox.Image);
            }
        }

        /// <summary>
        /// Statyczna metoda do Update zalogowanego klienta wywoływana z ProfileUserControl.
        /// </summary>
        /// <param name="newClient"></param>
        public static void ChangeClient(Client newClient)
        {
            using (var context = new myShopContext())
            {
                // Znajduje klienta obecnie zalogowanego po jego ID.
                var clientToUpdate = context.Clients.Where(f => f.IdClient == _me.IdClient).FirstOrDefault();

                if (clientToUpdate != null)
                {
                    clientToUpdate.Login = newClient.Login;
                    clientToUpdate.FirstName = newClient.FirstName;
                    clientToUpdate.LastName = newClient.LastName;
                    clientToUpdate.City = newClient.City;
                    clientToUpdate.Street = newClient.Street;
                    clientToUpdate.Mail = newClient.Mail;
                    clientToUpdate.Phone = newClient.Phone;
                    clientToUpdate.ZIP = newClient.ZIP;
                    clientToUpdate.Voivodeship = newClient.Voivodeship;
                    clientToUpdate.HouseNumber = newClient.HouseNumber;
                    clientToUpdate.MoneySpent = newClient.MoneySpent;
                    clientToUpdate.Points = newClient.Points;
                }
                context.SaveChanges();

                newClient.IdClient = _me.IdClient;
                _me = newClient;
                _changeClient = true;
            }
        }

        /// <summary>
        /// Metoda która polega na stworzeniu nowego zamówienia, dodaniu do niego pozycji, 
        /// ceny całkowitej. W przypadku zamówień uaktualnia zamówienia użytkownika,
        /// zmiena ilość produktów w magazynie.
        /// </summary>
        /// <param name="order"></param>
        public static void MakeOrder(Order order)
        {
            using (var context = new myShopContext())
            {
                // Stworzenie zamówienia w bazie żeby powstało ID.
                context.Orders.Add(order);
                context.SaveChanges();

                // Znalezienie tego zamówienia i jego ID a następnie dodanie wszystkich pozycji i update ceny całkowitej.
                var findThisOrder = context.Orders.OrderByDescending(x => x.IdOrder).FirstOrDefault();
                foreach (var item in _charts)
                {
                    findThisOrder.Charts.Add(item);
                }
                findThisOrder.TotalPrice = _totalPrice;
                context.SaveChanges();

                // Pobranie aktualnej listy zamówień tego użytkownika
                _myOrders = context
                       .Orders.
                       Where(x => x.IdClient == context
                       .Clients
                       .Where(z => z.Login.Equals(MainForm.Login))
                       .FirstOrDefault().IdClient).OrderByDescending(desc => desc.IdOrder).ToList();

                // Update ilości i sprzedanych produktów w magazynie.
                foreach (var item in _charts)
                {
                    var tempProduct = context.Products.Where(p => p.IdProduct == item.IdProduct).FirstOrDefault();
                    tempProduct.UnitsInStock -= item.Units;
                    tempProduct.UnitsSold += item.Units;
                }

                // Uaktualnienie listy produktów
                _allProducts = context.Products.ToList();

                // Update Klienta i jego wydanych pieniędzy i punktów.
                var clnt = context.Clients.Where(id => id.Login.Equals(Login)).FirstOrDefault();
                clnt.MoneySpent = _myOrders.Select(s => s.TotalPrice).Sum();
                clnt.Points = Convert.ToInt32(clnt.MoneySpent / 1000.0f + 10.0f);
                ChangeClient(clnt);

                context.SaveChanges();
            }
            _historyChange = true;
        }

        /// <summary>
        /// Ustawia wszystkie UserControls na nie widoczne oprócz tej której wybraliśmy.
        /// </summary>
        /// <param name="activeUserControl"></param>
        private void ControlSetter(UserControl activeUserControl)
        {
            shoppingUserControl1.Visible = false;
            profileUserControl1.Visible = false;
            historyUserControl1.Visible = false;
            infoUserControl1.Visible = false;

            if (activeUserControl != null)
                activeUserControl.Visible = true;
        }
    }
}
