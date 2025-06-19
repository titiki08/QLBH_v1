using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PolyCafe;
using Microsoft.Data.SqlClient;

namespace DAL_PolyCafe
{
    public class DALChiTietPhieu
    {
        public int generateChiTietID()
        {
            string sql = "SELECT ISNULL(MAX(MaChiTiet), 0) FROM ChiTietPhieu";
            List<object> thamSo = new List<object>();
            object result = DBUTil.ScalarQuery(sql, thamSo);

            int maxId = Convert.ToInt32(result);
            return maxId + 1;
        }


        public List<ChiTietPhieu> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<ChiTietPhieu> list = new List<ChiTietPhieu>();
            try
            {
                SqlDataReader reader = DBUTil.Query(sql, args);
                while (reader.Read())
                {
                    ChiTietPhieu entity = new ChiTietPhieu();
                    entity.Id = reader.GetInt32("MaChiTiet");
                    entity.MaPhieu = reader.GetString("MaPhieu");
                    entity.MaSanPham = reader.GetString("MaSanPham");
                    entity.TenSanPham = reader.GetString("TenSanPham");
                    entity.SoLuong = reader.GetInt32("SoLuong");
                    entity.DonGia = reader.GetDecimal("DonGia");
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<ChiTietPhieu> selectChiTietByMaPhieu(string maPhieu)
        {
            string sql = "SELECT ct.MaChiTiet, ct.MaPhieu, ct.MaSanPham, ct.SoLuong, ct.DonGia, sp.TenSanPham " +
                        "FROM ChiTietPhieu ct " +
                        "INNER JOIN SanPham sp ON ct.MaSanPham = sp.MaSanPham " +
                        "WHERE ct.MaPhieu = @0";
            List<object> thamSo = new List<object>();
            thamSo.Add(maPhieu);
            return SelectBySql(sql, thamSo);
        }

        public void insertChiTiet(ChiTietPhieu ct)
        {
            try
            {
                string sql = @"INSERT INTO ChiTietPhieu (MaChiTiet, MaPhieu, MaSanPham, SoLuong, DonGia) VALUES (@0, @1, @2, @3, @4)";
                List<object> thamSo = new List<object>();
                thamSo.Add(ct.Id);
                thamSo.Add(ct.MaPhieu);
                thamSo.Add(ct.MaSanPham);
                thamSo.Add(ct.SoLuong);
                thamSo.Add(ct.DonGia);
                DBUTil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void insertListChiTiet(List<ChiTietPhieu> lstChiTiet)
        {
            try
            {
                foreach (ChiTietPhieu item in lstChiTiet)
                {
                    insertChiTiet(item);
                }
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void updateSoluong(ChiTietPhieu ct)
        {
            try
            {
                string sql = @"UPDATE ChiTietPhieu 
                   SET SoLuong = @1 
                   WHERE Id = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(ct.Id);
                thamSo.Add(ct.SoLuong);
                DBUTil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void deleteChiTietPhieu(string Id)
        {
            try
            {
                string sql = "DELETE FROM ChiTietPhieu WHERE MaChiTiet = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(Id);
                DBUTil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}
