   M S B A M L   `   `   `  ����H  Dquanlibanhang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:quanlibanhang.Formquanlibanhang.Form  5      #    quanlibanhang.Form.frmBanHang   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:quanlibanhang.Form     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     N� Title$  
frmBanHang��5      $	��600��6   $
��1020��6(      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper N� 
Background# �  5   	     MaterialDesignFont N� 
FontFamily# �  5   	   .��5      � $��0,10,0,0q�6   .+�5   
   �� 
���   �$��0,0,1,0q�6%   $	��500��6?   ._�5      �� $	��750��6   .+�5      � $��	0,10,10,0q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�5      �� -   5         ��Name$ txtMaHD��5   "   $��10q�63   $	��150��6?   $��35��6K   $	��8.5q�6W   $��Center=�6e   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã hóa đơn��6�   $��Bottom=�6�   $��13(�6�    ! MaterialDesignOutlinedTextBox#��[ 6�   �� 5      -   5         ��Name$ cbbTenSp��5      	 �� 
IsEditable$
	 True��5      $	��200��5      $��35��5      $��8q�5      $��13(�5      $ Tên sản phẩm��5        " MaterialDesignOutlinedComboBox#��[ 5#      {�5!      �� 
 �� Path$
 	IsChecked� �� ElementName$% OutlinedComboBoxEnabledCheckBox����5"      �� *ShortStringList+5#      �� 5$      -   5        $ txtSoLuongBan��5$   "   $��10q�69   $	��100��6E   $��35��6Q   $��10q�6]   $��Center=�6j   $ Số lượng��6�   $��13(�6�   #��[ 6�   5&      �� 5'      -   5         ��Name$ btnAdd��5(      $	��100��5)       " MaterialDesignPaperLightButton#��[ 5+       � ToolTip$3 -Resource name: MaterialDesignPaperLightButton��5,      $��	10,10,0,0q�5-      {�5*      �� *DataContext .ControlsEnabled+ �� RelativeSource �� *FindAncestor+ �� AncestorType
 Window.��5.      � .+�5/      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	PlusThick=�66   $��14��6G   $��-5,0,0,0q�6R   �� 50      $��Thêm��6(   51      52      �� 53      -   5        $ btnDel��54      $	��100��55      #��[ 57      $3 -Resource name: MaterialDesignPaperLightButton��58      $��	10,10,0,0q�59      {�56      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
 Window.��5:      � .+�5;        $ Delete=�66   $��13��6D   $��-5,0,0,0q�6O   �� 5<      $
��Xóa��6(   65   5=      5>      5?      &   System.Windows.Controls.DataGrid  5@      -   5          Name$ 
dg_BanHang��5@      $��Bottom=�6/   $	��298��6Q      
IsReadOnly$
 True��6^   5B      5D      5E      �� 5F   
   $	��249��6   .+�5G      �� 
���   �$��0,0,0,1q�6)   ._�5H      �� $��	5,10,0,10q�6   .+�5I      �� $��Tên nhân viên:��6   $��16(�65   �� 5J      -   5        $ cbbTenNv��5J      $	��240��61   $��30��5K      $��5q�5L      $��13(�5M      #��[ 5P      {�5N      �� $
 	IsChecked�$% OutlinedComboBoxEnabledCheckBox����5O      �� *ShortStringList+5P   �   �� 5Q      $��Mã nhân viên:��6   $��16(�64   �� 5R      -   5        $ txtMaNV��5R      $	��240��6/   $��5q�6;   #��[ 6G   $��30��6~   5T      5U      � 5V      $��	0,20,0,50q�6   .+�5W      �� $��17(�6   .��6&   Tổng tiền:62   �� 5X      -	   5         ��Name$ 
tbTongTien��5X      $��20(�6A   $��Center=�6O   
��������60   �� 6j   5Y      �� 5Z      -
   5        $��18(�5Z      $
��Bold"�6#   $	��150��65   $��40��6A   $��0,10,0,0q�6M   .��6w   Thanh toán5\      �� 5]      -   5        $��18(�5]      $
��Bold"�6#   $	��150��65   $��40��6A   $��0,10,0,0q�6M   .��6s   Hủy Đơn Hàng5_      �� 5`      -   5        $��18(�5`      $
��Bold"�6#   $��0,10,0,0q�65   $	��150��6G   $��40��6S   .��6s   Xuất Hóa Đơn5b      5c      5d      5f      