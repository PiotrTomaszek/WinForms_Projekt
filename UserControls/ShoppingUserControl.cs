using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using P4_Projekt.Model;

namespace P4_Projekt.UserControls
{
    public partial class ShoppingUserControl : UserControl
    {
        private static bool _makingOrder = false;
        private static bool ifChange = false;

        private Order _newOrder;
        private ICollection<Product> _products = MainForm._allProducts;

        public ShoppingUserControl()
        {
            InitializeComponent();
            ControlButton(btnCreateOrder);
        }


        // EventHandler'y
        /// <summary>
        /// Eventy handlery do obsługi Koszyka zamówionych produktów.
        /// AddToChart... jest wykonywany gdy w SimpleProductUserControl użytkownik naciśnie przycisk "Add".
        /// RemoveFromChart... W przypadku naciśnięcia "X" koło produktu w koszyku zamówień.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public static void AddToChartShoppingEventHandler(object sender, EventArgs args)
        {
            // Użytkonik musi stworzyć nowe zamówienie najpierw żeby móc dodawać elementy do koszyka.
            if (!_makingOrder)
            {
                MessageBox.Show("Najpierw musisz stworzyć nowe zamówienie.");
                return;
            }

            var simpleProductUC = (SimpleProductUserControl)sender;

            // Sprawdź czy użytkownik już wcześniej nie dodał tego produktu i usuń jeśli tak.
            var ifAnyExisting = MainForm._charts.Where(x => x.IdProduct == simpleProductUC.WhatProductIsThis.IdProduct).FirstOrDefault();
            if (ifAnyExisting != null)
            {
                MainForm._charts.Remove(ifAnyExisting);
            }

            // Jeżeli liczba zamówionych jest większa od 0
            if (simpleProductUC.UnitsOrdered != 0)
            {
                //Dodaj produkt do koszyka
                MainForm._charts.Add(new Chart
                {
                    Discount = 0.0F,
                    Price = simpleProductUC.WhatProductIsThis.UnitPrice,
                    IdProduct = simpleProductUC.WhatProductIsThis.IdProduct,
                    Units = simpleProductUC.UnitsOrdered
                });

                ifChange = true;
            }
        }
        public static void RemoveFromChartShoppingEventHandler(object sender, EventArgs args)
        {
            var chartListBoxUC = (ChartListBox)sender;

            // Znajdź produkt w koszyku po ID i usuń.
            var thisProduct = MainForm._charts.Where(x => x.IdProduct == chartListBoxUC.IDProductChartListBox).FirstOrDefault();
            MainForm._charts.Remove(thisProduct);

            ifChange = true;
        }


        // Przyciski
        /// <summary>
        /// Czyści i inicjuje nową listę produktów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            pnlProducts.Controls.Clear();
            InitializeProducts();
        }

