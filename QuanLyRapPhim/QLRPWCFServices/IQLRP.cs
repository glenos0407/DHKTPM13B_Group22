using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QLRPWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQLRP" in both code and config file together.
    [ServiceContract]
    public interface IQLRP
    {
        [OperationContract]
        eNhanVien CreateNhanVien(eNhanVien nv);

        [OperationContract]
        ePhim GetPhimById(int id);

        [OperationContract]
        eRapPhim GetRapPhimById(int id);

        [OperationContract]
        eVe CreateVe(eVe ve);

        [OperationContract]
        eVe GetVe(int idVe);

        [OperationContract]
        ePhim CreatePhim(ePhim phim);

        [OperationContract]
        eNhanVien DangNhap(int id, string password);

        [OperationContract]
        double ThongKeDoanhThu(DateTime startDate, DateTime endDate, int idPhim);

        [OperationContract]
        List<ePhim> GetPhimConChieu();

        [OperationContract]
        eSuatChieu GetSuatChieuByID(int id);
    }
}
