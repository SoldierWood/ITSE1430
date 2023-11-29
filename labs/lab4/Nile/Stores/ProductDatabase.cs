/*
 * ITSE 1430
 */
namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {        
        /// <inheritdoc />
        public Product Add ( Product product )
        {
            //TODO: Done 11-18 Check arguments **REMOVE PRIOR CODE OF MINE
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            //if (product.Id <= 0)
            //    throw new ArgumentOutOfRangeException(nameof(product.Id), "ID must be greater than 0");

            //if (product.Price <= 0)
            //    throw new ArgumentOutOfRangeException(nameof(product.Price), "Price must be greater than 0");

            //TODO: Done 11-11 Validate product
            //Validate: null, invalid product
           

            ObjectValidator.Validate(product);

            //Emulate database by storing copy
            return AddCore(product);
        }

        /// <inheritdoc />
        public Product Get ( int id )
        {
            //TODO: Done 11-11 Check arguments
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be greater than 0");


            return GetCore(id);
        }

        /// <inheritdoc />
        public IEnumerable<Product> GetAll ()
        {
            return GetAllCore();
        }

        /// <inheritdoc />
        public void Remove ( int id )
        {
            //TODO: Done 11-11 Check arguments **CHECK CODE REMOVED
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be greater than 0");
            //try
            //{
            RemoveCore(id);
            //} catch (Exception e)
            //{
            //    throw new InvalidOperationException("Delete failed", e);
            //};

        }

        /// <inheritdoc />
        public Product Update ( Product product )
        {
            //TODO: Done 11-11 Check arguments
            if (product.Id <= 0)
                throw new ArgumentOutOfRangeException(nameof(product.Id), "ID must be greater than 0");

            //TODO: Done 11-11 Validate product
            //Validate: null, invalid product
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            ObjectValidator.Validate(product);

            //Get existing product
            var existingId = GetCore(product.Id);

            var existingName = product.Name;

            // Prevent duplicate products
            if (existingName != null)
                throw new InvalidOperationException("Product name must be unique");

            return UpdateCore(existingId, product);
        }

        #region Protected Members

        protected abstract Product GetCore( int id );

        protected abstract IEnumerable<Product> GetAllCore();

        protected abstract void RemoveCore( int id );

        protected abstract Product UpdateCore( Product existing, Product newItem );

        protected abstract Product AddCore( Product product );

        #endregion
    }
}
