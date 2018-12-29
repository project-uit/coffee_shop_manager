using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DTO
{
    public class RevenueReportDTO
    {
        public int month { get; set; }
        public int revenue { get; set; }

        public RevenueReportDTO() { }
        public RevenueReportDTO(int month, int revenue)
        {
            this.month = month;
            this.revenue = revenue;
        }
    }
}
