   M S B A M L   `   `   `  ����H  Dquanlibanhang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:quanlibanhang.Formquanlibanhang.Form  5      %    quanlibanhang.Form.frmChiTietHD   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:quanlibanhang.Form     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     N� Title$  frmChiTietHD��5      $	��520��6   $
��1012��6*      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper N� 
Background# �  5   	     MaterialDesignFont N� 
FontFamily# �  5   	   .��5      � .+�5   
   �� .��5      �� .+�5      �� $��Center=�6   $	��Top=�6;   $	��800��6S   .+�5      �� $��HÓA ĐƠN BÁN HÀNG��6   $��27(�67   $
��Bold"�6E   
����  �$��Center=�6m   $��0,15,0,0q�6�   $��45��6�   $	��270��6�   �� 5      $��Thông Tin Chung��6   .��5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $	��376��6)   .+�5   "   �� $ 
Horizontal=�6-   $��0 0 0 5q�6G   .+�5   &   �� $��Mã Hóa Đơn: ��6,   $��Center=�6C   $��13(�6^   $��95��6l   �� 5   &   -   5         ��Name$ txtMaHD��5   .   $��30��5   )   $��5q�5   )   $��13(�5   )    ! MaterialDesignOutlinedTextBox#��[ 5    )    �� TextWrapping$
 Wrap=�5!   )   " �� VerticalScrollBarVisibility$
 Auto=�5"   )   $	��200��6L   	 J� RenderTransformOrigin$	 0.525,2.046&�6X   {�5   )   �� *	IsChecked+
 �� ElementName$2
 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5"   X   5#   #   �� 5$   "   $ 
Horizontal=�6-   $��0 0 0 5q�6F   .+�5%   &   �� $��Mã Nhân Viên: ��6,   $��Center=�6E   $��13(�6`   $��95��6n   �� 5&   &   -   5         ��Name$ cbbMaNV��5'   )   $	��200��5(   )   $��30��5)   )   $��5q�5*   )   $��13(�5+   )    �� 
IsEditable$
 True��5,   )    " MaterialDesignOutlinedComboBox#��[ 5/   )   {�5-   )   ��  �� Path$ 	IsChecked�$%
 OutlinedComboBoxEnabledCheckBox����5.   )   �� *ShortStringList+5/   )   50   #   51      �� 52      .+�53   "   �� $ 
Horizontal=�6-   $��0 0 0 5q�6F   .+�54   &   �� $��Tên Nhân Viên: ��6,   $��Center=�6F   $��13(�6a   $��95��6o   �� 55   &   -   5        $ txtTenNV��56   %   $��30��57   %   $��5q�58   %   #��[ 5:   %   $
 Wrap=�5;   %   $
 Auto=�5<   %   $	��200��6H   $	 0.525,2.046&�6T   {�59   %   �� $ 	IsChecked�$2
 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5<   T   5=   #   �� 5>   "   $ 
Horizontal=�6-   .+�5?   &   �� $��Ngày Bán: ��6,   $��Center=�6A   $��13(�6\   $��95��6j   (  "System.Windows.Controls.DatePicker  5@   &   -   5          Name$ 
txtNgayBan��5A   %   $	��148��5B   %   $��30��5C   %   $��5q�5D   %   $��15(�5E   %    $  MaterialDesignOutlinedDatePicker#��[ 5F   %   5G   #   5H      5I      5J      5K      �� 5M      $	��800��6   $��0 10 0 0q�6)   .+�5N      �� $��Thông tin Hóa Đơn��6   .��5O      �� .+�5P      �  � ColumnDefinitions 5Q   "   �� 5R   &   �� 5S   &   �� 5T   &    � RowDefinitions 5W   "   �� 5X   &   �� 5Y   &   .+�5[   "   �� $ 
Horizontal=�6-   $��0��6F   $��0��6S   $��	10 5 0 10q�6c   .+�5\   &   �� $��0 0 5 0q�6-   $��13(�6>   $��Center=�6L   .��6g   	Mã Hàng6p   �� 5]   &   -   5        $ cbbMaSP��5^   )   $	��179��5_   )   $��30��5`   )   $��5q�5a   )   $��13(�5b   )   $
 True��5c   )   #��[ 5f   )   {�5d   )   �� $ 	IsChecked�$%
 OutlinedComboBoxEnabledCheckBox����5e   )   �� *ShortStringList+5f   )   5g   #   �� 5i   "   $ 
Horizontal=�6-   $��0��6F   $��1��6S   $��	10 5 0 10q�6c   .+�5j   &   �� $��0 0 5 0q�6,   $��Center=�6=   $��13(�6X   .��6g   Số lượng6q   �� 5k   &   -   5        $ 
txtSoLuong��5l   )   $��30��5m   )   $��5q�5n   )   #��[ 5p   )   $
 Wrap=�5q   )   $
 Auto=�5r   )   $	��180��6L   $	 0.525,2.046&�6X   {�5o   )   �� $ 	IsChecked�$2
 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5r   X   5s   #   �� 5t   "   $ 
Horizontal=�6-   $��0��6F   $��2��6S   $��	10 5 0 10q�6c   .+�5u   &   �� $��0 0 5 0q�6,   $��Center=�6=   $��13(�6X   .��6f   	Giá bán6o   �� 5v   &   -   5        $ 	txtGiaBan��5w   )   $��30��5x   )   $��5q�5y   )   #��[ 5{   )   $
 Wrap=�5|   )   $
 Auto=�5}   )   $	��180��6L   $	 0.525,2.046&�6X   {�5z   )   �� $ 	IsChecked�$2
 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5}   X   5~   #   5      �� 5�      .+�5�   "   &   System.Windows.Controls.DataGrid  -   5          Name$ dgChiTietHD��5�   %   $	��200��5�   %      CanUserAddRows$ False��5�   %      
IsReadOnly$
 True��5�   %   5�   %   5�      � 5�      $	��780��6$   .+�5�   "   �� $��Right=�6-   $ 
Horizontal=�6D   $��Right=�6]   $��35��6y   .+�5�   &   �� $��0 0 10 0q�60   $��Center=�6B   $��13(�6]   Tổng tiền6w   �� 5�   &   -	   5        $ txtTongTien��5�   )   $��30��5�   )   $��5q�5�   )   #��[ 5�   )   $
 Wrap=�5�   )   $
 Auto=�5�   )   $	��140��6L   $	 0.525,2.046&�6X   {�5�   )   �� $ 	IsChecked�$2
 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5�   X   5�   #   5�      �� 5�      $ 
Horizontal=�6)   $��Center=�6B   .+�5�   "   �� -
   5        $��Lưu Hóa Đơn��5�   )   $	��133��6?   $��20 10 20 10q�6K   $��32��6`   6l   5�      5�      5�      5�      5�      5�      5�      5�      