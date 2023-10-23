using MvcEticaret.Models;
using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Components;

namespace MvcEticaret.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			
			var product1 = new ProductItemModel { Id = 1, Title = "Product 1", Price = 100 };
			var cartProduct1 = new CartProductViewModel
			{
				Id = 1,
				Product = product1,
				Quantity = 2,
				
			};
			var product2 = new ProductItemModel { Id = 2, Title = "Product 2", Price = 200 };
			var cartProduct2 = new CartProductViewModel
			{
                Id = 2,
                Product = product2,
                Quantity = 4,
                
            };
			var product3 = new ProductItemModel { Id = 3, Title = "Product 3", Price = 300 };
			var cartProduct3 = new CartProductViewModel
			{
                Id = 3,
                Product = product3,
                Quantity = 5,
                
            };

			var cartProducts = new List<CartProductViewModel> { cartProduct1, cartProduct2, cartProduct3 };

			return View(cartProducts); 
		}
	}
}
