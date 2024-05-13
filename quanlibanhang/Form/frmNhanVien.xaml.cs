using quanlibanhang.Class;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;

namespace quanlibanhang.Form
{
    /// <summary>
    /// Interaction logic for frmNhanVien.xaml
    /// </summary>
    public partial class frmNhanVien : Page
    {
        public frmNhanVien()
        {
            InitializeComponent();
            ConnectToData();
            LoadDataNv();
        }

        private SQLiteConnection connection;
        private string database = "C:\\Users\\Hoang Anh\\source\\repos\\quanlibanhang\\quanlibanhang\\quanlibanhang\\Database";

        private void ConnectToData()
        {
            connection = new SQLiteConnection($"Data Source = {database}");
            connection.Open();
        }
        private void CloseToData()
        {
            connection.Close();
        }
        private void LoadDataNv()
        {
            SQLiteCommand commandnv = new SQLiteCommand("SELECT * FROM NhanVien ORDER BY MaNv ASC", connection);
            SQLiteDataReader readernv = commandnv.ExecuteReader();

            List<NhanVien> nv = new List<NhanVien>();
            while (readernv.Read())
            {
                nv.Add(new NhanVien()
                {
                    MaNv = readernv.GetString(0),
                    TenNv = readernv.GetString(1),
                    GioiTinh = readernv.GetString(2),
                    SoDienThoai = readernv.GetString(3),
                });
            }
            dgNhanVien.ItemsSource = nv;
        }

        private void ThemNv_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNv.Text) ||
                string.IsNullOrWhiteSpace(txtTenNv.Text) ||
                string.IsNullOrWhiteSpace(txtGioiTinh.Text) ||
                string.IsNullOrWhiteSpace(txtSdt.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            SQLiteCommand cmd = new SQLiteCommand("INSERT OR IGNORE INTO NhanVien (MaNv,TenNv,GioiTinh,SoDienThoai) VALUES (@MaNv,@TenNv,@GioiTinh,@SoDienThoai)", connection);
            cmd.Parameters.AddWithValue("@MaNv", txtMaNv.Text);
            cmd.Parameters.AddWithValue("@TenNv", txtTenNv.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
            cmd.Parameters.AddWithValue("@SoDienThoai", txtSdt.Text);
            cmd.ExecuteNonQuery();
            LoadDataNv();

            txtMaNv.Text = "";
            txtTenNv.Text = "";
            txtGioiTinh.Text = "";
            txtSdt.Text = "";

            MessageBox.Show("Thêm thành công!");
        }


        private void dgNhanVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgNhanVien.SelectedItem != null)
            {
                NhanVien selectedNhanVien = (NhanVien)dgNhanVien.SelectedItem;
                txtMaNv.Text = selectedNhanVien.MaNv;
                txtTenNv.Text = selectedNhanVien.TenNv;
                txtSdt.Text = selectedNhanVien.SoDienThoai;
                txtGioiTinh.Text = selectedNhanVien.GioiTinh;
            }
        }

        private void btnXoaNv_Click(object sender, RoutedEventArgs e)
        {
            if (dgNhanVien != null && dgNhanVien.SelectedItems != null)
            {
                if (dgNhanVien.SelectedItem != null)
                {
                    NhanVien selectedNhanVien = (NhanVien)dgNhanVien.SelectedItem;
                    string query = "DELETE FROM NhanVien WHERE MaNv = @MaNv";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNv", selectedNhanVien.MaNv);
                    command.ExecuteNonQuery();

                    LoadDataNv();
                    txtTenNv.Text = "";
                    txtMaNv.Text = "";
                    txtSdt.Text = "";
                    txtGioiTinh.Text = "";
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên");
                }


            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
        }


        private void btnCapNhatNv_Click(object sender, RoutedEventArgs e)
        {
            if (dgNhanVien.SelectedItem != null)
            {
                NhanVien selectedNhanVien = (NhanVien)dgNhanVien.SelectedItem;
                string query = "UPDATE NhanVien SET MaNv = @MaNv, TenNv = @TenNv, SoDienThoai = @SoDienThoai, GioiTinh = @GioiTinh WHERE MaNv = @MaNv";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@MaNv", txtMaNv.Text);
                command.Parameters.AddWithValue("@TenNv", txtTenNv.Text);
                command.Parameters.AddWithValue("@SoDienThoai", txtSdt.Text);
                command.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                command.ExecuteNonQuery();

                LoadDataNv();
                txtTenNv.Text = "";
                txtMaNv.Text = "";
                txtSdt.Text = "";
                txtGioiTinh.Text = "";

                MessageBox.Show("Cập nhật thành công!");

            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
        }

    }
}
