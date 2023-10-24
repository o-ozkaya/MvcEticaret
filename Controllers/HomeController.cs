using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Components;
using MvcEticaret.Models;
using System.Diagnostics;

namespace MvcEticaret.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;


		public static List<ProductItemModel> productItems = new List<ProductItemModel>
		{

				new ProductItemModel {Id=1, Title = "Mansion", StarCount = 5, OldPrice = 1310.34m, Price = 1300m, ImageUrl = "https://robbreport.com/wp-content/uploads/2023/07/DJI_0661.jpg", IsSale = true, Option= false },
				new ProductItemModel {Id=2, Title = "House", StarCount = 4, OldPrice = 69.69m, Price = 69, ImageUrl = "https://thumbor.forbes.com/thumbor/fit-in/900x510/https://www.forbes.com/home-improvement/wp-content/uploads/2022/07/download-23.jpg", IsSale = true, Option = false },
				new ProductItemModel {Id=3, Title = "Laptop", StarCount = 0, OldPrice = 0.069m, Price = 0.05m, ImageUrl = "https://assets-prd.ignimgs.com/2023/05/02/best-macbooks-to-buy-2-1683051709961.jpg", IsSale = false, Option=true },
				new ProductItemModel {Id=4, Title = "Iphone", StarCount = 4, OldPrice = 1, Price = 0.8m, ImageUrl = "https://www.apple.com/newsroom/images/product/iphone/standard/Apple_iPhone-13-Pro_Colors_09142021_big.jpg.small_2x.jpg", IsSale = false, Option=true },
				new ProductItemModel {Id=5, Title = "Ledger Nano", StarCount = 2, OldPrice = 0.0069m, Price = 0.006m, ImageUrl = "https://m.media-amazon.com/images/I/515tKpfEJAL.jpg", IsSale = false, Option=true },
				new ProductItemModel {Id=6, Title = "Lamborghini", StarCount = 5, OldPrice = 17.58m, Price = 17, ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/dwburnett-pcoty-roughs-6877-1642525990.jpg?crop=0.668xw:1.00xh;0.177xw,0&resize=640:*", IsSale = true, Option=false },
				new ProductItemModel {Id=7, Title = "Tesla Model Y", StarCount = 4, OldPrice = 1.8965m, Price = 1.5m, ImageUrl = "https://cdn1.ntv.com.tr/gorsel/NJfrPkw6A0G5U0Qdl_3xqg.jpg?width=1000&mode=crop&scale=both", IsSale = true, Option=false },
				new ProductItemModel {Id=8, Title = "ASIC Miner", StarCount = 5, OldPrice = 0.062m, Price = 0.06m, ImageUrl = "https://v4-upload.digoodcms.com/586/1672643935_bitcoin%20miner_1.jpg", IsSale = true, Option=true }

	};


		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View(productItems);
		}

		public IActionResult About()
		{
            return View();
        }

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}