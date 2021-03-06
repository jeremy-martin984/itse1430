/*Jeremy Martin
 * ITSE 1430
 * Lab 4
 * 4/27/2020
 */
using System;
using System.Windows.Forms;
using System.Linq;
using Nile.Stores.Sql;
using System.Configuration;

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

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            var connString = ConfigurationManager.ConnectionStrings["ProductDatabase"];

            _database = new SqlProductDatabase(connString.ConnectionString);
            _gridProducts.AutoGenerateColumns = false;

            UpdateList();
        }

        #region Event Handlers
        
        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnProductAdd( object sender, EventArgs e )
        {
            var child = new ProductDetailForm("Product Details");

                if (child.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                ObjectValidator.Validate(child.Product);

                    //Save product
                    _database.Add(child.Product);
                    UpdateList();
                }catch (Exception ex)
                {
                    DisplayError(ex.Message);
                }
        }

        private void OnProductEdit( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                DisplayError("No products available.");
                return;
            };
            try
            {
                ObjectValidator.Validate(product);
                EditProduct(product);
            }catch (Exception ex)
            {
                DisplayError(ex.Message);
            }
        }        

        private void OnProductDelete( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                DisplayError("No products available.");
                return;
            }

            DeleteProduct(product);
        }        
                
        private void OnEditRow( object sender, DataGridViewCellEventArgs e )
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

        private void OnKeyDownGrid( object sender, KeyEventArgs e )
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

        private void DeleteProduct ( Product product )
        {
            //Confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete '{product.Name}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (product.Id <= 0)
                throw new ArgumentOutOfRangeException(nameof(product.Id), "Invalid product ID");

            //Delete product
            _database.Remove(product.Id);
            UpdateList();
        }

        private void EditProduct ( Product product )
        {
            var child = new ProductDetailForm("Product Details");
            child.Product = product;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;


            ObjectValidator.Validate(product);

            _database.Update(child.Product);
            UpdateList();
        }

        private Product GetSelectedProduct ()
        {
            if (_gridProducts.SelectedRows.Count > 0)
                return _gridProducts.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        private void UpdateList ()
        {
            try
            {

                _bsProducts.DataSource = _database.GetAll();
            } catch (Exception e)
            {
                DisplayError($"Product list failed to load: {e.Message}");
            }


        }

        //private readonly IProductDatabase _database = new Nile.Stores.MemoryProductDatabase();

        private IProductDatabase _database;
        #endregion

        private void OnAbout ( object sender, EventArgs e )
        {
            var about = new About();
            about.Show(this);
        }

        private void DisplayError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
