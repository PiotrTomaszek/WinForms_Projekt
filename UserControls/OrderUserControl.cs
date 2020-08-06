using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_Projekt.UserControls
{
    public partial class OrderUserControl : UserControl
    {
        public OrderUserControl()
        {
            InitializeComponent();
        }

        // Właściwości

        public string LblIdOrder
        {
            get => lblIdOrder.Text;
            set => lblIdOrder.Text = value;
        }
        public string LblOrderName
        {
            get => lblOrderName.Text;
            set => lblOrderName.Text = value.ToString();
        }
        public string LblOrderDate
        {
            get => lblOrderDate.Text;
            set => lblOrderDate.Text = value.ToString();
        }
        public string LblPrice
        {
            get => lblPrice.Text;
            set => lblPrice.Text = value.ToString();
        }
    }
}
