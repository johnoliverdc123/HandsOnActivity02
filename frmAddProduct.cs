using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Inventory
{
    class NumberFormatException : Exception
    {
        public NumberFormatException()
        {
        }

        public NumberFormatException(string quantity) : base(quantity)
        {
        }
    }
    class StringFormatException : Exception
    {
        public StringFormatException()
        {
        }

        public StringFormatException(string name) : base(name)
        {
        }
    }
    class CurrencyFormatException : Exception
    {
        public CurrencyFormatException()
        {
        }

        public CurrencyFormatException(string price) : base(price)
        {
        }
    }
    public partial class frmAddProduct : Form
    {
        private int _Quantity;
        private double _SellPrice;
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        BindingSource showProductList;

        

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                throw new StringFormatException();
            return name;
        }
        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
                throw new NumberFormatException();
            return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                throw new CurrencyFormatException();
            return Convert.ToDouble(price);
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListofProductCategory = new string[]
            {
                "Beverages", "Bread/Bakery", "Canned/Jarred Goods", "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other"
            };
            foreach (String item in ListofProductCategory)
            {
                cbCategory.Items.Add(item);
            }
        }

        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;

                txtProductName.ResetText();
                cbCategory.ResetText();
                richTxtDescription.ResetText();
                txtQuantity.ResetText();
                txtSellPrice.ResetText();
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show("Input Quantity in Number", ex.Message);
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show("Input Name in Letters", ex.Message);
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show("Input Selling Price in Number", ex.Message);
            }

        }
    }
}
