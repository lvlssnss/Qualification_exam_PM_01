   M S B A M L   `   `   `  ����@  <BANer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BANer.New	BANer.New  5   	       BANer.New.New_Client   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   #localclr-namespace:BANer.New  5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	   $	��425��5
   	   $	��620��5   	    � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	   .��5      �� $��5q�6   
���   � �� CornerRadius$ 10��65   ._�5   
   � ���	#FFCCFFE3 � RowDefinitions 5      �� 5      $	��150 �6    �� 5      $��5* �6    .+�5      �� $��../logo.png��6   $	��150��6)   $��0��65   $
��0,20q�6B   6R   �� 5      -   5         ��Name$ buttons��5   Z    �� Orientation$ 
Horizontal=�6   $��15��62   $��Right=�6>   $	��Top=�6k   .+�5      �� -   5         ��Name$ btnMinimize��5      $��15��6I   .��5      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]	   Icon$	 WindowMinimize=�6#   $��20��69   5      �� 5      -   5        $ btnClose��5      $��15��6B   $��52��6N   .��5        $	 Xmark=�6#   5       5!      �� 5"      $��1��6   $��1q�6#   $��20q�67   $ 15��5#      ��5$      �� 5%      
 �� 
StartPoint$	
 0,0&�6*    �� EndPoint$	 1,1&�5&   &   .��5'      �  � Color$ Black��6'    � Offset$ 0Q�5(   #   5)      5+      � 5,      $��1��6    � ColumnDefinitions 5.      �� 5/      6)   �� 50      6)    52      �� 53      $	��185 �6$   63   �� 54      6&   .+�56      �� $ Vertical=�6   $��0��64   $��1��6A   $��	0,20,20,0q�6Q   .+�57      �� -   5         ��Name$ LFMnamefield��57         MaterialDesignTextBox#��[  64   ���	#FFE91E63$	��275��58      $��35��59      $
��Left=�5:      $
��Bold"�5;      $��15(�5<      $
��0,20q�6#    �� 	MaxLength$ 60��5=      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Введите ФИО��5>         HintOpacity$	 0.7Q�6B   $��0 0 0 2q�6n   
�������.  (MaterialDesignThemes.Wpf.TextFieldAssist!   CharacterCounterVisibility$ Hidden=�5@      �� 5B      -   5        $ Login��5B      #��[  6-   ���	#FFE91E63$	��275��5C      $��35��5D      $
��Left=�5E      $
��Bold"�5F      $��20(�5G      $ 11��5H      $0 *Введите номер телефона��5I      $	 0.7Q�6N   $ Hidden=�5J      $��0 0 0 2q�6T   
�������$
��0,20q�5K      5M      �� 5N      $ Vertical=�6   $��0��64   $��0��6A   $��	20,20,0,0q�6Q   .+�5P      �� $��ФИО��6   $	��200��6*   #��[  66   $��35��5Q      $
��0,20q�5R      $��0q�5S      
������ $��20(�6C   $
��Bold"�6Q   ���	#FFE91E63 �� 
IsReadOnly .  J� IsHitTestVisible .  $��Center=�5T      �� 5V      $!��Номер телефона��6   $	��200��65   #��[  6A   $��35��5W      $
��0,20q�5X      $��0q�5Y      
������ $��20(�6C   $
��Bold"�6Q   ���	#FFE91E63 .  .  $��Center=�5Z      5[      �� 5\      -   5        $��1��5\      $��1��6)   $%��Добавить клиента��66   $	��200��6Q   $	��Top=�6]   6�   5]      5^      5_      5`      