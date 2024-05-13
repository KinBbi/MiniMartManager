using quanlibanhang.Class;
using System.Data.SQLite;
using System.Windows.Controls;

namespace quanlibanhang.Form
{
    /// <summary>
    /// Interaction logic for frmDoanhThu.xaml
    /// </summary>
    public partial class frmDoanhThu : Page
    {
        public frmDoanhThu()
        {
            InitializeComponent();
            ConnectToData();
            ThongKe();
            DoanhThu();
        }


        private SQLiteConnection connection;

        private string database = "C:\\Users\\Hoang Anh\\source\\repos\\quanlibanhang\\quanlibanhang\\quanlibanhang\\Database";


        // Kết nối cơ sở dữ liệu
        private void ConnectToData()
        {
            connection = new SQLiteConnection($"Data Source = {database}");
            connection.Open();
        }
        public void ThongKe()
        {
            SQLiteCommand command = new SQLiteCommand("SELECT a.TenSP,a.LoaiHang, b.SoLuongBan,a.GiaBan, c.NgayBan FROM SanPham AS a, ChiTietHD AS b, DanhSachHD as c WHERE a.MaSP = b.MaSP AND b.MaHD = c.MaHD ORDER BY c.NgayBan DESC", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<ThongKe> thongKes = new List<ThongKe>();
            while (reader.Read())
            {
                thongKes.Add(new ThongKe()
                {
                    TenSP = reader.GetString(0),
                    LoaiHang = reader.GetString(1),
                    SoLuongBan = reader.GetInt32(2),
                    GiaBan = reader.GetInt32(3),
                    NgayBan = reader.GetString(4)
                });
                dg_tkdt.ItemsSource = thongKes;
            }


        }

        public void DoanhThu()
        {
            SQLiteCommand commandtn = new SQLiteCommand("SELECT GiaNhap, SoLuong FROM SanPham", connection);
            SQLiteDataReader readertn = commandtn.ExecuteReader();
            List<int> giaNhap = new List<int>();
            while (readertn.Read())
            {
                int GiaNhap = readertn.GetInt32(readertn.GetOrdinal("GiaNhap"));
                int SoLuong = readertn.GetInt32(readertn.GetOrdinal("SoLuong"));
                int tongnhap = GiaNhap * SoLuong;
                giaNhap.Add(tongnhap);
            }

            int TongNhap = 0;
            for (int i = 0; i < giaNhap.Count; i++)
            {
                TongNhap += giaNhap[i];
            }
            tbTongNhap.Text = TongNhap.ToString();

            SQLiteCommand commandtb = new SQLiteCommand("SELECT TongTien FROM DanhSachHD", connection);
            SQLiteDataReader readertb = commandtb.ExecuteReader();
            List<int> tongTien = new List<int>();
            while (readertb.Read())
            {
                int tongtien = readertb.GetInt32(readertb.GetOrdinal("TongTien"));
                tongTien.Add(tongtien);
            }
            int TongBan = 0;
            for (int i = 0; i < tongTien.Count; i++)
            {
                TongBan += tongTien[i];
            }
            tbTongBan.Text = TongBan.ToString();

            int TienLai = TongBan - TongNhap;

            tbTienLai.Text = TienLai.ToString();
        }
    }
}
