   M S B A M L   `   `   `  ����@  <BANer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BANer.New	BANer.New  5   	       BANer.New.New_Banner   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   #localclr-namespace:BANer.New  5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	   $	��600��5
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
 0,0&�6*    �� EndPoint$	 1,1&�5&   &   .��5'      �  � Color$ Black��6'    � Offset$ 0Q�5(   #   5)      5+      � 5,      $��1��6    � ColumnDefinitions 5.      �� 5/      6)   �� 50      6)    52      �� 53      $	��364 �6$   63   �� 54      6&   .+�56      �� $ Vertical=�6   $��0��64   $��1��6A   $��	0,20,20,0q�6Q   .+�57      �� -   5         ��Name$ Login��57         MaterialDesignTextBox#��[  6-   ���	#FFE91E63$	��275��58      $��35��59      $
��Left=�5:      $
��Bold"�5;      $��20(�5<       �� 	MaxLength$ 6��5=      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$2 ,Введите название трассы��5>         HintOpacity$	 0.7Q�6O   .  (MaterialDesignThemes.Wpf.TextFieldAssist!   CharacterCounterVisibility$ Hidden=�5?      $��0 0 0 2q�6T   
�������$
��0,20q�5@      �� 5B      -   5        $ Password��5B      #��[  60   ���	#FFE91E63$	��275��5C      $
��0,20q�6"   $��35��5D      $
��Left=�5E      $
��Bold"�5F      $��20(�5G      $ 9��5H      $+ %Введите удалённость��5I      $	 0.7Q�6J   $��0 0 0 2q�6v   
�������$ Hidden=�5K      �� 5M      -   5        $ price��5M      #��[  6-   ���	#FFE91E63$	��275��5N      $
��0,20q�6"   $��35��5O      $
��Left=�5P      $
��Bold"�5Q      $��20(�5R      $ 6��5S      $' !Введите стоимость��5T      $	 0.7Q�6H   $��0 0 0 2q�6t   
�������$ Hidden=�5V      �� 5X      -   5        $ status��5X      #��[  6.   ���	#FFE91E63$	��275��5Y      $
��0,20q�6"   $��35��5Z      $
��Left=�5[      $
��Bold"�5\      $��20(�5]      $ 8��5^      $��Не арендован��6$    �� 
IsReadOnly . $ Введите длину��5_      $	 0.7Q�6D   $��0 0 0 0q�6p   
�������$ Hidden=�5a      5c      �� 5d      $ Vertical=�6   $��0��64   $��0��6A   $��	20,20,0,0q�6Q   .+�5e      �� $#��Название трассы��6   $	��200��66   #��[  6B   $��35��5f      $
��0,20q�5g      $��0q�5h      
������ $��20(�6C   $
��Bold"�6Q   ���	#FFE91E63 .  J� IsHitTestVisible .  $��Center=�5i      �� 5j      $#��Удалённость (км)��6   $	��200��67   #��[  6C   $��35��5k      $
��0,20q�5l      $��0q�5m      
������ $��20(�6C   $
��Bold"�6Q   ���	#FFE91E63 .  .  $��Center=�5n      �� 5o      $��Стоимость��6   $	��200��60   #��[  6<   $��35��5p      $
��0,20q�5q      $��0q�5r      
������ $��20(�6C   $
��Bold"�6Q   ���	#FFE91E63 .  .  $��Center=�5s      �� 5u      $��Статус��6   $	��200��6-   #��[  69   $��35��5v      $
��0,20q�5w      $��0q�5x      
������ $��20(�6C   $
��Bold"�6Q   ���	#FFE91E63 .  .  $��Center=�5y      5{      �� 5|      -	   5        $��1��5|      $��1��6)   $!��Добавить банер��66   $	��200��6O   $	��Top=�6[   6�   5}      5~      5      5�      