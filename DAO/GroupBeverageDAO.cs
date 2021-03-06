﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class GroupBeverageDAO
    {
        public static bool insert(nhomthucuong nhomthucuong)
        {
            using(quanlycafeEntities db = new quanlycafeEntities())
            {
                try
                {
                    nhomthucuong.xoa_flag = false;
                    db.nhomthucuongs.Add(nhomthucuong);
                    db.SaveChanges();
                    return true;
                } catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    return false;
                }
            }
        }

        public static bool update(nhomthucuong nhomthucuong)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                var update = db.nhomthucuongs.Where(x => x.id_nhomthucuong == nhomthucuong.id_nhomthucuong).SingleOrDefault();
                if(update != null)
                {
                    try
                    {
                        update.tennhomthucuong = nhomthucuong.tennhomthucuong;
                        db.SaveChanges();
                        return true;
                    } catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                  
                }
            }
            return false;
        }
        public static bool delete(nhomthucuong nhomthucuong)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                var delete = db.nhomthucuongs.Where(x => x.id_nhomthucuong == nhomthucuong.id_nhomthucuong).SingleOrDefault();
                if (delete != null)
                {
                    delete.xoa_flag = true;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public static List<nhomthucuong> getList()
        {
            List<nhomthucuong> list = new List<nhomthucuong>();
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                list = db.nhomthucuongs
                    .Where(x => x.xoa_flag == false)
                    .Include(x => x.thucuongs)
                    .ToList();
            }
            return list;
        }

        public static IList<nhomthucuong> getIList()
        {
           
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                return db.nhomthucuongs
                    .Where(x => x.xoa_flag == false)                  
                    .ToList();
            }
        }
    }
}
