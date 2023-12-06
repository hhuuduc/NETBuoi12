using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PhongHoiNghi
{
    class HoiNghi_DAO
    {
        public HoiNghi_DAO() { }

        public string conStr = "Data Source=A209PC39;Initial Catalog=QLHN;Integrated Security=True";

        public List<HoiNghi> LoadDSHN()
        {
            List<HoiNghi> dshn = new List<HoiNghi>();
            dshn.Clear();
            SqlConnection conn = new SqlConnection(conStr);
            string sql = "select * from HoiNghi";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string ma = rdr.GetValue(0).ToString();
                string ten = rdr.GetValue(1).ToString();
                int sl = Convert.ToInt32(rdr.GetValue(2).ToString());
                string loai = rdr.GetValue(3).ToString();
                dshn.Add(new HoiNghi(ma, ten, loai, sl));
            }
            conn.Close();
            return dshn;
        }

        public List<HoiNghi> LoadDSHNcoDK(string mahn)
        {
            List<HoiNghi> dshn = new List<HoiNghi>();
            dshn.Clear();
            SqlConnection conn = new SqlConnection(conStr);
            string sql = "select * from HoiNghi where [maLoaiPhong] = '" + mahn + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string ma = rdr.GetValue(0).ToString();
                string ten = rdr.GetValue(1).ToString();
                int sl = Convert.ToInt32(rdr.GetValue(2).ToString());
                string loai = rdr.GetValue(3).ToString();
                dshn.Add(new HoiNghi(ma, ten, loai, sl));
            }
            conn.Close();
            return dshn;
        }

        public void ThemHoiNghi(HoiNghi hn)
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            string sql = "INSERT HoiNghi([maHoiNghi], [tenHoiNghi],[SoNguoi],[maLoaiPhong]) VALUES ('"+ hn.maHoiNghi +"', N'"+ hn.tenHoiNghi +"',"+ hn.soNguoi +",N'"+ hn.maLoaiPhong +"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void XoaHoiNghi(string ma)
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            string sql = "DELETE FROM HoiNghi WHERE [maHoiNghi] = '" + ma + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
