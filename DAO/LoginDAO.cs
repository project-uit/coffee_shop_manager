using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class LoginDAO
    {
        public Boolean checkLogin(String username, String password)
        {
            try
            {
                nhanvien staff = new nhanvien();
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    staff = dbContext.nhanviens
                       .Where(tk => tk.tentaikhoan == username && tk.matkhau == password && tk.xoa_flag == null)
                       .FirstOrDefault();
                }

                if (staff != null)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return false;
        }

        public nhanvien getStaffFromUsername(String username)
        {
            nhanvien staff = new nhanvien();
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    staff = dbContext.nhanviens
                       .Where(tk => tk.tentaikhoan == username && tk.xoa_flag == null)
                       .FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
            }
            return staff;
        }
    }
}
