   M S B A M L   `   `   `  ����K  GEmployeAccouting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:EmployeAccoutingEmployeAccouting  5   	   !    EmployeAccouting.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:EmployeAccouting     5   	   -   5          � Title$  
MainWindow��5   	   $	��400��6   $	��700��6*   $	��400��66   $	��700��6F    � WindowStyle$ SingleBorderWindow=�6U   ��6v   Z� ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF2C2C2A��6   � 5      $ 	#FF242540��6    � Offset$ 1Q�6-   5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��60 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 Grid��5   0      AutoGenerateColumns$ False��6   $��10,10,10,10q�6>   
�������
���   ����	#FF4D4C55$��15(�6�   $
��Bold"�6�   $��0��6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6D      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$
 Name�6R     5      $
 Addres��6L   $ * 6\    6%   �� $ PersonAddres�6\     5      $
 Phone number��6I   $ * 6_    6%   �� $ 	Telephone�6_     5      $
 Gender��6F   $ * 6V    6%   �� $ Gender�6V   5      �� 5   
   -   5        $��0,0,0,10q�5      $	��250��6#   $��50��6/   $��18(�6;   $
��Bold"�6I   $��1��6[   ���	#FF34445F���	#FF8BC172��6}   Z� .��6�   Add account6�   5      5      