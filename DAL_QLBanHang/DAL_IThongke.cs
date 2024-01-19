using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBanHang
{
    public interface DAL_IThongke
    {
        List<DTO_ThongKeTonkho> ThongKeTonkho();
        List<DTO_ThongKeNhaphang> ThongKeNhaphang();

    }
}