        /// <summary>
        /// Przycisk inicjujący tworzenie nowego obiektu Order.
        /// Sprawdza czy aktualnie użytkownik zaczął kreować swoje zamówienie
        /// oraz włącza inne przyciski gdy takie zamówienie zostanie rozpoczęte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (_makingOrder)
                ControlButton(btnCreateOrder);
            else
            {
                ControlButton();
                btnCancel.Enabled = true;
                btnRealize.Enabled = true;
            }
            _makingOrder = _makingOrder == false ? true : false;


        }

        /// <summary>
        /// Anuluje zlecenie i usuwa utworzony obiekt typu Order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _newOrder = null;
            ControlButton(btnCreateOrder);
            ResetChart();
        }

        /// <summary>
        /// Realizuje zamówienie i resetuje listę produktów żeby zmiany były odrazu widoczne.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRealize_Click(object sender, EventArgs e)
        {

            if (ProfileUserControl._isAllDataRight)
            {
                CreateNewOrder();
                if (MainForm._charts.Count > 0)
                {
                    ControlButton(btnCreateOrder);
                    MainForm.ChangeClient(MainForm._me);
                    MainForm.MakeOrder(_newOrder);
                    InitializeProducts();
                    ResetChart();
                }
                else
                    MessageBox.Show("Nie można zrealizować zamówienia które nie ma żadnych pozycji!");
            }
            else
                MessageBox.Show("Nie wprowadzono poprawnych danych dla użytkownika. Każde pole nie może zaczynać się od znaku \"-\". Popraw dane!");
        }


        /// <summary>
        /// Inicjuje nową listę produktów po filtrowaniu.
        /// </summary>
        public void InitializeProducts()
        {
            FilterProducts();

            // Dodaje każdy produkt do panelu wyświetlanych produktów.
            foreach (var item in _products)
            {
                pnlProducts.Controls.Add(new SimpleProductUserControl(item.IdProduct)
                {
                    Dock = DockStyle.Top,
                    PName = item.Name,
                    Name = item.Name,
                    Manufacturer = item.Manufacturer,
                    PPrice = $"{item.UnitPrice}.{(item.UnitPrice * 100) % 100}",
                    PUnits = item.UnitsInStock.ToString(),
                    MaxUnits = item.UnitsInStock,
                    WhatProductIsThis = item
                });

                // Dla każdej kontrolki dodaje EventHandler do działania przycisku "Add".
                var control = pnlProducts.Controls.Find(item.Name, true).Cast<SimpleProductUserControl>().FirstOrDefault();
                control.AddToChartClicked += AddToChartShoppingEventHandler;
            }
        }


        // Filtrowanie
        /// <summary>
        /// Filtrowanie produktów: resetuje produkty pobierając je ze statycznego pola w Mainform,
        /// czyści Panel na którym umieszcza się produkty a następnie dla każdej filtrowanej wartości
        /// wykonuje proste query z materializacją na końcu.
        /// </summary>
        private void FilterProducts()
        {
            // Reset listy produktów
            _products = MainForm._allProducts;

            // Reset panelu na którym umieszcza kontrolki SimpleProductUserControl.
            pnlProducts.Controls.Clear();

            // Filtrowanie produktów
            CategoryQuery();
            MinPriceQuery();
            MaxPriceQuery();
            NameQuery();
            ManufacturerQuery();
            DiscontinuedQuery();
        }
        private void MinPriceQuery()
        {
            // Pobiera tekst i próbuje przekonwertować, jeśli się uda to filtruje po cenie MIN.
            if (double.TryParse(tBoxPriceMin.Text, out double minPrice) && tBoxPriceMin.Text.Length > 0)
            {
                _products = _products.Where(price => price.UnitPrice >= minPrice).ToList();
            }
        }
        private void MaxPriceQuery()
        {
            // Pobiera tekst i próbuje przekonwertować, jeśli się uda to filtruje po cenie MAX.
            if (double.TryParse(this.tBoxPriceMax.Text, out double maxPrice) && this.tBoxPriceMax.Text.Length > 0)
            {
                _products = _products.Where(price => price.UnitPrice <= maxPrice).ToList();
            }
        }
        private void NameQuery()
        {
            // Pobiera stringa z TextBox, zmienia na małe litery i filtruje po nazwie produktu.
            var textName = tBoxName.Text.ToLower();
            if (textName != null && textName.Length >= 0)
            {
                _products = _products.Where(n => n.Name.ToLower().Contains(textName)).ToList();
            }
        }
        private void ManufacturerQuery()
        {
            // Pobiera z TextBox wprowadzony tekst, zmienia na małe litery i filtruje po producencie.
            var textManufacturer = tBoxManufacturer.Text.ToLower();
            if (textManufacturer != null && textManufacturer.Length >= 0)
            {
                _products = _products.Where(n => n.Manufacturer.ToLower().Contains(textManufacturer)).ToList();
            }
        }
        private void DiscontinuedQuery()
        {
            // Jeśli CheckBox jest zaznaczony to znajdź produkty które są wycofane i te nie wycofane,
            // a jeżeli nie jest zaznaczony to tylko te które nie są wycofane.
            if (chkBoxDiscontinued.Checked)
                _products = _products.ToList();
            else
                _products = _products.Where(n => n.Discontinued == false).ToList();
        }
        private void CategoryQuery()
        {
            // Warunki: Jeśli wybrany element z listy nie jest nullem oraz wybrany element z listy nie jest równy "None"
            // to przefiltruj produkty by dopasować do wybranej kategorii.
            if (cBoxCategory.SelectedItem != null && !cBoxCategory.SelectedItem.Equals("None"))
            {
                // Przeszukaj w celu znalezienia IDkategorii.
                var findCategoryId = MainForm.
                    _categories
                    .Where(find => find.Name.Equals(cBoxCategory.SelectedItem.ToString()))
                    .FirstOrDefault()
                    .IdCategory;

                // Przefiltruj pod kątem kategorii po ID.
                var tempCategories = _products.Where(cat => cat.IdCategory == findCategoryId);

                if (tempCategories != null)
                    _products = tempCategories.ToList();
            }
        }

        // Metody

        /// <summary>
        /// Resetuje koszyk jeżeli zaszła jakakolwiek zmiana.
        /// </summary>
        public void RefreshChart()
        {
            // Najpierw sprawdza czy były jakiekolwiek zmiany w koszyku.
            if (ifChange)
            {
                // Reset ceny całkowitej zamówienia
                MainForm._totalPrice = 0.0F;

                // Usuwa wszystkie obiekty z koszyka i dodaje odnowa
                this.pnlChartListBox.Controls.Clear();

                foreach (var item in MainForm._charts)
                {
                    var findThisProduct = MainForm._allProducts.Where(x => x.IdProduct == item.IdProduct).FirstOrDefault();

                    pnlChartListBox.Controls.Add(new ChartListBox(findThisProduct.IdProduct, item.Units, findThisProduct.Name)
                    {
                        Dock = DockStyle.Top
                    });

                    // Dodaje każdy kolejny produkt (ilość * cena) do całkowitej ceny zamówienia.
                    MainForm._totalPrice += item.Price * item.Units;

                    // Dodaje EventHandlera na przycisku "X" do każdej kontrolki.
                    var a = pnlChartListBox.Controls.Find(findThisProduct.Name, true).Cast<ChartListBox>().FirstOrDefault();
                    a.RemoveFromChart += RemoveFromChartShoppingEventHandler;
                }
                // Ustawia aktualną cene całkowita z prefixem "x"
                this.lblTotalPrice.Text = $"{MainForm._totalPrice.ToString()}zł";

                ifChange = false;
            }
        }

        /// <summary>
        /// Inicjuje wszystkie kategorie jako elementy ComboBox.
        /// </summary>
        public void InitializeListBoxCategory()
        {
            // Jeżeli użytkownik nie będzie chciał już szukać konkretnej kategorii a wyświetlić wszystko.
            MainForm._categories.Add(new Category { Name = "None" });

            // Dodanie nowych przedmiotów do Listy Kategorii.
            foreach (var item in MainForm._categories)
            {
                cBoxCategory.Items.Add(item.Name);
            }
        }

        /// <summary>
        /// Tworzy nowy obiekt Order i przypisuje do niego aktualne dane klienta
        /// </summary>
        private void CreateNewOrder()
        {
            // Pobiera aktualne dane klienta które znajdują się w Mainform.
            var client = MainForm._me;

            _newOrder = new Order
            {
                IdClient = client.IdClient,
                OrderZIP = client.ZIP,
                OrderCity = client.City,
                OrderDate = DateTime.Now,
                OrderHouseNumber = client.HouseNumber,
                OrderName = $"Zamówienie klienta \"{client.Login}\" {client.FirstName} {client.LastName}: {client.Street} {client.HouseNumber}, {client.City} {client.ZIP} {client.Voivodeship}",
                OrderVoivodeship = client.Voivodeship,
                OrderStreet = client.Street,
                TotalPrice = 0,
            };
        }

        /// <summary>
        /// Resetuje koszyk kiedy zamówienie zostanie zrealizowane albo zostanie zwolnione.
        /// </summary>
        private void ResetChart()
        {
            ifChange = true;
            MainForm._charts.Clear();
            MainForm._totalPrice = 0.0F;
            InitializeProducts();
            RefreshChart();
            _makingOrder = false;
        }

        /// <summary>
        /// Przeciążone metody do kontrolowania przycisków związanych z SideBar'em od Koszyka.
        /// </summary>
        private void ControlButton()
        {
            this.btnCancel.Enabled = false;
            this.btnRealize.Enabled = false;
            this.btnCreateOrder.Enabled = false;
        }
        private void ControlButton(Button btn)
        {
            ControlButton();

            if (btn != null)
                btn.Enabled = true;
        }
    }
}
