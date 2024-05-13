using quanlibanhang.Class;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace quanlibanhang.Form
{
    /// <summary>
    /// Interaction logic for frmSanPham.xaml
    /// </summary>
    public partial class frmSanPham : Page
    {
        public frmSanPham()
        {
            InitializeComponent();
            ConnectToData();
            LoadDataSanPham();
            Laydulieu();
        }

        private void themSp_Click(object sender, RoutedEventArgs e)
        {
            frmThemSp frmtsp = new frmThemSp();
            frmtsp.Show();
        }

        private SQLiteConnection connection;

<<<<<<< HEAD
        private string database = "C:\\Users\\Hoang Anh\\source\\repos\\quanlibanhang\\quanlibanhang\\quanlibanhang\\Database";
=======
        private string database = "C:\\Users\\Hoang Anh\\Documents\\Zalo Received Files\\quanlibanhang\\quanlibanhang\\quanlibanhang\\Database\\Data_Market_Manager.db";
>>>>>>> 79c7fb85228546f9233a4db1fbd99d1423c785bd


        // Kết nối cơ sở dữ liệu
        private void ConnectToData()
        {
            connection = new SQLiteConnection($"Data Source = {database}");
            connection.Open();
        }
        private void LoadDataSanPham()
        {
            SQLiteCommand commandsp = new SQLiteCommand("SELECT * FROM SanPham ORDER BY MaSp ASC", connection);
            SQLiteDataReader readersp = commandsp.ExecuteReader();
            List<SanPham> sp = new List<SanPham>();
            while (readersp.Read())
            {
                sp.Add(new SanPham()
                {
                    MaSp = readersp.GetString(0),
                    TenSp = readersp.GetString(1),
                    SoLuong = readersp.GetInt32(2),
                    NgayNhap = readersp.GetString(3),
                    LoaiHang = readersp.GetString(4),
                    GiaNhap = readersp.GetInt32(5),
                    GiaBan = readersp.GetInt32(6),
                });
            }
            SanphamDataGrid.ItemsSource = sp;
        }

        // Hiển thị loại sản phẩm lên cbb
        private void Laydulieu()
        {
            SQLiteCommand commandldl = new SQLiteCommand("SELECT LoaiHang FROM SanPham", connection);
            SQLiteDataReader readerldl = commandldl.ExecuteReader();

            HashSet<string> LoaiHanglist = new HashSet<string>();
            while (readerldl.Read())
            {
                string LoaiSp = readerldl.GetString(readerldl.GetOrdinal("LoaiHang"));
                LoaiHanglist.Add(LoaiSp);
            }
            cbLoaiSp.ItemsSource = LoaiHanglist;
        }

        private void SanphamDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SanphamDataGrid.SelectedItem != null)
            {
                SanPham selectedSanPham = (SanPham)SanphamDataGrid.SelectedItem;
                cbLoaiSp.Text = selectedSanPham.LoaiHang;
            }
        }

        private void SuaSP_Click(object sender, MouseButtonEventArgs e)
        {
            SanPham selectSp = (SanPham)SanphamDataGrid.SelectedItem as SanPham;

            if (selectSp != null)
            {
                string MaSP = selectSp.MaSp;
                frmThemSp frmThemSp = new frmThemSp(MaSP);
                frmThemSp.ShowDialog();
            }
        }


        // Lọc sản phẩm theo loại 
        private void btnLocSp_Click(object sender, RoutedEventArgs e)
        {
            string selectedLoaiHang = cbLoaiSp.SelectedItem as string; // Lấy loại hàng được chọn trên ComboBox
            if (selectedLoaiHang != null)
            {
                FilterSanPham(selectedLoaiHang); // Gọi hàm để lọc sản phẩm theo loại hàng được chọn
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại hàng để lọc.");
            }
        }

        private void FilterSanPham(string loaiHang)
        {
            string query = "SELECT * FROM SanPham WHERE LoaiHang = @LoaiHang";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@LoaiHang", loaiHang);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    List<SanPham> sp = new List<SanPham>();
                    while (reader.Read())
                    {
                        sp.Add(new SanPham()
                        {
                            MaSp = reader.GetString(0),
                            TenSp = reader.GetString(1),
                            SoLuong = reader.GetInt32(2),
                            NgayNhap = reader.GetString(3),
                            LoaiHang = reader.GetString(4),
                            GiaNhap = reader.GetInt32(5),
                            GiaBan = reader.GetInt32(6),
                        });
                    }
                    SanphamDataGrid.ItemsSource = sp;
                }
            }
        }

        // Xóa sản phẩm
        private void btnXoaSp_Click(object sender, RoutedEventArgs e)
        {
            if (SanphamDataGrid.SelectedItems.Count > 0)
            {
                SanPham selectedSanPham = (SanPham)SanphamDataGrid.SelectedItem;
                string query = "DELETE FROM SanPham WHERE MaSp = @MaSp";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@MaSp", selectedSanPham.MaSp);
                command.ExecuteNonQuery();
                LoadDataSanPham();
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }

        }

        private void UpdateDL_Click(object sender, RoutedEventArgs e)
        {
            LoadDataSanPham();
            cbLoaiSp.Text = "";
        }
    }
}
