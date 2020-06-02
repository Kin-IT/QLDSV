using SourceQLDSV.DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceQLDSV.BUS
{
    class BUSFaculty
    {
        DAOFaculty dk = new DAOFaculty();
        public void ThemK(DAOFaculty MH)
        {
            dk.ThemK(MH);
        }
        public void SuaKhoa(DAOFaculty MK)
        {
            dk.SuaK(MH);
        }
        public void XoaMH(string MaKhoa)
        {
            dk.XoaK(MaKhoa);
        }
        public DataTable HienThiDS()
        {
            return dk.HienThiDS();
        }
    }
}
