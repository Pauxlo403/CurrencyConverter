   M S B A M L   `   `   `  ����N  JWpfAppSimpleProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfAppSimpleProjectWpfAppSimpleProject  5   	   $    WpfAppSimpleProject.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WpfAppSimpleProject     5   	     � Title$  Currency Converter��5   	   $	��450��6$   $	��600��61   .��5	      �  � RowDefinitions 5
   
   �� 5      $��30 �6   6*   �� 5      6   �� 5      $��30 �6   6*   .+�5   
   o� -   5         o�Name$ Menu_MainWindow��5   ,   $��0��6   $��0��6   .@�5      m� $
��File��6   .@�5      m� -   5         m�Name$ MenuItem_Exit��5   )   $
��Exit��6   6^   5      m� 5      $
��Edit��6   6(   m� 5      $
��View��6   6(   m� 5      $
��Help��6   6(   5      � 5   
   $��1��6    5      �� 5      $
��Auto �6    60   �� 5      $��* �6    6-   .+�5!      �� $��0��6    �� Orientation$ Vertical=�6&   .+�5#      (  "System.Windows.Controls.DatePicker  $	��100��6      SelectedDate 6)   �� *Date+6I   �� 5&      $ 
Horizontal=�6   $��Center=�66   $��0,8,0,0q�6S   .+�5'      �� $	��100��6   ��6*   �� *	Number1+6E   �� 5(      -   5         ��Name$ 	Currency1��5(      $	��160��62   $��8,0,0,0q�6>    �� SelectedIndex$ 55��5*      ��5)      �� *CurrencyNames+5*   4   5+      �� 5.      $ 
Horizontal=�6   $��Center=�66   $��0,8,0,0q�6S   .+�5/      �� $	��100��6   ��6*   �� *	Number2+6E   �� 50      -   5        $ 	Currency2��50      $	��160��62   $��8,0,0,0q�6>   $ 60��52      ��51      �� *CurrencyNames+52   4   53      �� 56      -   5         ��Name$ ExecuteButton��56   +   $��Execute��6   $��80��6B   $��0,8,0,8q�6M   
������6�   57      &   System.Windows.Controls.DataGrid  5:      $��1��6:   	   AutoGenerateColumns$	 False��6G   ��6   �� *
Currencies+
   Columns
 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$
 Code��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *r030+6R     5=      $ Title��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 220 6P    68   �� *txt+6^     5>      $
 Rate��6)    67   �� *rate+6R   5@      5A      �� 5D   
   $��2��6   $��0��6!   .@�5E      �� .��5F      �� -   5         ��Name$ Label_StatusStripItem��5F      .��67   
Ready...6A   5G      5H      5I      5J      