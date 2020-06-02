using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceQLDSV.DTO
{
    class DTOClass
    {
        class DTOLop
        {
            private string _TenLop;
            private string _MaLop;
            private string _TenKhoa;
            private int _ID;
            private string _Created;
            private string _Updated;

            public string TenLop
            {
                get { return _TenLop; }
                set { _TenLop = value; }
            }
            public string MaLop
            {
                get { return _MaLop; }
                set { _MaLop = value; }
            }
            public string TenKhoa
            {
                get { return _TenKhoa; }
                set { _TenKhoa = value; }
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
            public DTOLop(string pMaLop, string pTenLop, string pTenKhoa, int pID, string pCreated, string pUpdated)
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
}
