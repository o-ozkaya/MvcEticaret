using System.ComponentModel.DataAnnotations;
using MvcEticaret.Components; 
using MvcEticaret.Models;

namespace MvcEticaret.Models
{
	public class CartProductViewModel
	{
		[Required]
		public int Id { get; set; }

		[Required]
		public ProductItemModel Product { get; set; }

		[Required]
		public int Quantity { get; set; }

		[Required]
		[DataType(DataType.Currency)]
		public decimal TotalPrice
		{
			get { return Product.Price * Quantity; }
		}

	}
}
