using QuanLyQuanCafe_Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe_Winform.DAO
{
    public class BanDAO
    {
        private static BanDAO _Ins;

        public static BanDAO Ins
        {
            get
            {
                if (Ins == null)
                {
                    Ins = new BanDAO();
                }
                return BanDAO.Ins;
            }
            set => _Ins = value;
        }

        public static int BanDai = 90;
        public static int BanRong = 90;

        private BanDAO() { }

        public List<DataProvider.Ins.DB.>
    }
}
