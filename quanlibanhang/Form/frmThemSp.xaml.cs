using System.Data.SQLite;
using System.Windows;

namespace quanlibanhang.Form
{
    /// <summary>
    /// Interaction logic for frmThemSp.xaml
    /// </summary>
    public partial class frmThemSp : Window
    {
        private string MaSP;
        public frmThemSp()
        {
            InitializeComponent();
        }
        public frmThemSp(string MaSP)
        {
            InitializeComponent();
            this.MaSP = MaSP;
            ConnectToData();
            LoadData();
        }

        private SQLiteConnection connection;

        private string database = "C:\\Users\\Hoang Anh\\source\\repos\\quanlibanhang\\quanlibanhang\\quanlibanhang\\Database";
        private void ConnectToData()
        {
            connection = new SQLiteConnection($"Data Source = {database}");
            connection.Open();
        }
        private void LoadData()
        {
            string query = $"SELECT * FROM SanPham WHERE MaSP = '{MaSP}';";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                txtMaSp.Text = reader.GetString(0);
                txtTenSp.Text = reader.GetString(1);
                txtSoLuong.Text = reader.GetInt32(2).ToString();
                txtNgayNhap.Text = reader.GetString(3);
                txtLoaiHang.Text = reader.GetString(4);
                txtGiaNhap.Text = reader.GetInt32(5).ToString();
                txtGiaBan.Text = reader.GetInt32(6).ToString();
            }
        }
        

        private void btnLuuSp_Click(object sender, RoutedEventArgs e)
        {
            //"C:\\Users\\Hoang Anh\\Documents\\Zalo Received Files\\quanlibanhang\\quanlibanhang\\quanlibanhang\\Database\\Data_Market_Manager.db"
            string connectionString = "Data Source=C:\\Users\\Hoang Anh\\Documents\\Zalo Received Files\\quanlibanhang\\quanlibanhang\\quanlibanhang\\Database\\Data_Market_Manager.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO SanPham (MaSP,TenSp,SoLuong,NgayNhap,LoaiHang,GiaNhap,GiaBan) VALUES (@MaSp,@TenSp,@SoLuong,@NgayNhap,@LoaiHang,@GiaNhap,@GiaBan)";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaSp", txtMaSp.Text);
                    command.Parameters.AddWithValue("@TenSp", txtTenSp.Text);
                    command.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                    command.Parameters.AddWithValue("@NgayNhap", txtNgayNhap.Text);
                    command.Parameters.AddWithValue("@LoaiHang", txtLoaiHang.Text);
                    command.Parameters.AddWithValue("@GiaNhap", txtGiaNhap.Text);
                    command.Parameters.AddWithValue("@GiaBan", txtGiaBan.Text);
                    command.ExecuteNonQuery();

                    txtMaSp.Text = "";
                    txtTenSp.Text = "";
                    txtNgayNhap.Text = "";
                    txtGiaNhap.Text = "";
                    txtLoaiHang.Text = "";
                    txtGiaBan.Text = "";
                    txtSoLuong.Text = "";

                    MessageBox.Show("Thêm thành công");
                }
            }
        }

        private void btnSuaSp_Click(object sender, RoutedEventArgs e)
        {
            SQLiteCommand command = new SQLiteCommand("UPDATE SanPham SET MaSP = @MaSP, TenSp = @TenSp, SoLuong = @SoLuong, NgayNhap = @NgayNhap, LoaiHang = @LoaiHang, GiaNhap = @GiaNhap, GiaBan = @GiaBan WHERE MaSP = @MaSP", connection);
            command.Parameters.AddWithValue("MaSP", txtMaSp.Text);
            command.Parameters.AddWithValue("TenSp", txtTenSp.Text);
            command.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
            command.Parameters.AddWithValue("NgayNhap", txtNgayNhap.Text);
            command.Parameters.AddWithValue("LoaiHang", txtLoaiHang.Text);
            command.Parameters.AddWithValue("GiaNhap", txtGiaNhap.Text);
            command.Parameters.AddWithValue("GiaBan", txtGiaBan.Text);
            command.ExecuteNonQuery();
            txtMaSp.Text = " ";
            txtTenSp.Text = " ";
            txtSoLuong.Text = "";
            txtNgayNhap.Text = " ";
            txtLoaiHang.Text = " ";
            txtGiaNhap.Text = " ";
            txtGiaBan.Text = " ";

            MessageBox.Show("Cập nhật thành công");
        }
    }
}
