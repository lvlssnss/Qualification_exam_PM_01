   M S B A M L   `   `   `  ����@  <BANer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BANer.PagesBANer.Pages  5   	       BANer.Pages.MainPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   %localclr-namespace:BANer.Pages  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          � WindowStyle$
  None=�5
   	    � AllowsTransparency . $	��730��5   	   $	��270��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   ���	#FFFFDAFF.��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   $	��270��5      �� 5       � RowDefinitions 5   
   �� 5      $	��165 �6   $��49��5      �� 5      .+�5   
   �� -   5         ��Name$ buttons��5   V    �� Orientation$ 
Horizontal=�6   $��15��6.   $��Right=�6:   $	��Top=�6g   .+�5      �� -   5         ��Name$ btnMinimize��5      $��15��6I   .��5       !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]	   Icon$	 WindowMinimize=�6#   $��20��69   5!      �� 5"      -   5        $ btnClose��5"      $��15��6B   $��52��6N   .��5#        $	 Xmark=�6#   5$      5%      �� 5&   
   $��../logo.png��6   $	��150��6%   $��0��61   $��0��6>   $
��0,20q�6N   6^   �� 5'   
   $��0��6   $��1��6!   $��1q�6.   
 �� CornerRadius$
 15,15,15,15��5(      $��
15,5,15,15q�6,   ���	#FFCCFFE3
���   �._�5)      �� .+�5*      �� -   5        $ BtnUsers��5*   W   $��30��6   $��10,10,10,10q�6%   
�������
�������.��5+      �� $
 30��6   ._�5,      �� $ 
Horizontal=�6%   .+�5-        $	 
UserSecret=�6+      
Foreground
 �����6=   �� 5.      $
��Wrap=�6(   $��Сотрудники��6<    �� TextAlignment$
 Left=�6N   5/      50      51      �� 52      -   5        $ BtnType��52   �   $��30��6   $��10,10,10,10q�6%   
�������
�������.��53      �� $
 30��6   ._�54      �� $ 
Horizontal=�6%   .+�55           IconFont$ Solid=�6+   $
	 User=�6<   
 �����6I   �� 56      $
��Wrap=�6(   $��Клиенты��6<   $
 Left=�6K   57      58      59      �� 5:      -   5        $ BtnProduction��5:   �   $��30��6   $��10,10,10,10q�6%   
�������
�������.��5;      �� $
 30��6   ._�5<      �� $ 
Horizontal=�6%   .+�5=        $		 Ban=�6,   
 �����68   �� 5>      $
��Wrap=�6(   $��Баннеры��6<   $
 Left=�6K   5?      5@      5A      �� 5B      -   5        $ 	BtnOrders��5B   �   $��30��6   $��10,10,10,10q�6%   
�������
�������.��5C      �� $
 30��6   ._�5D      �� $ 
Horizontal=�6%   .+�5E        $ Solid=�6+   $	 	Handshake=�6<   
 �����6N   �� 5F      $
��Wrap=�6(   $��Сделки��6<   $
 Left=�6J   5G      5H      5I      5J      5K      � 5L   
   -	   5         �Name$ LV_User_ControlPanel��5L      $��1��5M      $��1��5N      5O      5P      