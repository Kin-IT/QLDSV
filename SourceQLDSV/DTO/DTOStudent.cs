using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceQLDSV.DTO
{
    class DTOStudent
    {
        private string _MaSV;
        private string _HoSV;
        private string _TenSV;
        private int _ID;
        private string _MaLop;
        private string _NgaySinh;
        private string _Avata;
        private string _GioiTinh;
        private string _DiaChi;
        private string _SDT;
        private string _Email;
        private string _Created;
        private string _Updated;

        public string MaSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }
        }
        public string HoSV
        {
            get { return _HoSV; }
            set { _HoSV = value; }
        }
        public string TenSV
        {
            get { return _TenSV; }
            set { _TenSV = value; }
        }
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
        public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public string Avata
        {
            get { return _Avata; }
            set { _Avata = value; }
        }
        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
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
        public DTOStudent(string pMaSV, string pHo, string pTen, int pID, string pMaLop, string pNgaySinh, string pAvata,
            string pGioiTinh, string pDiaChi, string pSDT, string pEmail, string pCreated, string pUpdated)
        {
            this._MaSV = pMaSV;
            this._HoSV = pHo;
            this._TenSV = pHo;
            this._ID = pID;
            this._MaLop = pMaLop;
            this._NgaySinh = pNgaySinh;
            this._Avata = pAvata;
            this._GioiTinh = pGioiTinh;
            this._DiaChi = pDiaChi;
            this._SDT = pSDT;
            this._Email = pEmail;
            this._Created = pCreated;
            this._Updated = pUpdated;
        }
    }
}
