using quanlibanhang.Class;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace quanlibanhang.Form
{
    /// <summary>
    /// Interaction logic for frmChiTietHD.xaml
    /// </summary>
    public partial class frmChiTietHD : Page
    {
        private string maHD;
        public frmChiTietHD()
        {
            InitializeComponent();
        }

        public frmChiTietHD(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
            ConnectToData();
            LoadDataFromDatabase();
        }



        private SQLiteConnection connection;

        private string database = "C:\\Users\\Hoang Anh\\source\\repos\\quanlibanhang\\quanlibanhang\\quanlibanhang\\Database\\Data_Market_Manager.db";


        private void ConnectToData()
        {
            connection = new SQLiteConnection($"Data Source = {database}");
            connection.Open();
        }


        private void LoadDataFromDatabase()
        {
            LoadDanhSachHD();
            LoadChiTietHD();
        }

        private void LoadDanhSachHD()
        {
            string query = $"SELECT * FROM DanhSachHD WHERE MaHD = '{maHD}';";

            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                txtMaHD.Text = reader.GetString(0);
                cbbMaNV.Text = reader.GetString(1);
                txtNgayBan.Text = reader.GetString(2);
                txtTongTien.Text = reader.GetInt32(3).ToString();
            }
            reader.Close();

            string maNV = cbbMaNV.Text;
            query = $"SELECT TenNV FROM NhanVien WHERE MaNV = '{maNV}';";
            command = new SQLiteCommand(query, connection);
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                string tenNV = reader.GetString(0);
                txtTenNV.Text = tenNV;
            }
        }

        private void LoadChiTietHD()
        {
            //dgChiTietHD.Items.Clear();

            List<SanPhamBan> listSPB = new List<SanPhamBan>();

            string query = $"SELECT MaSP, SoLuongBan, ThanhTien FROM ChiTietHD WHERE MaHD = '{maHD}';";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string maSP = reader.GetString(0);
                int soLuongBan = reader.GetInt16(1);
                int tongTien = reader.GetInt32(2);

                string querySP = $"SELECT TenSP, GiaBan FROM SanPham WHERE MaSP = '{maSP}';";
                SQLiteCommand commandSP = new SQLiteCommand(querySP, connection);
                SQLiteDataReader readerSP = commandSP.ExecuteReader();
                string tenSP = "";
                int giaBan = 0;

                if (readerSP.Read())
                {
                    tenSP = readerSP.GetString(0);
                    giaBan = readerSP.GetInt32(1);
                }
                readerSP.Close();

                listSPB.Add(new SanPhamBan()
                {
                    MaSp = maSP,
                    TenSp = tenSP,
                    SoLuongBan = soLuongBan,
                    GiaBan = giaBan,
                    ThanhTien = tongTien
                });
            }

            dgChiTietHD.ItemsSource = listSPB;
        }


        private string selectedMaSP;
        private int giaBan1;
        private void dgChiTietHD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgChiTietHD.SelectedItem != null)
            {
                SanPhamBan selectedSPBan = (SanPhamBan)dgChiTietHD.SelectedItem;

                cbbMaSP.Text = selectedSPBan.MaSp;
                txtSoLuong.Text = selectedSPBan.SoLuongBan.ToString();
                txtGiaBan.Text = selectedSPBan.GiaBan.ToString();
                selectedMaSP = selectedSPBan.MaSp;
                giaBan1 = selectedSPBan.GiaBan;
            }
        }

        // xóa dòng 
        private void XoaDongDB(string maSP)
        {
            string query = $"DELETE FROM ChiTietHD WHERE MaSP = '{maSP}';";

            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Xóa dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa dữ liệu: {ex.Message}");
            }
        }
        private void UpdateTongTien()
        {
            int tongTien = 0;
            foreach (SanPhamBan sp in dgChiTietHD.ItemsSource)
            {
                tongTien += sp.ThanhTien;
            }
            txtTongTien.Text = tongTien.ToString();


            string query = $"UPDATE DanhSachHD SET TongTien = '{tongTien}' WHERE MaHD = '{maHD}';";

            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật tổng tiền vào cơ sở dữ liệu: {ex.Message}");
            }
        }
        private void dgChiTietHD_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgChiTietHD.SelectedItem != null)
            {
                SanPhamBan selectedSPBan = (SanPhamBan)dgChiTietHD.SelectedItem;

                XoaDongDB(selectedSPBan.MaSp);

                ((List<SanPhamBan>)dgChiTietHD.ItemsSource).Remove(selectedSPBan);

                UpdateTongTien();
                dgChiTietHD.Items.Refresh();
            }
        }
        // Hết xóa dòng 


        // Sửa hóa đơn 
        private void btnLuuHD(object sender, RoutedEventArgs e)
        {
            int soLuong = int.Parse(txtSoLuong.Text);

            UpdateDB(soLuong, giaBan1);
            UpdateTongTien();
        }

        private void UpdateDB(int soLuong, int giaBan)
        {

            int thanhTien = soLuong * giaBan;

            string query = $"UPDATE ChiTietHD SET SoLuongBan = {soLuong}, ThanhTien = {thanhTien} WHERE MaHD = '{maHD}' AND MaSP = '{selectedMaSP}'";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Cập nhật dữ liệu vào cơ sở dữ liệu thành công!");
            LoadChiTietHD();

        }
    }
}