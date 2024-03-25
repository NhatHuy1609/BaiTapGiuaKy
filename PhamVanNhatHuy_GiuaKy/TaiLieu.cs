using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanNhatHuy_GiuaKy
{
    public class TaiLieu
    {
        public int Id { get; set; }
        public string MaXB { get; set; }
        public string TenTL { get; set; }
        public string NhaPH { get; set; }
        public int CateId { get; set; }

        public TaiLieu() { }
    }
}
