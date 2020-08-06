using P4_Projekt.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace P4_Projekt.UserControls
{
    public partial class SimpleProductUserControl : UserControl
    {
        public event EventHandler AddToChartClicked;
        
        public SimpleProductUserControl(int idToFindImage)
        {
            InitializeComponent();

            // Przesłany ID służy do znalezienia obrazka wcześniej pobranego.
            pBoxProductImage.Image = MainForm._productsImages.Where(a => a.Key == idToFindImage).FirstOrDefault().Value;
        }

        private void btnAddToChart_Click(object sender, EventArgs e)
        {
            AddToChartClicked.Invoke(this, e);
        }


        // Właściwości


        /// <summary>
        /// Prop do przesłania ilości danego produktu.
        /// </summary>
        public int UnitsOrdered
        {
            get => int.Parse(this.numUpDownUnits.Value.ToString());
            set => int.Parse(this.numUpDownUnits.Value.ToString());
        }

        /// <summary>
        /// Prop do przesłania obiektu Product żeby potem można było z niego powyciągać wartości.
        /// </summary>
        public Product WhatProductIsThis { get; set; }

        /// <summary>
        /// Prop dla poprawnego ustawiania Nazwy dla Label.
        /// </summary>
        public string PName 
        { 
            set => lblName.Text = value.ToString(); 
        }

        /// <summary>
        /// Prop dla poprawnego ustawiania i pobierania PRODUCENTA produktu.
        /// </summary>
        public string Manufacturer
        {
            get => lblManufacturer.Text;
            set => lblManufacturer.Text = value.ToString();
        }

        /// <summary>
        /// Prop dla poprawnego ustawiania i pobierania Ceny produktu.
        /// </summary>
        public string PPrice
        {
            set => lblUnitPrice.Text = $"{value.ToString()}zł";
        }

        /// <summary>
        /// Prop dla poprawnego ustawiania i pobierania ILOŚCI dostępnych produktów.
        /// </summary>
        public string PUnits
        {
            set => lblUnits.Text = $"{value.ToString()} in stock";
        }

        /// <summary>
        /// Ustawia maksymalna wartość dla każdego obiektu NumericUpDown pojedyńczego produktu.
        /// </summary>
        public int MaxUnits
        {
            get => Convert.ToInt32(this.numUpDownUnits.Maximum);
            set => numUpDownUnits.Maximum = value;
        }
    }
}
