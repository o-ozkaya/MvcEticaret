using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEticaret.Components
{
    public class ProductItemModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public int StarCount { get; set; }
        public decimal OldPrice { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool IsSale { get; set; }
        public bool Option { get; set; }
    }
}