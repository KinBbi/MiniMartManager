   M S B A M L   `   `   `  ����H  Dquanlibanhang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:quanlibanhang.Formquanlibanhang.Form  5   	   "    quanlibanhang.Form.frmThemSp   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:quanlibanhang.Form     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � Title$  Thêm sản phẩm��5   	   $	��450��6   $	��800��6,      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �� .+�5   
   �� $��Center=�6   $	��Top=�63   $	��800��6K   .+�5      �� $��Thêm Sản Phẩm��6   $��25(�6,   $
��Bold"�6:   
����  �$��Center=�6b   $��0,15,0,0q�6   $	��Top=�6�   $��46��6�   �� 5       �� Orientation$ 
Horizontal=�6   $��80��62   $��0,20,0,0q�6A   .+�5      �� $	��400��6   $��15 0 0 0q�6,   .+�5      �� $ 
Horizontal=�6!   $��32��6:   $��0,0,0,10q�6I   .+�5      �� $��Mã Sản Phẩm: ��6    $
��Left=�68   $	��Top=�6S   $	��100��6l   $��	10 10 0 0q�6x   $��13(�6�   �� 5      -   5         ��Name$ txtMaSp��5      $��30��5      $��5q�5      $��13(�5       ! MaterialDesignOutlinedTextBox#��[ 5       �� TextWrapping$
 Wrap=�5       " �� VerticalScrollBarVisibility$
 Auto=�5!      $	��200��6@    J� RenderTransformOrigin$ 0.525,2.046&�6L   {�5      �� *	IsChecked+ �� ElementName$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5!   L   5"      �� 5#      $ 
Horizontal=�6!   $��32��6:   $��0,0,0,10q�6I   .+�5$      �� $��Tên Sản Phẩm: ��6    $
��Left=�69   $	��Top=�6T   $	��100��6m   $��	10 10 0 0q�6{   $��13(�6�   �� 5%      -   5        $ txtTenSp��5&      $��30��5'      $��5q�5(      $��13(�5)      #��[ 5+      $
 Wrap=�5,      $
 Auto=�5-      $	��200��64   $ 0.525,2.046&�6@   {�5*      �� *	IsChecked+$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5-   @   5.      �� 5/      $ 
Horizontal=�6!   $��32��6:   $��0,0,0,10q�6I   .+�50      �� $��Số Lượng:��6    $
��Left=�64   $	��Top=�6O   $	��100��6h   $��	10 10 0 0q�6v   $��13(�6�   �� 51      -   5        $ 
txtSoLuong��52      $��30��53      $��5q�54      $��13(�55      #��[ 57      $
 Wrap=�58      $
 Auto=�59      $	��200��64   $ 0.525,2.046&�6@   {�56      �� *	IsChecked+$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox��59   @   5:      �� 5;      $ 
Horizontal=�6!   $��32��6:   $��0,0,0,10q�6I   .+�5<      �� $��Giá Nhập: ��6    $
��Left=�65   $	��Top=�6P   $	��100��6i   $��	10 10 0 0q�6w   $��13(�6�   �� 5=      -   5        $ 
txtGiaNhap��5>      $��30��5?      $��5q�5@      $��13(�5A      #��[ 5C      $
 Wrap=�5D      $
 Auto=�5E      $	��200��64   $ 0.525,2.046&�6@   {�5B      �� *	IsChecked+$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5E   @   5F      �� 5G      $ 
Horizontal=�6!   $��32��6:   $��0,0,0,10q�6I   .+�5H      �� $��Giá Bán: ��6    $
��Left=�64   $	��Top=�6O   $	��100��6h   $��	10 10 0 0q�6v   $��13(�6�   �� 5I      -   5        $ 	txtGiaBan��5J      $��30��5K      $��5q�5L      $��13(�5M      #��[ 5O      $
 Wrap=�5P      $
 Auto=�5Q      $	��200��64   $ 0.525,2.046&�6@   {�5N      �� *	IsChecked+$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5Q   @   5R      5S      �� 5U      $	��400��6   .+�5V      � $��25,0,0,0q�6    .+�5W      �� $��Ngày nhập:��6    $��Center=�65   $��13(�6W   (  "System.Windows.Controls.DatePicker  5X      -   5        	  Name$	 txtNgayNhap��5Y      $	��150��5Z      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 	Pick Date��5[      .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton$
 True��5\       ( $MaterialDesignFloatingHintDatePicker#��[ 5]      $��22,0,0,0q�5^      5_      � 5`      $��0,10,0,0q�6    .+�5a      �� $��Loại mặt hàng:��6    $��25,5,0,0q�69   $��13(�6K   �� 5b      -   5        $ txtLoaiHang��5c      $��30��5d      $��5q�5e      $��13(�5f      #��[ 5h      $
 Wrap=�5i      $
 Auto=�5j      $	��200��6<   $ 0.525,2.046&�6H   {�5g      �� *	IsChecked+$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5j   H   5k      �� 5l      $��0,20,0,0q�5m      $	��102��5n      $
 	Ghi Chú.��5o       �� 	MaxLength$ 40��5q      #��[ 5r      $
 Wrap=�5s      $
 Auto=�5t      $	��339��68   !   CharacterCounterVisibility 5p      ��  �� Path$ 	IsChecked�$4 .MaterialDesignOutlinedTextBoxTextCountComboBox��   BooleanToVisibilityConverter �� 	Converter# [ 5t   8   5u      5v      �� 5y      $ 
Horizontal=�6   $��Center=�62   $��0 20 0 0q�6O   .+�5z      �� -   5         ��Name$ btnLuuSp��5z      $��	15 0 15 0q�6,   .��6V   Thêm sản phẩm6e   �� 5{      -	   5        $ btnSuaSp��5{      $��	15 0 15 0q�6,   .��6V   Lưu sản phẩm6d   5|      5}      5~      5      