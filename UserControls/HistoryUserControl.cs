using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4_Projekt.Model;

namespace P4_Projekt.UserControls
{
    public partial class HistoryUserControl : UserControl
    {
        public HistoryUserControl()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Tworzy listę zamówień jakie dany użytkownik ma na swoim koncie.
        /// </summary>
        public void InitializeAllOrders()
        {
            // Dla każdego zamówienia tworzy kontrolkę.
            foreach (var item in MainForm._myOrders)
            {
                Controls.Add(new OrderUserControl
                {
                    Dock = DockStyle.Top,
                    Visible = true,
                    Height = 75,
                    Enabled = true,
                    LblIdOrder = item.IdOrder.ToString(),
                    LblOrderName = item.OrderName,
                    LblOrderDate = item.OrderDate.ToShortDateString(),
                    LblPrice = $"{item.TotalPrice}zł"
                });
            }

            //Dodaj kontrolke opisową żeby była na samej górze.
            Controls.Add(new OrderDetailsUserControl
            {
                Dock = DockStyle.Top
            });
        }

        /// <summary>
        /// Resetuje liste zamówień by nie wystąpiły powtórzenia
        /// </summary>
        public void ResetHistory()
        {
            Controls.Clear();
        }
    }
}
