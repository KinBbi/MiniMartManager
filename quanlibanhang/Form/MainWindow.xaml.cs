using quanlibanhang.Form;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace quanlibanhang
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HighlightMenuItem(menuItemTrangChu);
        }


        //Sự kiện thanh navi 
        private void btnSanPham(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            Main.Content = new frmSanPham();
            menuItemHoaDon.Foreground = Brushes.Black;
            menuItemHoaDon.FontSize = 14;
            HighlightMenuItem(menuItem);
        }

        private void btnNhanVien(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            Main.Content = new frmNhanVien();
            menuItemHoaDon.Foreground = Brushes.Black;
            menuItemHoaDon.FontSize = 14;
            HighlightMenuItem(menuItem);
        }

        private void btnTrangChu(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            Main.Content = new frmBanHang();
            menuItemHoaDon.Foreground = Brushes.Black;
            menuItemHoaDon.FontSize = 14;
            HighlightMenuItem(menuItem);
        }

        private void btnCTHD(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            Main.Content = new frmChiTietHD();
            HighlightMenuItem(menuItemDanhSachHD);
            menuItemHoaDon.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(103, 58, 183));
            menuItemHoaDon.FontSize = 18;
            HighlightMenuItem(menuItem);

        }

        private void btnTKHD(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            Main.Content = new frmDanhSachHD();
            HighlightMenuItem(menuItemChiTietHD);
            menuItemHoaDon.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(103, 58, 183));
            menuItemHoaDon.FontSize = 18;
            HighlightMenuItem(menuItem);

        }

        private void btnDoanhThu(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            Main.Content = new frmDoanhThu();
            menuItemHoaDon.Foreground = Brushes.Black;
            menuItemHoaDon.FontSize = 14;
            HighlightMenuItem(menuItem);
        }

        private MenuItem selectedItem = null;

        private void HighlightMenuItem(MenuItem menuItem)
        {
            if (selectedItem != null)
            {
                // Thiết lập kiểu chữ về bình thường?
                selectedItem.Foreground = Brushes.Black;
                selectedItem.FontSize = 14;
            }

            // Làm nổi bật MenuItem hiện tại
            selectedItem = menuItem;
            selectedItem.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(103, 58, 183));
            selectedItem.FontSize = 18;
        }
        //Kết thúc sự kiện thanh navi
        public void mofrom()
        {
            Main.Content = new frmChiTietHD();
        }



    }

}