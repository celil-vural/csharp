using System;
using System.Windows.Forms;

namespace EntityFrameworkDemo
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
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
            });
            LoadProducts();
            MessageBox.Show("Added");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxUpdateName.Text,
                StockAmount = Convert.ToInt32(tbxUpdateStockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
            });
            LoadProducts();
            MessageBox.Show("Updated!");
        }
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateStockAmount.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateUnitPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(
                new Product
                {
                    Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                });
            LoadProducts();
            MessageBox.Show("Deleted!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }
        private void SearchProducts(string key)
        {
            dgwProducts.DataSource = _productDal.GetByName(key);
        }
    }
}
