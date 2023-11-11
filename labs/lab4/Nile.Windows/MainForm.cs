/*
 * ITSE 1430
 */

using Nile.Stores;

namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _gridProducts.AutoGenerateColumns = false;

            var connString = Program.GetConnectionString("ProductDatabase");
            UpdateList();
        }

        #region Event Handlers

        private void OnFileExit(object sender, EventArgs e)
        {
            Close();
        }

        private void OnProductAdd(object sender, EventArgs e)
        {
            var child = new ProductDetailForm("Product Details");
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Done 11-11 Handle errors
            if (child.Product.Id <= 0)
                throw new ArgumentOutOfRangeException(nameof(child.Product.Id), "ID must be greater than 0");

            if (String.IsNullOrEmpty(child.Product.Name))
                throw new ArgumentException(nameof(child.Product.Name), "Name is required");        

            if (child.Product.Price <= 0)
                throw new ArgumentOutOfRangeException(nameof(child.Product.Price), "Price must be greater than 0");

            
            //Save product
            _database.Add(child.Product);
            UpdateList();
        }

        private void OnProductEdit(object sender, EventArgs e)
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("No products available.");
                return;
            };

            EditProduct(product);
        }

        private void OnProductDelete(object sender, EventArgs e)
        {
            var product = GetSelectedProduct();
            if (product == null)
                return;

            DeleteProduct(product);
        }

        private void OnEditRow(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;

            //Handle column clicks
            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Product;

            if (item != null)
                EditProduct(item);
        }

        private void OnKeyDownGrid(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var product = GetSelectedProduct();
            if (product != null)
                DeleteProduct(product);

            //Don't continue with key
            e.SuppressKeyPress = true;
        }

        #endregion

        #region Private Members

        private void DeleteProduct(Product product)
        {
            //Confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete '{product.Name}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //TODO: Done 11-11 Handle errors
            if (product.Id <= 0)
                throw new ArgumentOutOfRangeException(nameof(product.Id), "ID must be greater than 0");

            //Delete product
            _database.Remove(product.Id);
            UpdateList();
        }

        private void EditProduct(Product product)
        {
            var child = new ProductDetailForm("Product Details");
            child.Product = product;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Done 11-11 Handle errors
            if (child.Product.Id <= 0)
                throw new ArgumentOutOfRangeException(nameof(child.Product.Id), "ID must be greater than 0");

            if (String.IsNullOrEmpty(child.Product.Name))
                throw new ArgumentException(nameof(child.Product.Name), "Name is required");

            if (child.Product.Price <= 0)
                throw new ArgumentOutOfRangeException(nameof(child.Product.Price), "Price must be greater than 0");


            //Save product
            _database.Update(child.Product);
            UpdateList();
        }

        private Product GetSelectedProduct()
        {
            if (_gridProducts.SelectedRows.Count > 0)
                return _gridProducts.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        private void UpdateList()
        {
            IEnumerable<Product> Items = _database.GetAll();

            //TODO: Needs more 11-11 Handle errors
            foreach (var item in Items)
            {
                if (item.Id <= 0)
                    throw new ArgumentOutOfRangeException(nameof(item.Id), "ID must be greater than 0");

                if (String.IsNullOrEmpty(item.Name))
                    throw new ArgumentException(nameof(item.Name), "Name is required");

                if (item.Price <= 0)
                    throw new ArgumentOutOfRangeException(nameof(item.Price), "Price must be greater than 0");
                
                if (item == null)
                    throw new ArgumentNullException(nameof(item));

                //Product must exist
                //var existing = _database.FindProduct (item.Id);
               
                //if (existing == null)
                //    throw new ArgumentException("Product not found", nameof(item.Id));

                ObjectValidator.Validate(item);
            }

            _bsProducts.DataSource = _database.GetAll();
        }

        private readonly IProductDatabase _database = new Nile.Stores.MemoryProductDatabase();
        #endregion

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox1();
            about.ShowDialog(this);
        }
    }
}
