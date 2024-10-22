using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tem3.Models;
using tem3.Models.CauThuModels;

namespace tem3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SachAPIController : ControllerBase
    {

        QlthuVienContext db = new QlthuVienContext();


        [HttpGet("{tenLoai}")]

        public IEnumerable<SachTheoLoai> GetSachTheoLoai(string tenLoai)
        {
            var lstIdSachTheoTenLoai = db.TLoaiSaches.AsNoTracking()
                     .Where(x => x.TenLoai == tenLoai)
                     .Select(x => x.MaLoai)
                     .ToList();

            var tsachs = (from p in db.TSaches
                           where lstIdSachTheoTenLoai.Contains(p.MaLoai)
                           select new SachTheoLoai
                           {
                             MaLoai = p.MaLoai,
                             TenSach   = p.TenSach,
                             NamXb=p.NamXb,
                             MaNgonNgu= p.MaNgonNgu,
                             MaNxb=p.MaNxb,
                             FileAnh=p.FileAnh,
                             GiaTriSach=p.GiaTriSach,
                             GioiThieu= p.GioiThieu,
                             TacGia=p.TacGia,
                             TongSoTrang=p.TongSoTrang,
                             TongSoTap=p.TongSoTap,
                            LanXb=p.LanXb,
                            MaSach = p.MaSach

                           }).ToList();



            return tsachs;
        }


    }
}
