   M S B A M L   `   `   `  ����G  CWPF Practice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WPF_PracticeWPF_Practice  5   	       WPF_Practice.Code5   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WPF_Practice     5   	     � Title$  Code5��5   	   $	��210��6   $	��250��6$    � 	Resources 5	      *   $WPF_Practice.YesNoToBooleanConverter   YesNoToBooleanConverter(   "WPF_Practice.ValueToColorConverter  ValueToColorConverter��%:   &	        &	        5
   
   6(     5   
   6&   5      .��5      �� $��10q�6   .+�5   
   �� -   5        $��txtValue��5      � 5   
   $
��0,10q�6   .+�5      �� $��Current value is: ��6   �� 5      ��6   ��  �� ElementName$ txtValue�� �� Path$
 Text� �� 	Converter# [  6   5      �� 5   
   $	��Yes��6}    d� 	IsChecked 6   �� $ txtValue��$
 Text�# [  6}   �� 5   
   -   5        $��	sliderBar��5      $��0,30,0,0q�6"    � Minimum$ 0Q�64    � Maximum$ 10Q�6@   � 5   
   $��20��6   $��0,10,0,0q�6   ��6-   �� $ 	sliderBar��$ Value�# [ 5      5      