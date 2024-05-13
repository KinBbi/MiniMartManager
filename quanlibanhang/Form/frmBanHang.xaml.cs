using quanlibanhang.Class;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;

namespace quanlibanhang.Form
{
    /// <summary>
    /// Interaction logic for frmBanHang.xaml
    /// </summary>
    public partial class frmBanHang : Page
    {
        public frmBanHang()
        {
            InitializeComponent();
            ConnectToData();
            LaydulieuSp();
            LaydulieuNv();
        }



        private SQLiteConnection connection;

        private string database = "C:\\Users\\Hoang Anh\\Documents\\Zalo Received Files\\quanlibanhang\\quanlibanhang\\quanlibanhang\\Database\\Data_Market_Manager.db";


        // Kết nối cơ sở dữ liệu
        private void ConnectToData()
        {
            connection = new SQLiteConnection($"Data Source = {database}");
            connection.Open();
        }
        private void LaydulieuSp()
        {
            SQLiteCommand commandldl = new SQLiteCommand("SELECT TenSP FROM SanPham", connection);
            SQLiteDataReader readerldl = commandldl.ExecuteReader();
            HashSet<string> TenSanPhamList = new HashSet<string>();
            while (readerldl.Read())
            {
                string Tensp = readerldl.GetString(readerldl.GetOrdinal("TenSP"));
                TenSanPhamList.Add(Tensp);
            }
            cbbTenSp.ItemsSource = TenSanPhamList;
        }
        private void LaydulieuNv()
        {
            SQLiteCommand commadldlnv = new SQLiteCommand("SELECT TenNv FROM NhanVien", connection);
            SQLiteDataReader readerldlnv = commadldlnv.ExecuteReader();

            List<string> ListTenNv = new List<string>();
            while (readerldlnv.Read())
            {
                string tennv = readerldlnv.GetString(readerldlnv.GetOrdinal("TenNv"));
                ListTenNv.Add(tennv);
            }
            cbbTenNv.ItemsSource = ListTenNv;
        }


        // Thêm sản phẩm vào datagrid 
        private List<SanPhamBan> danhSachSPban = new List<SanPhamBan>();
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cbbTenSp.SelectedItem != null && !string.IsNullOrEmpty(txtSoLuongBan.Text))
            {
                string tenSanPham = cbbTenSp.SelectedItem.ToString();
                string query = $"SELECT MaSP, GiaBan, LoaiHang FROM SanPham WHERE TenSP = '{tenSanPham}'";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string maSanPham = reader.GetString(0);
                            int giaBan = reader.GetInt32(1);
                            int soLuongBan = int.Parse(txtSoLuongBan.Text);
                            int thanhTien = giaBan * soLuongBan;

                            SanPhamBan sanPham = new SanPhamBan
                            {
                                MaSp = maSanPham,
                                TenSp = tenSanPham,
                                GiaBan = giaBan,
                                SoLuongBan = soLuongBan,
                                ThanhTien = thanhTien
                            };


                            danhSachSPban.Add(sanPham);

                            dg_BanHang.ItemsSource = null;
                            dg_BanHang.ItemsSource = danhSachSPban;

                            cbbTenSp.Text = "";
                            txtSoLuongBan.Text = "";

                        }
                    }
                }
                TinhTongTien();
            }
            else if (cbbTenSp.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn số lượng!");
            }
        }


        // xóa sản phẩm bán
        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            List<SanPhamBan> selectedItems = dg_BanHang.SelectedItems.Cast<SanPhamBan>().ToList();

            foreach (var item in selectedItems)
            {
                danhSachSPban.Remove(item);
            }

            // Cập nhật DataGrid để hiển thị danh sách mới đã được cập nhật
            dg_BanHang.ItemsSource = null;
            dg_BanHang.ItemsSource = danhSachSPban;

            TinhTongTien();

        }

        private void TinhTongTien()
        {
            int tongTien = 0;
            foreach (var sanPham in danhSachSPban)
            {
                tongTien += sanPham.ThanhTien;
            }

            tbTongTien.Text = tongTien.ToString();
        }


        // Tạo hóa đơn khi bán hàng
        private void LuuChiTietHoaDon(string maHoaDon, string maSanPham, int soLuongBan, int tongTien)
        {
            string query = "INSERT INTO ChiTietHD (MaHD, MaSP, SoLuongBan, ThanhTien) VALUES (@MaHoaDon, @MaSanPham, @SoLuongBan, @ThanhTien)";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                command.Parameters.AddWithValue("@MaSanPham", maSanPham);
                command.Parameters.AddWithValue("@SoLuongBan", soLuongBan);
                command.Parameters.AddWithValue("@ThanhTien", tongTien);
                command.ExecuteNonQuery();
            }
        }

        private void LuuDanhSachHoaDon(string maHoaDon, string maNhanVien, DateTime ngayThang, int tongTien)
        {
            string query = "INSERT INTO DanhSachHD (MaHD, MaNv, NgayBan, TongTien) VALUES (@MaHoaDon, @MaNhanVien, @NgayBan, @TongTien)";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
                command.Parameters.AddWithValue("@NgayBan", ngayThang);
                command.Parameters.AddWithValue("@TongTien", tongTien);

                command.ExecuteNonQuery();
            }
        }

        private void TThoadon_Click(object sender, RoutedEventArgs e)
        {
            string maNhanVien = txtMaNV.Text;
            DateTime ngayThang = DateTime.Now;
            int tongTien = int.Parse(tbTongTien.Text);
            string maHD = txtMaHD.Text;


            LuuDanhSachHoaDon(maHD, maNhanVien, ngayThang, tongTien);

            foreach (var sanPham in danhSachSPban)
            {
                LuuChiTietHoaDon(maHD, sanPham.MaSp, sanPham.SoLuongBan, sanPham.ThanhTien);
            }
            
            MessageBox.Show("Thanh Toán Thành Công!");
            tbTongTien.Text = "";
        }

        private void xuatHD_Cick(object sender, RoutedEventArgs e)
        {
            string MaHD = txtMaHD.Text;
            Hienthihoadon ht = new Hienthihoadon(MaHD);
            ht.ShowDialog();
        }

        private void HuyHD_Click(object sender, RoutedEventArgs e)
        {
            txtMaHD.Text = "";
            cbbTenSp.Text = "";
            txtSoLuongBan.Text = "";
            txtMaNV.Text = "";
            cbbTenNv.Text = "";
            tbTongTien.Text = "";
            dg_BanHang.ItemsSource = "";
        }
        private void cbbTenNv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string tenNV = cbbTenNv.SelectedItem as string;

            string query = $"SELECT MaNV FROM NhanVien WHERE TenNV = '{tenNV}'";

            string maNV = "";
            string connectionString = $"Data Source={database}";

            // Sử dụng biến connectionString trong thao tác kết nối đến cơ sở dữ liệu SQLite
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maNV = reader["MaNV"].ToString();
                        }
                    }
                }
                txtMaNV.Text = maNV;
            }
        }

    }

}


