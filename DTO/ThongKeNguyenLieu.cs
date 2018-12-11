using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DTO
{
    class ThongKeNguyenLieu
    {
        public int idkhonguyenlieu { get; set; }
        public string tennguyenlieu { get; set; }
        public double? dinhluonglythuyet { get; set; }
        public double? dinhluongthucte { get; set; }
        public string donvi { get; set; }
        public double? haohut { get; set; }
    }
}
