/*
 * ITSE 1430
 */

using System.ComponentModel.DataAnnotations;

namespace Nile
{
    /// <summary>Represents a product.</summary>
    public class Product : IValidatableObject
    {
        /// <summary>Gets or sets the unique identifier.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>Never returns null.</value>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value?.Trim(); }
        }
        
        /// <summary>Gets or sets the description.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value?.Trim(); }
        }

        /// <summary>Gets or sets the price.</summary>
        public decimal Price { get; set; } = 0;      

        /// <summary>Determines if discontinued.</summary>
        public bool IsDiscontinued { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            // Id must be greater than or equal to 0
            if (Id < 0)
                yield return new ValidationResult("Length must be at least 0");
        }
        #region Private Members

        private string _name;
        private string _description;
        #endregion
    }
}
