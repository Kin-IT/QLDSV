using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceQLDSV.DTO
{
    public class DTOResult
    {
            private int _ID;
            private string _MaSV;
            private string _MaLop;
            private string _MaMon;
            private double _Diem20;
            private double _Diem30;
            private double _Diem50;
            private double _DiemTB;
            private string _PhanLoai;
            private string _HanhKiem;
            private string _HocKi;
            private string _NamHoc;
            private string _Created;
            private string _Updated;

            public int ID
            {
                get { return _ID; }
                set { _ID = value; }
            }
            public string MaLop
            {
                get { return _MaLop; }
                set { _MaLop = value; }
            }
            public string MaMon
            {
                get { return _MaMon; }
                set { _MaMon = value; }
            }
            public string MaSV
            {
                get { return _MaSV; }
                set { _MaSV = value; }
            }
            public double Diem20
            {
                get { return _Diem20; }
                set { _Diem20 = value; }
            }
            public double Diem30
            {
                get { return _Diem30; }
                set { _Diem30 = value; }
            }
            public double Diem50
            {
                get { return _Diem50; }
                set { _Diem50 = value; }
            }
            public double DiemTB
            {
                get { return _DiemTB; }
                set { _DiemTB = value; }
            }
            public string PhanLoai
            {
                get { return _PhanLoai; }
                set { _PhanLoai = value; }
            }
            public string HanhKiem
            {
                get { return _HanhKiem; }
                set { _HanhKiem = value; }
            }
            public string HocKi
            {
                get { return _HocKi; }
                set { _HocKi = value; }
            }
            public string NamHoc
            {
                get { return _NamHoc; }
                set { _NamHoc = value; }
            }
            public string Created
            {
                get { return _Created; }
                set { _Created = value; }
            }
            public string Updated
            {
                get { return _Updated; }
                set { _Updated = value; }
            }
            public DTOResult(int pID, string pMaLop, string pMaMon, string pMaSV, double pDiem20, 
                double pDiem30, double pDiem50, double pDiemTB, string pCreated, string pUpdated)
            {
                this._MaLop = pMaLop;
                this._TenLop = pTenLop;
                this._TenKhoa = pTenKhoa;
                this._ID = pID;
                this._Created = pCreated;
                this._Updated = pUpdated;
            }
    }
}
