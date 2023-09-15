using Northwind.Business.Abstract;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        IProductService _productService;
        ICategoryService _categoryService;
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories(new List<ComboBox> { cbxCategory, cbxAddCategoryId, cbxUpdateCategoryId });
        }

        private void LoadCategories(List<ComboBox> comboBoxes)
        {
            foreach (var comboBox in comboBoxes)
            {
                comboBox.DataSource = _categoryService.GetAll();
                comboBox.DisplayMember = "CategoryName";
                comboBox.ValueMember = "CategoryID";
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {
                // ignored
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            dgwProduct.DataSource = _productService.GetProductsByName(tbxSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product()
                {
                    ProductName = tbxAddProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                    QuantityPerUnit = tbxAddQuantityPerUnit.Text,
                    UnitsInStock = Convert.ToInt16(tbxAddStockAmount.Text),
                    CategoryId = Convert.ToInt32(cbxAddCategoryId.SelectedValue)
                });
                MessageBox.Show(@"Product Added");
                CleanAddGroup();
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CleanAddGroup()
        {
            cleanTextBoxText(new TextBox[]
            {
                tbxAddProductName,
                tbxAddUnitPrice,
                tbxAddQuantityPerUnit,
                tbxAddStockAmount
            });
        }

        protected void cleanTextBoxText(IEnumerable<TextBox> textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Text = string.Empty;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwProduct.CurrentRow == null) return;
                _productService.Update(new Product()
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxUpdateProductName.Text,
                    QuantityPerUnit = tbxUpdateQuantityPerUnit.Text,
                    UnitsInStock = Convert.ToInt16(tbxUpdateStockAmount.Text),
                    UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                    CategoryId = Convert.ToInt32(cbxUpdateCategoryId.SelectedValue)
                });
                MessageBox.Show(@"Product Updated");
                CleanUpdateGroup();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CleanUpdateGroup()
        {
            cleanTextBoxText(new TextBox[]{
                tbxAddProductName,
                tbxAddUnitPrice,
                tbxAddQuantityPerUnit,
                tbxAddStockAmount
            });
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgwProduct.CurrentRow;
            if (row == null) return;
            tbxUpdateProductName.Text = row.Cells[1].Value.ToString();
            cbxUpdateCategoryId.SelectedValue = row.Cells[2].Value;
            tbxUpdateUnitPrice.Text = row.Cells[3].Value.ToString();
            tbxUpdateQuantityPerUnit.Text = row.Cells[4].Value.ToString();
            tbxUpdateStockAmount.Text = row.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow == null) return;
            try
            {
                _productService.Delete(Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value));
                CleanUpdateGroup();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
