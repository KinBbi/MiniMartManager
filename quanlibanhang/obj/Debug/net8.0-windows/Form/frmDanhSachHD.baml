   M S B A M L   `   `   `  ����H  Dquanlibanhang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:quanlibanhang.Formquanlibanhang.Form  5      &     quanlibanhang.Form.frmDanhSachHD   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:quanlibanhang.Form     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	     N� Title$  frmDanhSachHD��5	      $	��600��6   $
��1020��6+      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper N� 
Background# �  5   	     MaterialDesignFont N� 
FontFamily# �  5   	   .��5      � .+�5   
   �� .+�5      �� $��DANH SÁCH HÓA ĐƠN��6   $��27(�60   $
��Bold"�6>   
����  �$��Center=�6f   $��0,15,0,0q�6�   $��45��6�   � 5      $��	35 15 0 0q�6   $��80��6&   $	��700��62    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��Center=�6   .+�5      ��  �� Orientation$ 
Horizontal=�6!   $��40��6:   .+�5      �� $��Center=�6    $��90��6;   .��6G   Mã Hóa Đơn6S   �� 5      -   5         ��Name$ txtMaHD��5       $��30��5!      $��5q�5"      $��13(�5#       ! MaterialDesignOutlinedTextBox#��[ 5%       �� TextWrapping$
 Wrap=�5&      "	 �� VerticalScrollBarVisibility$
	 Auto=�5'      $	��170��6@   {�5$      �� *	IsChecked+
 �� ElementName$2
 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5'   @   5(      �� 5)      $ 
Horizontal=�6!   $��40��6:   .+�5*      �� $��Center=�6    $��90��6;   .��6F   Mã Nhân Viên6T   �� 5+      -   5        $ txtMaNV��5,   !   $��30��5-   !   $��5q�5.   !   $��13(�5/   !   #��[ 51   !   $
 Wrap=�52   !   $
	 Auto=�53   !   $	��170��6D   {�50   !   �� *	IsChecked+$2
 ,MaterialDesignOutlinedTextBoxEnabledComboBox��53   D   54      58      �� 59      $��1��6   $��10 0 0 0q�6.   .+�5:      �� $ 
Horizontal=�6!   $��40��6:   .+�5;      �� $��Center=�6    $��75��6;   .��6F   Ngày tháng6R   (  "System.Windows.Controls.DatePicker  5<      -   5          Name$ txtNgayThang��5=      $	��170��5>      $��30��5?      $��5q�5@      $��15(�5A       $  MaterialDesignOutlinedDatePicker#��[ 5B      5C      �� 5D      $ 
Horizontal=�6!   $��40��6:   $	��Top=�6F   .+�5E      �� $��Center=�6    $��75��6;   .��6F   Tổng tiền6Q   �� 5F      -   5        $ txtTongTien��5G      $��30��5H      $��5q�5I      $��13(�5J      #��[ 5L      $
 Wrap=�5M      $
	 Auto=�5N      $	��170��6@   {�5K      �� *	IsChecked+$2
 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5N   @   5O      5P      5Q      �� 5R      $ 
Horizontal=�6   $��Center=�62   $��	0 20 0 20q�6O   .+�5S      �� -   5         ��Name$ 
btnTimKiem��5S      $��0 0 25 0q�6-   .��6Z   Tìm kiếm6d   �� 5T      -   5        $ 	btnLamMoi��5T      $��	25 0 25 0q�6,   .��6X   
Làm mới6a   �� 5U      -   5        $ btnXoa��5U      $��25 0 0 0q�6)   .��6P   Xóa6U   �� 5V      -   5        $ 
btnChiTiet��5V      $��25 0 0 0q�6-   .��6Y   
Chi Tiết6c   5W      �� 5X      $��Center=�6   .+�5Y      &   System.Windows.Controls.DataGrid  -	   5          Name$ dgDanhSachHD��5Y      $	��194��61   $	��600��6>   $��0 15 0 5q�6M      
IsReadOnly$
 True��6_   6�   5Z      5\      5]      5^      