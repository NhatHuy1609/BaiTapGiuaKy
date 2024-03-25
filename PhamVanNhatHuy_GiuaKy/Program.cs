// See https://aka.ms/new-console-template for more information
using PhamVanNhatHuy_GiuaKy;

// Them danh sach sach, bao, tap chi
IList<Sach> GetSachList()
{
    return new List<Sach>
    {
        new Sach { Id = 1, MaXB = "2ash", TenTL = "Sach A", NhaPH = "Nha A", SoTrang = 200, TenTG = "Huy", CateId = 1},
        new Sach { Id = 2, MaXB = "2sash", TenTL = "Sach B", NhaPH = "Nha B", SoTrang = 220, TenTG = "Nhat", CateId = 1},
    };
}

IList<Bao> GetBaoList()
{
    return new List<Bao>
    {
        new Bao { Id = 3, MaXB = "2sash", TenTL = "Bao C", NhaPH = "Nha C", NgayPH = new DateTime(2024,3,20), CateId = 2 },
        new Bao { Id = 4, MaXB = "ew2ash", TenTL = "Sach D", NhaPH = "Nha D", NgayPH = new DateTime(2024,4,20), CateId = 2 },
    };
}

IList<TapChi> GetTapChiList()
{
    return new List<TapChi>
    {
        new TapChi {Id = 5, MaXB = "2sash", TenTL = "Tap chi E", NhaPH = "Nha C", SoPH = 20, TrangPH = 1, CateId = 3},
        new TapChi {Id = 6, MaXB = "2sash", TenTL = "Tap chi G", NhaPH = "Nha C", SoPH = 22, TrangPH = 2, CateId = 3},
    };
}

var sachs318 = GetSachList();
var baos318 = GetBaoList();
var tapchis318 = GetTapChiList();

// Tim theo loai S,B, TC
var dsTL318 = new List<TaiLieu>();
dsTL318.AddRange(sachs318);
dsTL318.AddRange(baos318);
dsTL318.AddRange(tapchis318);

// loai Sach
var dsSachs318 = dsTL318.Where(tl => tl.CateId == 1);
// loai Bao
var dsBaos318 = dsTL318.Where(tl => tl.CateId == 2);
// loai Tap chi
var dsTapchis318 = dsTL318.Where(tl => tl.CateId == 3);

// Tim bao co ngay PH trong thang 3/2024
var firstDateMarch318 = new DateTime(2024, 3, 1);
var lastDateMarch318 = new DateTime(2024, 3, 31);

var baosFiltered318 = baos318.Where(bao => bao.NgayPH >= firstDateMarch318 && bao.NgayPH <= lastDateMarch318).ToList();

Console.ReadKey();