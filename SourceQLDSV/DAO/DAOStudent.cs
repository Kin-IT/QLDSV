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
    public class DAOStudent
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
        public void ThemSinhVien(DTOStudent SV)
        {
            OpenConnect();
            string insert = "insert into [QLDSV].[QLDSV].[Student] values (@CodeStudent, @FirstName, @LastName, @CodeClass)";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add(new SqlParameter("@CodeStudent", SV.MaSV));
            cmd.Parameters.Add(new SqlParameter("@FirstName", SV.HoSV));
            cmd.Parameters.Add(new SqlParameter("@LastName", SV.TenSV));
            cmd.Parameters.Add(new SqlParameter("@CodeClass", SV.MaLop));
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
        public void SuaSinhVien(DTOStudent SV)
        {
            OpenConnect();
            string edit = "update [QLDSV].[QLDSV].[Student] set HoSV=@FirstName, TenSV=@LastName where MaSV=@CodeStudent";
            SqlCommand cmd = new SqlCommand(edit, conn);
            cmd.Parameters.Add(new SqlParameter("@FirstName", SV.HoSV));
            cmd.Parameters.Add(new SqlParameter("@LastName", SV.TenSV));
            cmd.Parameters.Add(new SqlParameter("@CodeStudent", SV.MaSV));
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
        public void XoaSinhVien(string MaSV)
        {
            OpenConnect();
            string delete = "delete from [QLDSV].[QLDSV].[Student] where mssv=@CodeStudent";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.Parameters.Add(new SqlParameter("@CodeStudent", MaSV));
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
        public DataTable HienThiDS()
        {
            OpenConnect();
            DataTable dt = new DataTable();
            string ht = "select * from [QLDSV].[dbo].[Student]";
            SqlCommand cmd = new SqlCommand(ht, conn);
            dt.Load(cmd.ExecuteReader());
            CloseConnect();
            return dt;
        }
    }
}
