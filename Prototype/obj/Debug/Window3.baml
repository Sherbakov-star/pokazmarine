   M S B A M L   `   `   `  ����D  @Prototype, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Prototype	Prototype  5   	       Prototype.Window3   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Prototype     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  
Sherbakoff��5	   	   $	��600��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � ���	#ffdadada.+�5   
   �� $	��400��6   $��49,43,39.6,75.4q�6    ���#ffcabd$��Center=�6N    �� Padding$ 30q�6i   $	��550��6v    �� CornerRadius$ 20��6�   $	��452��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      �� .+�5      �� $��Sherbakoff's Bank��6   $��30(�65   $
��Bold"�6C   $��0 0 0 20q�6U   �� 5      $��Баланс :��6   $��24(�6,   $
��Bold"�6:   $	��105��6L   $
��Left=�6X   $��288,-55,0,0q�6s   $��53��6�   �� 5      -   5         ��Name$ money��5      $��0��6+   $��24(�64   $��Center=�6B   $��97��6_   $��388,-52,5.4,26q�6j   $
��Bold"�6�   $��32��6�   �� 5      $��Платежи��6   $��24(�6+   $
��Bold"�69   �� 5      $%��Мобильная связь :��6   $��18(�65   $
��Bold"�6C   $��62,10,258.4,0q�6U   �� 5      -   5        	 ��Name$	 mobile��5      $��230,-25,167.4,0q�6*   $��26��6C   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Введите сумму��6O   �� 5      -   5        $��Оплатить��5      
���   ����#ffcabd$��354,-25,37.4,0q�6T   6l   �� 5      $+��%Транспортная карта :��6   $��18(�68   $
��Bold"�6F   $��42,10,256.4,0q�6X   �� 5      -   5        $		 bus��5      $��230,-25,167.4,0q�6'   $��26��6@   $
 Введите сумму��6L   �� 5      -   5        $��Оплатить��5      
���   ����#ffcabd$��354,-25,37.4,0q�6T   6l   �� 5      $/��)Коммунальные платежи :��6   $��18(�6:   $
��Bold"�6H   $��0,10,258.4,0q�6Z   �� 5      -   5        $		 dom��5      $��230,-25,167.4,0q�6'   $��26��6@   $
 Введите сумму��6L   �� 5      -   5        $��Оплатить��5      
���   ����#ffcabd$��354,-25,37.4,0q�6T   6l   �� 5      $��Налоги :��6   $��18(�6,   $
��Bold"�6:   $��154,10,258.4,0q�6L   �� 5      -   5        $	 nalog��5      $��230,-25,167.4,0q�6)   $��26��6B   $
 Введите сумму��6N   �� 5       -	   5        $��Оплатить��5       
���   ����#ffcabd$��354,-25,37.4,0q�6T   6l   �� 5!      $��Штрафы :��6   $��18(�6,   $
��Bold"�6:   $��142,10,258.4,0q�6L   �� 5"      -
   5        $	 shtraf��5"      $��230,-25,167.4,0q�6*   $��26��6C   $
 Введите сумму��6O   �� 5#      -   5        $��Оплатить��5#      
���   ����#ffcabd$��354,-25,37.4,0q�6T   6l   �� 5$      $+��%Медицинские услуги :��6   $��18(�68   $
��Bold"�6F   $��33,10,258.4,0q�6X   �� 5%      -   5        $		 med��5%      $��230,-25,167.4,0q�6'   $��26��6@   $
 Введите сумму��6L   �� 5&      -   5        $��Оплатить��5&      
���   ����#ffcabd$��354,-25,37.4,0q�6T   6l   � 5)      $��10 250 10 10q�6   .+�5*      �� -   5        $
��Left=�5*      $��
Назад��68   
���   �$��Bottom=�6[   $��-1,-241,0,241q�6�   5+      5-      5.      5/      50      