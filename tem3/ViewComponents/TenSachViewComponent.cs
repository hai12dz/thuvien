using Microsoft.AspNetCore.Mvc;
using tem3.Models;

namespace ttem2.ViewComponents
{
    public class TenSachViewComponent : ViewComponent
    {
        QlthuVienContext db = new QlthuVienContext();
        public TenSachViewComponent()
        {

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

          var tenloaisachs = db.TLoaiSaches.Take(7).ToList();

            return View("TenSach", tenloaisachs);
        }

    }
}