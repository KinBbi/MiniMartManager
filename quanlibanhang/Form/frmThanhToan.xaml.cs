using quanlibanhang.Class;
using System.Data.SQLite;
using System.Windows;

namespace quanlibanhang.Form
{
    /// <summary>
    /// Interaction logic for Hienthihoadon.xaml
    /// </summary>
    public partial class Hienthihoadon : Window
    {
        public Hienthihoadon()
        {
            InitializeComponent();
        }
        private string maHD;
        public Hienthihoadon(string MaHD)
        {
            InitializeComponent();
            this.maHD = MaHD;
            ConnectToData();
            LoadData();


        }
        private SQLiteConnection connection;

        private string database = "C:\\Users\\Hoang Anh\\source\\repos\\quanlibanhang\\quanlibanhang\\quanlibanhang\\Database";


        // Kết nối cơ sở dữ liệu
        private void ConnectToData()
        {
            connection = new SQLiteConnection($"Data Source = {database}");
            connection.Open();
        }
        private void LoadData()
        {
            string query = $"SELECT a.MaHD,c.MaSP, c.TenSp,c.GiaBan, a.SoLuongBan, b.NgayBan, a.ThanhTien, b.TongTien FROM ChiTietHD AS a, DanhSachHD AS b, SanPham AS c WHERE a.MaHD = b.MaHD AND a.MaSP = c.MaSP AND a.MaHD = '{maHD}';";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<SanPhamBan> spb = new List<SanPhamBan>();

            while (reader.Read())
            {
                txb_MaHD.Text = reader.GetString(reader.GetOrdinal("MaHD"));
                spb.Add(new SanPhamBan()
                {
                    MaSp = reader.GetString(reader.GetOrdinal("MaSP")),
                    TenSp = reader.GetString(reader.GetOrdinal("TenSp")),
                    GiaBan = reader.GetInt32(reader.GetOrdinal("GiaBan")),
                    SoLuongBan = reader.GetInt32(reader.GetOrdinal("SoLuongBan")),
                    ThanhTien = reader.GetInt32(reader.GetOrdinal("ThanhTien"))

                });
                dg_htSP.ItemsSource = spb;
                txb_NgayBan.Text = reader.GetString(reader.GetOrdinal("NgayBan"));
                txb_TongTien.Text = reader.GetInt32(reader.GetOrdinal("TongTien")).ToString();
            }
        }
    }
}
