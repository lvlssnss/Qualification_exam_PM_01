   M S B A M L   `   `   `  ����@  <BANer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BANer.User_ContolsBANer.User_Contols  5      #    BANer.User_Contols.UC_Clients   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:BANer.User_Contols     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $	��13* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��5      $��1��5      .+�5      �� -   5         ��Name$ New_User��5      $��0��5      $��1��5      $%��Добавить клиента��5      $��Right=�5      $��10,10,10,10q�5      
�������6+   �� 5      -   5         ��Name$ 	Filt_Post��5   �   $	��275��6   $��34��6#   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$) #Выберите должность��6/   $
��0,20q�6c   
�������$
��Bold"�6�    � ToolTip$* $Сортировка по имени��6�   $��20(�5      ���	#FFE91E635      5       �� 5!   
   ���	#FFCCFFE3$��1��5"      $��1��5#      $��1q�5$       �� CornerRadius$ 15��5%      ��5&      �� 5'       �� 
StartPoint$	 0,0&�6&   	 �� EndPoint$		 1,1&�67   .��5(      � 
 � Color$
 Black��6#    � Offset$ 0Q�61   5)      ._�5+      �� -   5         ��Name$ LV_Users��5+      $��1��6   $��1��6$   $��10,10,10,10q�64   $��Disabled=�6I   ��5,      �� 5-      .R�5.      �  � Orientation$ 
Horizontal=�6$   $
��Left=�5/   $   50      ��52      �� 53      .R�54      �� $ 10��6!   $��2q�55   !    J� Opacity$
 0.95Q�56   !   ��57      �� 58   "   $	 0,0&�66   $		 1,1&�59   6   .��5:   &   � $
 Transparent��63   $ 0Q�5;   3   5<   #   ._�5>      � $	��450��6#    5?   "   �� 5@   &   $
��auto �64   �� 5A   &   $��5* �64   �� 5B   &   $
��auto �64   �� 5C   &   $
��auto �64   .+�5E   "   �� 6+   �� 5F   "   
�������.+�5G   &   � $ Vertical=�60   $
��Left=�5H   0   $��Center=�5I   0   $��0��5J   0   .+�5K   *   �� $��10,0,0,0q�63   $��0q�6l   
������ $��14(�6�   $
��Bold"�6�   ���	#FFE91E63 �� 
IsReadOnly .  J� IsHitTestVisible .  ��6E   �� *
Fiofield+ �� Mode$ OneWay=�6�   �� 5L   *   $��10,0,0,0q�62   $��0q�6g   
������ $��14(�6�   $
��Bold"�6�   ���	#FFE91E63$	��450��6�    .  .  ��6D   �� *Phone+$ OneWay=�6�   5M   '   �� 5N   &   $ Edit_del_Order��6-   -   5        $��0��5O   -   $��1��5P   -   $��
Опции��5Q   -   
�������$��Right=�5R   -   $��10,-5,20,10q�5S   -   6B   5T   #   5U      5V      5W      5Y      5Z      5[      5\      