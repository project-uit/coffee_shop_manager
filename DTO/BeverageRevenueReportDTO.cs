using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DTO
{
    public class BeverageRevenueReportDTO
    {
        public String groupBeverage { get; set; }
        public int revenue { get; set; }

        public BeverageRevenueReportDTO() { }
        public BeverageRevenueReportDTO(String groupBeverage, int revenue)
        {
            this.groupBeverage = groupBeverage;
            this.revenue = revenue;
        }
    }
}
