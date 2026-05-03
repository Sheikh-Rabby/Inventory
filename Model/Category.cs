using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Inventory.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<SubCategory> SubCategories{ get; set;}

        
    }
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public Category Category { get; set; }
    }
}
