using DTO;
using LOGIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOFaculty
    {
        SqlConnection conn;
        public void OpenConnect()
        {
            string strConnect = Connect.str;
            conn = new SqlConnection(strConnect);
            conn.Open();
        }
        public void CloseConnect()
        {
            conn.Close();
        }
        public void ThemK(DTOFaculty K)
        {
            OpenConnect();
            string insert = "insert into [QLDSV].[QLDSV].[Faculty] values (@CodeFaculty, @NameFaculty)";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add(new SqlParameter("@CodeFaculty", K.MaKhoa));
            cmd.Parameters.Add(new SqlParameter("@NameFaculty", K.TenKhoa));
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
        public void SuaK(DTOFaculty K)
        {
            OpenConnect();
            string edit = "update [QLDSV].[QLDSV].[Faculty] set tenkhoa=@NameFaculty where makhoa=@CodeFaculty";
            SqlCommand cmd = new SqlCommand(edit, conn);
            cmd.Parameters.Add(new SqlParameter("@CodeFaculty", K.MaKhoa));
            cmd.Parameters.Add(new SqlParameter("@NameFaculty", K.TenKhoa));
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
        public void XoaK(string CodeFaculty)
        {
            OpenConnect();
            string delete = "delete from [QLDSV].[QLDSV].[Faculty] where makhoa=@CodeFaculty";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.Parameters.Add(new SqlParameter("@CodeFaculty", MaKhoa));
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
        public DataTable HienThiDS()
        {
            OpenConnect();
            DataTable dt = new DataTable();
            string ht = "select * from [QLDSV].[QLDSV].[Faculty]";
            SqlCommand cmd = new SqlCommand(ht, conn);
            dt.Load(cmd.ExecuteReader());
            CloseConnect();
            return dt;
        }
    }
}
