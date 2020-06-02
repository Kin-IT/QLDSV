using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
    // định nghĩa các cột trong db, để gán dữ liệu
{
    public class DTOFaculty
    {
        private string _TenKhoa;
        private string _MaKhoa;
        private int _ID;
        private string _Created;
        private string _Updated;
        public string TenKhoa
        {
            get { return _TenKhoa; }
            set { _TenKhoa = value; }
        }
        public string MaKhoa
        {
            get { return _MaKhoa; }
            set { _MaKhoa = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
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

         public DTOFaculty(string pMaKhoa, string pTenKhoa, int pID, string pCreated, string pUpdated)
        {
            this._MaKhoa = pMaKhoa;
            this._TenKhoa = pTenKhoa;
            this._ID = pID;
            this._Created = pCreated;
            this._Updated = pUpdated;
        }
    }
}
