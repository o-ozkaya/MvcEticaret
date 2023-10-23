using Microsoft.AspNetCore.Mvc;

namespace MvcEticaret.Components
{
	public class ProductItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title, int starCount, decimal oldPrice, decimal price, string imageUrl, bool isSale, bool option)
        {

            var model = new ProductItemModel
            {
                Title = title,
                StarCount = starCount,
                OldPrice = oldPrice,
                Price = price,
                ImageUrl = imageUrl,
                IsSale = isSale,
                Option = option
            };


            return View(model);
        }
    }


}
