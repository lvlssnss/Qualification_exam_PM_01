   M S B A M L   `   `   `  ����@  <BANer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BANer.Edit
BANer.Edit  5   	       BANer.Edit.Edit_Client   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $localclr-namespace:BANer.Edit  5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	   $	��425��5
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
 0,0&�6*    �� EndPoint$	 1,1&�5&   &   .��5'      �  � Color$ Black��6'    � Offset$ 0Q�5(   #   5)      5+      � 5,      $��1��6    � ColumnDefinitions 5.      �� 5/      6)    51      �� 52      $	��185 �6$   63   �� 53      6&   .+�55      �  56      �� 57      6-   �� 58      6-   .+�5:      �� $ Vertical=�6!   $��0��68   $��1��6E   $��	0,20,20,0q�6U   .+�5;      �� -   5         ��Name$ LFMnamefield��5;   "      MaterialDesignTextBox#��[  68   ���	#FFE91E63$	��275��5<      $��35��5=      $
��Left=�5>      $
��Bold"�5?      $��15(�5@      $
��0,20q�6#    �� 	MaxLength$ 60��5A      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Введите ФИО��5B         HintOpacity$	 0.7Q�6B   $��0 0 0 2q�6n   
�������.  (MaterialDesignThemes.Wpf.TextFieldAssist!   CharacterCounterVisibility$ Hidden=�5D      �� 5F      -   5        $ Login��5F   "   #��[  61   ���	#FFE91E63$	��275��5G      $��35��5H      $
��Left=�5I      $
��Bold"�5J      $��20(�5K      $ 11��5L      $ Введите номер��5M      $	 0.7Q�6E   $ Hidden=�5N      $��0 0 0 2q�6T   
�������$
��0,20q�5O      5Q      �� 5R      $ Vertical=�6!   $��0��68   $��0��6E   $��	20,20,0,0q�6U   .+�5S      �� $��ФИО��6"   $	��200��6.   #��[  6:   $��35��5T      $
��0,20q�5U      $��0q�5V      
������ $��20(�6C   $
��Bold"�6Q   ���	#FFE91E63 �� 
IsReadOnly .  J� IsHitTestVisible .  $��Center=�5W      �� 5Y      $��
Номер��6"   $	��200��60   #��[  6<   $��35��5Z      $
��0,20q�5[      $��0q�5\      
������ $��20(�6C   $
��Bold"�6Q   ���	#FFE91E63 .  .  $��Center=�5]      5^      5_      � 5`      $��1��6    5a      �� 5b      6-   �� 5c      6-   �� 5d      6-   .+�5f      �� -   5        $ EditUser��5f      $��0��6   $
��Bold"�6-   $	��165��6?   $	��Top=�6K   $��Right=�6c   .��6�   Изменить6�   �� 5g      -   5        $ MakeChanges��5g   c   $��1��6   $
��Bold"�6-   $	��165��6?   $	��Top=�6K   .��6�   !Внести изменения6�   �� 5h      -	   5        $ 
DeleteUser��5h   ~   $��2��6   $
��Bold"�6-   $	��165��6?   $	��Top=�6K   $
��Left=�6c   .��6�   Удалить6�   5i      5j      5k      5l      5m      