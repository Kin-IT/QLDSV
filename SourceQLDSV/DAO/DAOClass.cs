using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using LOGIN;
using System.Data;
using SourceQLDSV.DTO;

namespace DAO
{
    public class DAOClass
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
        public void ThemLop(DTOClass L)
        {
            OpenConnect();
            string insert = "insert into [QLDSV].[QLDSV].[Class] values (@CodeClass, @NameClass, @NameFaculty)";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add(new SqlParameter("@CodeClass", L.MaLop));
            cmd.Parameters.Add(new SqlParameter("@NameClass", L.TenLop));
            cmd.Parameters.Add(new SqlParameter("@NameFaculty", L.TenKhoa));
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
        public void SuaLop(DTOClass L)
        {
            OpenConnect();
            string edit = "update [QLDSV].[QLDSV].[Class] set tenlop=@NameClass, tenkhoa=@NameFaculty where malop=@CodeClass";
            SqlCommand cmd = new SqlCommand(edit, conn);
            cmd.Parameters.Add(new SqlParameter("@CodeClass", L.MaLop));
            cmd.Parameters.Add(new SqlParameter("@NameClass", L.TenLop));
            cmd.Parameters.Add(new SqlParameter("@NameFaculty", L.TenKhoa));
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
        public void XoaLop(string MaMH)
        {
            OpenConnect();
            string delete = "delete from [QLDSV].[QLDSV].[Class] where malop=@CodeClass";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.Parameters.Add(new SqlParameter("@CodeSubject", MaMH));
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
        public DataTable HienThiDS()
        {
            OpenConnect();
            DataTable dt = new DataTable();
            string ht = "select * from [QLDSV].[QLDSV].[Class]";
            SqlCommand cmd = new SqlCommand(ht, conn);
            dt.Load(cmd.ExecuteReader());
            CloseConnect();
            return dt;
        }
    }
}
