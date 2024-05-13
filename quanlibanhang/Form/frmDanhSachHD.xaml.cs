using quanlibanhang.Class;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace quanlibanhang.Form
{
    /// <summary>
    /// Interaction logic for frmDanhSachHD.xaml
    /// </summary>
    public partial class frmDanhSachHD : Page
    {
        public frmDanhSachHD()
        {
            InitializeComponent();
            ConnectToData();
            LoadData();
        }

        private void CloseToData()
        {
            connection.Close();
        }


        private SQLiteConnection connection;
<<<<<<< HEAD
        private string database = "C:\\Users\\Hoang Anh\\source\\repos\\quanlibanhang\\quanlibanhang\\quanlibanhang\\Database";
=======
        private string database = "C:\\Users\\Hoang Anh\\Documents\\Zalo Received Files\\quanlibanhang\\quanlibanhang\\quanlibanhang\\Database\\Data_Market_Manager.db";
>>>>>>> 79c7fb85228546f9233a4db1fbd99d1423c785bd

        private void ConnectToData()
        {
            connection = new SQLiteConnection($"Data Source = {database}");
            connection.Open();
        }

        private void LoadData()
        {
            SQLiteCommand commandnv = new SQLiteCommand("SELECT * FROM DanhSachHD ORDER BY MaHD ASC", connection);
            SQLiteDataReader readernv = commandnv.ExecuteReader();

            List<DanhSachHD> HD = new List<DanhSachHD>();
            while (readernv.Read())
            {
                HD.Add(new DanhSachHD()
                {
                    MaHD = readernv.GetString(0),
                    MaNV = readernv.GetString(1),
                    NgayBan = readernv.GetString(2),
                    TongTien = readernv.GetInt32(3),
                });
            }
            dgDanhSachHD.ItemsSource = HD;
        }



        private void dgDanhSachHD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgDanhSachHD.SelectedItem != null && dgDanhSachHD.SelectedItem is DanhSachHD)
            {
                DanhSachHD selectedHD = (DanhSachHD)dgDanhSachHD.SelectedItem;
                txtMaHD.Text = selectedHD.MaHD;
                txtMaNV.Text = selectedHD.MaNV;
                txtNgayThang.Text = selectedHD.NgayBan;
                txtTongTien.Text = selectedHD.TongTien.ToString();
            }
        }

        private void SearchData(string maHD, string maNV, string ngayBan, int tongTien)
        {
            // Xóa các dữ liệu hiện tại trong DataGrid
            dgDanhSachHD.ItemsSource = null;

            // Tạo câu truy vấn dựa trên thông tin tìm kiếm
            string query = "SELECT * FROM DanhSachHD WHERE 1=1";
            if (!string.IsNullOrEmpty(maHD))
            {
                query += $" AND MaHD = '{maHD}'";
            }
            if (!string.IsNullOrEmpty(maNV))
            {
                query += $" AND MaNV = '{maNV}'";
            }
            if (!string.IsNullOrEmpty(ngayBan))
            {
                query += $" AND DATE(NgayBan) = DATE('{ngayBan}')";
            }

            if (tongTien != 0)
            {
                query += $" AND TongTien = {tongTien}";
            }

            // Thực hiện truy vấn và load dữ liệu vào DataGrid
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<DanhSachHD> HD = new List<DanhSachHD>();
            while (reader.Read())
            {
                HD.Add(new DanhSachHD()
                {
                    MaHD = reader.GetString(0),
                    MaNV = reader.GetString(1),
                    NgayBan = reader.GetString(2),
                    TongTien = reader.GetInt32(3),
                });
            }
            dgDanhSachHD.ItemsSource = HD;

            // Xóa nội dung của các TextBox
            txtMaHD.Text = "";
            txtMaNV.Text = "";
            txtNgayThang.Text = "";
            txtTongTien.Text = "";
        }



        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            string maHD = txtMaHD.Text.Trim();
            string maNV = txtMaNV.Text.Trim();
            string ngayThang = txtNgayThang.SelectedDate?.ToString("yyyy-MM-dd");
            int tongTien = 0;
            int.TryParse(txtTongTien.Text.Trim(), out tongTien);

            SearchData(maHD, maNV, ngayThang, tongTien);
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {

            // Xóa nội dung của các TextBox
            txtMaHD.Text = "";
            txtMaNV.Text = "";
            txtNgayThang.Text = "";
            txtTongTien.Text = "";
            LoadData();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (dgDanhSachHD.SelectedItems.Count > 0)
            {
                DanhSachHD selectedDSHD = (DanhSachHD)dgDanhSachHD.SelectedItem;
                string query = "DELETE FROM DanhSachHD WHERE MaHD = @MaHD";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@MaHD", selectedDSHD.MaHD);
                command.ExecuteNonQuery();

                LoadData();
                txtMaHD.Text = "";
                txtMaNV.Text = "";
                txtNgayThang.Text = "";
                txtTongTien.Text = "";
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
            }

        }
        private void btnChiTiet_Click(object sender, RoutedEventArgs e)
        {
            DanhSachHD selectedHD = (DanhSachHD)dgDanhSachHD.SelectedItem;

            if (selectedHD != null)
            {
                string maHD = selectedHD.MaHD;

                frmChiTietHD ChiTietwTS = new frmChiTietHD(maHD);
                NavigationService.Navigate(ChiTietwTS);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
            }
        }

    }

}
