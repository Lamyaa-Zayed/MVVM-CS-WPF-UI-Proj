   M S B A M L   `   `   `  ����F  BWpfOnlineEx, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfOnlineExWpfOnlineEx  5   	   )clr-namespace:WpfOnlineExWpfOnlineEx  5   	   )clr-namespace:WpfOnlineExWpfOnlineEx  5   	   C&clr-namespace:WpfOnlineEx.UserControlsWpfOnlineEx.UserControls  5	   	       WpfOnlineEx.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfOnlineEx     5   	   (vmclr-namespace:WpfOnlineEx     5   	   /	converterclr-namespace:WpfOnlineEx     5   	   5UC&clr-namespace:WpfOnlineEx.UserControls     5	   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5      !   WpfOnlineEx.PersonViewModel   PersonViewModel �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self	 �� RelativeSource
 �� Path��%�   &	        '��        5   
   6   �� 5   
   " ��6    5      P� 5       �@=�HasError$
 True��69   . �5      ��  �@�ToolTip 60   �� #	 Z $2
 ,(Validation.Errors).CurrentItem.ErrorContent�5      5      5      .��5      � 
����� � � DataContext 6   ��  �� Source# [   � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $
��Auto �6    � ColumnDefinitions 5!   
   �� 5"      $
��auto �6   �� 5#      $��* �6   .+�5%   
   �� $��1��6   $��0��6!   $��   First Name:��61   $��Center=�6G   $��Center=�6b   �� 5&   
   $��1��6   $��1��6   $	��200��6/   $��Center=�6;   ��6X   �� $
 Person.Fname� �� Mode$ TwoWay=� �� ValidatesOnDataErrors$
 True���� 5'   
   $��2��6   $��0��6!   $��   Last Name:��61   $��Center=�6F   $��Center=�6a   �� 5(   
   $��2��6   $��1��6   $	��200��6/   $��Center=�6;   ��6X   �� $
 Person.Lname�$ TwoWay=�$
 True���� 5+   
   $��Submit��6   $��1��6D   $��3��6T   $��	ExtraBold"�6a   
�������$��Center=�6�   ��6"   �� *SubmitCommand+6�   '   !WpfOnlineEx.UserControls.ListView  5,   
   $��4��6   $��1��6#   5.      5/      