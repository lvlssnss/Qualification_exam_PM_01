   M S B A M L   `   `   `  ����@  <BANer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BANer.User_ContolsBANer.User_Contols  5      #    BANer.User_Contols.UC_Banners   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:BANer.User_Contols     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $	��13* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��5      $��1��5      .+�5      �� -   5         ��Name$ New_User��5      $��0��5      $��1��5      $!��Добавить банер��5      $��Right=�5      $��10,10,10,10q�5      
�������6+   �� 5      -   5         ��Name$ 	Filt_Post��5   �   $	��275��6   $��34��6#   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Выберите статус��6/   $
��0,20q�6`   
�������$
��Bold"�6�    � ToolTip$. (Фильтрация по статусу��6�   $��20(�5      ���	#FFE91E635      �� 5       -   5        $ 	Sort_Name��5    �   $	��220��6   $��34��6#   $	 zxc��6/   $��20,20q�6T   
�������$
��Bold"�6y   $ Сортировка по��6�   $��20(�5!      ���	#FFE91E635#      �� 5$      -   5        $ value��5$   �   $	��220��6   $��34��6#   $ value��6/   $��20,20q�6V   
�������$
��Bold"�6{   $ Сортировка по��6�   $��20(�5%      ���	#FFE91E635'      5(      �� 5)   
   ���	#FFCCFFE3$��1��5*      $��1��5+      $��1q�5,       �� CornerRadius$ 15��5-      ��5.      �� 5/       �� 
StartPoint$	 0,0&�6&   	 �� EndPoint$		 1,1&�67   .��50      � 
 � Color$
 Black��6#    � Offset$ 0Q�61   51      ._�53      �� -   5         ��Name$ LV_Users��53      $��1��6   $��1��6$   $��10,10,10,10q�64   $��Disabled=�6I   ��54      �� 55      .R�56      �  � Orientation$ 
Horizontal=�6$   $
��Left=�57   $   58      ��5:      �� 5;      .R�5<      �� $ 10��6!   $��2q�5=   !    J� Opacity$
 0.95Q�5>   !   ��5?      �� 5@   "   $	 0,0&�66   $		 1,1&�5A   6   .��5B   &   � $
 Transparent��63   $ 0Q�5C   3   5D   #   ._�5F      � $	��450��6#    5G   "   �� 5H   &   $
��auto �64   �� 5I   &   $��5* �64   �� 5J   &   $
��auto �64   �� 5K   &   $
��auto �64   .+�5M   "   �� 6+   �� 5N   "   
�������.+�5O   &   � $ Vertical=�60   $
��Left=�5P   0   $��Center=�5Q   0   $��0��5R   0   .+�5S   *   �� $��10,0,0,0q�63   $��0q�6l   
������ $��14(�6�   $
��Bold"�6�   ���	#FFE91E63 �� 
IsReadOnly .  J� IsHitTestVisible .  ��6E   �� *
Fiofield+ �� Mode$ OneWay=�6�   �� 5T   *   $��10,0,0,0q�62   $��0q�6e   
������ $��14(�6�   $
��Bold"�6�   ���	#FFE91E63$	��450��6�    .  .  ��6D   �� *Far+$ OneWay=�6�   �� 5U   *   $��10,0,0,0q�62   $��0q�6g   
������ $��14(�6�   $
��Bold"�6�   ���	#FFE91E63 .  .  ��6D   �� *Cost+$ OneWay=�6�   �� 5V   *   $��10,0,0,0q�62   $��0q�6i   
������ $��14(�6�   $
��Bold"�6�   ���	#FFE91E63 .  .  ��6D   �� *Status+$ OneWay=�6�   5W   '   �� 5X   &   $ Edit_del_Order��6-   -   5        $��0��5Y   -   $��1��5Z   -   $��
Опции��5[   -   
�������$��Right=�5\   -   $��10,-5,20,10q�5]   -   6B   5^   #   5_      5`      5a      5c      5d      5e      5f      