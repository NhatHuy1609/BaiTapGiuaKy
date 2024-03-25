using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamVanNhatHuy_GiuaKy
{
    public class DanhMuc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static IList<DanhMuc> DanhMucs
        {
            get
            {
                return new List<DanhMuc>
                {
                    new DanhMuc { Id = 1, Name = "Sach" },
                    new DanhMuc { Id = 2, Name = "Bao" },
                    new DanhMuc { Id = 3, Name = "TapChi" }
                };
            }
        }
        public DanhMuc()
        {
            
        }
    }
}
