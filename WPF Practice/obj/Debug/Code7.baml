   M S B A M L   `   `   `  ����G  CWPF Practice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF_PracticeWPF_Practice  5   	   +clr-namespace:WPF_PracticeWPF_Practice  5   	       WPF_Practice.Code7   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF_Practice     5   	   )vmclr-namespace:WPF_Practice     5   	     � Title$  ListControlBinding(1)��5
   	   $	��600��6'   $	��800��64   .��5      ��  �� Orientation$ Vertical=�6   $��
0,0,0,-106q�6(   .+�5   
   �� $��ItemsControl��6   $��16(�6'   $
��Bold"�65   �� 5   
   $��10q�6   ��6#   �� *studentList+��5      �� 5      .R�5      �� $ 
Horizontal=�6!   .+�5      �� $��Name :��6$   �� 5      $
��Bold"�6:   ��6$   �� *Name+6:   �� 5      $��, ��6$   �� 5      $��Age: ��6$   �� 5      $
��Bold"�69   ��6$   �� *Age+69   �� 5      $�� (��6$   �� 5      $��	Underline{�6:   
����  � � Cursor$
 Hand��6h   ��6$   �� *Mail+6h   �� 5      $��)��6$   5      5      5      �� 5   
   $��ListBox��6   $��16(�6"   $
��Bold"�60   �� 5   
   $��10q�6   ��6   �� *studentList+��5       �� 5!      .R�5"      �� $ 
Horizontal=�6!   .+�5#      �� $��Name: ��6$   �� 5$      $
��Bold"�6:   ��6$   �� *Name+6:   �� 5%      $��, ��6$   �� 5&      $��Age: ��6$   �� 5'      $
��Bold"�69   ��6$   �� *Age+69   �� 5(      $�� (��6$   �� 5)      $��	Underline{�6:   
����  �$
 Hand��6h   ��6$   �� *Mail+6h   �� 5*      $��)��6$   5+      5,      5.      �� 50   
   $��ListView��6   $��16(�6#   $
��Bold"�61   � 51   
    � ColumnDefinitions 52      �� 53      $	��50* �6#   �� 54      $	��50* �6#   .+�56      �� $��20q�6   $��0��6G   ��6#   �� *studentList+��57      �� 58      .R�59      �� $ 
Horizontal=�6%   .+�5:      �� $��Name: ��6(   �� 5;      $
��Bold"�6>   ��6(   �� *Name+6>   �� 5<      $��, ��6(   �� 5=      $��Age: ��6(   �� 5>      $
��Bold"�6=   ��6(   �� *Age+6=   �� 5?      $�� (��6(   �� 5@      $��	Underline{�6>   
����  �$
 Hand��6l   ��6(   �� *Mail+6l   �� 5A      $��)��6(   5B      5C      5E      �� 5F      $��20q�6   $��1��6G   ��6#   �� *studentList+ �� View 5G      �� 5H      .P�5I      �� $
��Name��6)    �� Width$	 100��67    �� DisplayMemberBinding 6C   �� *Name+�� 5J      $	��Age��6)   $	 100��66    6B   �� *Age+�� 5K      $
��Mail��6)   $	 130��67    6C   �� *Mail+5L      5N      5O      �� 5Q   
   $��GridView��6   $��16(�6#   $
��Bold"�61   &   System.Windows.Controls.DataGrid  5S   
   $��10q�6      AutoGenerateColumns .  ��6   �� *studentList_2+   Columns 5T      0  *System.Windows.Controls.DataGridTextColumn  5U      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 63   �� *Name+  5V      $		 Age��6%   
 62   �� *Age+  5W      $
	 Mail��6%   
 63   �� *Mail+5Y      5[      5\      