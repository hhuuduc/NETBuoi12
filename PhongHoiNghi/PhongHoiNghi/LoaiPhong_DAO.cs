using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PhongHoiNghi
{
    class LoaiPhong_DAO
    {
        public LoaiPhong_DAO() { }

        public string conStr = "Data Source=A209PC39;Initial Catalog=QLHN;Integrated Security=True";

        public List<LoaiPhong> LoadDSP()
        {
            List<LoaiPhong> dsp = new List<LoaiPhong>();
            dsp.Clear();
            SqlConnection conn = new SqlConnection(conStr);
            string sql = "select * from LoaiPhong";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string ma = rdr.GetValue(0).ToString();
                string ten = rdr.GetValue(1).ToString();
                dsp.Add(new LoaiPhong(ma, ten));
            }
            conn.Close();
            return dsp;
        }

    }
}
