using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class StaffDAO
    {
        public List<nhanvien> getStaffs()
        {
            List<nhanvien> staffs = new List<nhanvien>();
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    staffs = dbContext.nhanviens
                     .Where(x => x.xoa_flag == null)
                     .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                staffs = null;
            }
            return staffs;
        }

        public Boolean addStaff(nhanvien nhanvien)
        {
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    dbContext.nhanviens.Add(nhanvien);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                return false;
            }
            return true;
        }

        public Boolean editStaff(nhanvien nhanvien)
        {
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    nhanvien nv = dbContext.nhanviens.Find(nhanvien.id_nhanvien);
                    nv.hoten = nhanvien.hoten;
                    nv.ngaysinh = nhanvien.ngaysinh;
                    nv.cmnd = nhanvien.cmnd;
                    nv.diachi = nhanvien.diachi;
                    nv.luong = nhanvien.luong;
                    nv.tentaikhoan = nhanvien.tentaikhoan;
                    nv.matkhau = nhanvien.matkhau;
                    nv.quyen = nhanvien.quyen;

                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                return false;
            }
            return true;
        }

        public Boolean deleteStaff(nhanvien nhanvien)
        {
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    nhanvien nv = dbContext.nhanviens.Find(nhanvien.id_nhanvien);
                    nv.xoa_flag = true;
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                return false;
            }
            return true;
        }
    }
}
