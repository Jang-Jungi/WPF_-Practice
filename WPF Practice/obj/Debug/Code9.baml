   M S B A M L   `   `   `  ����G  CWPF Practice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF_PracticeWPF_Practice  5   	       WPF_Practice.Code9   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF_Practice     5   	     � Title$  ListControlBinding(3)��5   	   $	��600��6'   $	��800��64   .��5	      ��  �� Orientation$ Vertical=�6   .+�5
   
   �� $��ItemsControl��6   $��16(�6'   $
��Bold"�65   �� 5   
   -   5         ��Name$ ItemControl��5   #   $��10q�6   ��5      �� 5      .R�5      �� $ 
Horizontal=�6!   .+�5      �� $��Name: ��6$   �� 5      $
��Bold"�6:   ��6$   �� *Name+6:   �� 5      $��, ��6$   �� 5      $��Age: ��6$   �� 5      $
��Bold"�69   ��6$   �� *Age+69   �� 5      $�� (��6$   �� 5      $��	Underline{�6:   
����  � � Cursor$
 Hand��6h   ��6$   �� *Mail+6h   �� 5      $��)��6$   5      5      5      �� 5   
   $��ListBox��6   $��16(�6"   $
��Bold"�60   �� 5   
   -   5         ��Name$ ListBox��5   B   $��10q�6   ��6   �� *studentList+��5      �� 5      .R�5       �� $ 
Horizontal=�6!   .+�5!      �� $��Name: ��6$   �� 5"      $
��Bold"�6:   ��6$   �� *Name+6:   �� 5#      $��, ��6$   �� 5$      $��Age: ��6$   �� 5%      $
��Bold"�69   ��6$   �� *Age+69   �� 5&      $�� (��6$   �� 5'      $��	Underline{�6:   
����  �$
 Hand��6h   ��6$   �� *Mail+6h   �� 5(      $��)��6$   5)      5*      5,      �� 5.   
   $��ListView��6   $��16(�6#   $
��Bold"�61   � 5/   
    � ColumnDefinitions 50      �� 51      $	��50* �6#   �� 52      $	��50* �6#   .+�54      �� -   5         ��Name$ ListView��54   W   $��20q�6   $��0��6G   ��6#   �� *studentList+��55      �� 56      .R�57      �� $ 
Horizontal=�6%   .+�58      �� $��Name: ��6(   �� 59      $
��Bold"�6>   ��6(   �� *Name+6>   �� 5:      $��, ��6(   �� 5;      $��Age: ��6(   �� 5<      $
��Bold"�6=   ��6(   �� *Age+6=   �� 5=      $�� (��6(   �� 5>      $��	Underline{�6>   
����  �$
 Hand��6l   ��6(   �� *Mail+6l   �� 5?      $��)��6(   5@      5A      5C      �� 5D      -   5        $ 	ListView2��5D   W   $��20q�6   $��1��6G   ��6#   �� *studentList+ �� View 5E      �� 5F      .P�5G      �� $
��Name��6)    �� Width$	 100��67   	 �� DisplayMemberBinding	 6C   �� *Name+�� 5H      $	��Age��6)   $	 100��66   	 6B   �� *Age+�� 5I      $
��Mail��6)   $	 130��67   	 6C   �� *Mail+5J      5L      5M      �� 5O   
   $��GridView��6   $��16(�6#   $
��Bold"�61   &   System.Windows.Controls.DataGrid  5Q   
   -   5        
  Name$
 DataGrid��5Q   a   $��10q�6      AutoGenerateColumns .  ��6   �� *studentList_2+   Columns 5R      0  *System.Windows.Controls.DataGridTextColumn  5S      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+  5T      $	 Age��6%    62   �� *Age+  5U      $
 Mail��6%    63   �� *Mail+5W      5Y      5Z      