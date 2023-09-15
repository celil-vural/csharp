using RecapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetListProducts();
            GetListCategories();
        }
        private void GetListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                List<Product> productList = context.Products.ToList();
                dgwProduct.DataSource = productList;
            }
        }
        private void GetListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }
        private void GetListProductsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                List<Product> productList = context.Products.Where(item => item.CategoryId == categoryId).ToList();
                dgwProduct.DataSource = productList;
            }
        }
        private void GetListProductsByProductName(string productName)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                List<Product> productList = context.Products.Where(item => item.ProductName.Contains(productName)).ToList();
                dgwProduct.DataSource = productList;
            }
        }
        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception ex) { }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;
            if (string.IsNullOrEmpty(key))
            {
                GetListProducts();
            }
            else
            {
                GetListProductsByProductName(key);
            }

        }
    }
}
