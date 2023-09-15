using System;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(
                new Product
                {
                    Name = tbxName.Text,
                    StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                }
            );
            LoadProducts();
            MessageBox.Show("Product Added!");
        }

        private void dtwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateStockAmount.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateUnitPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[1].Value),
                Name = tbxUpdateName.Text,
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Product Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[1].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Product Deleted");
        }
    }
}
