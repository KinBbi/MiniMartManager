   M S B A M L   `   `   `  ����H  Dquanlibanhang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:quanlibanhang.Formquanlibanhang.Form  5      $    quanlibanhang.Form.frmNhanVien   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:quanlibanhang.Form     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	     N� Title$  frmNhanVien��5	      $	��600��6   $	��920��6)      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper N� 
Background# �  5   	     MaterialDesignFont N� 
FontFamily# �  5   	   .��5      �� .+�5   
   �� $��Center=�6   $	��Top=�63   $	��800��6K   .+�5      �� $��Danh Mục Nhân Viên��6   $��27(�61   $
��Bold"�6?   
����  �$��Center=�6g   $��0,15,0,0q�6�   $��46��6�   �� 5       �� Orientation$ 
Horizontal=�6   $��80��62   .+�5      �� $	��400��6   $��15 0 0 0q�6,   .+�5      �� $ 
Horizontal=�6!   $��32��6;   $��0 0 0 5q�6J   .+�5      �� $��Mã Nhân Viên: ��6    $��Center=�69   $��13(�6T   $	��100��6b   �� 5      -   5         ��Name$ txtMaNv��5      $��30��5      $��5q�5       ! MaterialDesignOutlinedTextBox#��[ 5        �� TextWrapping$
 Wrap=�5!      " �� VerticalScrollBarVisibility$
 Auto=�5"      $	��180��6@   	 J� RenderTransformOrigin$	 0.525,2.046&�6L   {�5      �� 
 �� Path$
 	IsChecked� �� ElementName$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5"   L   5#      �� 5$      $ 
Horizontal=�6!   $��32��6:   .+�5%      �� $��Tên Nhân Viên: ��6    $��Center=�6:   $��13(�6U   $	��100��6c   �� 5&      -   5        $ txtTenNv��5'      $��30��5(      $��5q�5)      #��[ 5+      $
 Wrap=�5,      $
 Auto=�5-      $	��180��6=   $	 0.525,2.046&�6I   {�5*      �� $
 	IsChecked�$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5-   I   5.      5/      �� 51      $	��400��6   .+�52      �� $ 
Horizontal=�6!   $��32��6:   $��0 0 0 5q�6I   .+�53      �� $��Số điện thoại: ��6    $��Center=�6:   $��13(�6U   �� 54      -   5        $ txtSdt��55      $��30��56      $��5q�57      #��[ 59      $
 Wrap=�5:      $
 Auto=�5;      $	��180��6=   $	 0.525,2.046&�6I   {�58      �� $
 	IsChecked�$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5;   I   5<      �� 5=      $ 
Horizontal=�6!   $��32��6:   .+�5>      �� $��Giới Tính: ��6    $��Center=�66   $��13(�6Q   �� 5?      -   5        $ txtGioiTinh��5@      $��25,0,0,0q�5A      $��30��5B      $��5q�5C      #��[ 5E      $
 Wrap=�5F      $
 Auto=�5G      $	��180��6A   $	 0.525,2.046&�6M   {�5D      �� $
 	IsChecked�$2 ,MaterialDesignOutlinedTextBoxEnabledComboBox��5G   M   5H      5I      5J      �� 5L      $ 
Horizontal=�6   $��Center=�62   $��0 10 0 0q�6O   .+�5M      �� -   5        $��0 0 20 0q�5M      .��6@   Thêm6F   �� 5N      -   5         ��Name$ btnXoaNv��5N      $��	15 0 15 0q�6,   .��6W   Xóa6\   �� 5O      -   5        $ btnCapNhatNv��5O      $��15 0 0 0q�6/   .��6\   Cập Nhật6f   5P      �� 5Q      $
��0,20q�6   .��5R      &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgNhanVien��5R      $	��210��6/      
IsReadOnly$
 True��6?   6�   5S      5U      5V      5W      