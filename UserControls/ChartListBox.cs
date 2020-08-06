using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace P4_Projekt.UserControls
{
    public partial class ChartListBox : UserControl
    {
        public event EventHandler RemoveFromChart;


        public int IDProductChartListBox { get; set; }


        public ChartListBox(int idToFindImage, int quantity, string name)
        {
            InitializeComponent();
            Name = name;
            pBoxProduct.Image = MainForm._productsImages.Where(e => e.Key == idToFindImage).FirstOrDefault().Value;
            IDProductChartListBox = MainForm._allProducts.Where(x => x.Name.Equals(name)).FirstOrDefault().IdProduct;
            lblQuantity.Text = $"x{quantity}";
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveFromChart.Invoke(this, e);
        }
    }
}
