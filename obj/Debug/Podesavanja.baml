   M S B A M L   `   `   `  ����  WPF_zadaca_2    WPF_zadaca_2.Podesavanja   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$$  Podešavanja konekcije na bazu��5   	   $	��282��6/   $	��600��6<    � Icon$' !Resources/Ikonica_Podesavanja.png��6H    � WindowStartupLocation$ CenterScreen=�6q   $	��600��6�   $	��282��6�    � 
ResizeMode$ CanMinimize=�6�   .��5      � $��0,0,0,0q�6    � ColumnDefinitions 5   
   �� 5      $
��197* �6   �� 5      $
��198* �6   �� 5	      $	��61* �6   �� 5
      $
��136* �6    � RowDefinitions 5   
   �� 5      $	��45* �6   �� 5      $	��35* �6   �� 5      $	��35* �6   �� 5      $	��35* �6   �� 5      $	��35* �6   �� 5      $	��45* �6   .+�5   
   �� $-��'Podešavanja konekcije na bazu podataka��6   $��0,4,0,5q�6A   $��Center=�6R   $��Center=�6v   $��20(�6�   $
��Bold"�6�   $��4��6�   �� 5   
   $"��Ime/IP servera baze podataka��6   $��Right=�67   $��1��6S   $	��261��6`   $��16(�6l   $��Right=�6z   $��Center=�6�   $��2��6�   �� 5   
   $��Naziv baze podataka��6   $��1��6.   $��Right=�6>   $��2��6Z   $	��156��6g   $��16(�6s   $��Right=�6�   $��Center=�6�   $��0q�6�   �� 5   
   $.��(Korisničko ime za pristup bazi podataka��6   $��3��6B   $	��291��6O   $��16(�6[   $��Right=�6i   $��Right=�6�   $��Center=�6�   $��2��6�   $��0q�6�   �� 5   
   $&�� Lozinka za pristup bazi podataka��6   $��1��6;   $��4��6K   $��16(�6X   $��Right=�6f   $��Center=�6�   $��58,0,0,0q�6�   �� 5   
   -   5         ��Name$ txtbox_ImeServera��5      $��2��6-   $��1,0,15,0q�6=   $��1��6O    �� TextWrapping$
 Wrap=�6\   $��Center=�6p   $��Center=�6�   $��0q�6�   $��25��6�   $��2��6�   �� 5   
   -   5        $ txtbox_ImeBaze��5      $��2��6*   $��1,0,15,0q�6:   $��2��6L   $
 Wrap=�6Y   $��Center=�6m   $��Center=�6�   $��25��6�   $��2��6�   �� 5   
   -   5        $ txtbox_Username��5      $��2��6+   $��1,0,15,0q�6;   $��3��6M   $
 Wrap=�6Z   $��Center=�6n   $��Center=�6�   $��25��6�   $��2��6�   G� 5   
   -   5         G�Name$ passbox_Password��5      $��2��60   $��1,0,15,0q�6@   $��4��6R   $��Center=�6_   $��Center=�6�   $��25��6�   $��2��6�   �� 5   
   -   5        $��Testiraj konekciju��5      $
��36,0q�6.   $��5��6<   $��37��6I   $��14(�6U   6c   �� 5   
   -   5        $��Snimi��5      $��1��6!   $
��36,6q�61   $��5��6?   $��14(�6L   6Z   �� 5   
   -   5        $��Odustani��5      $��2��6$   $
��36,6q�64   $��5��6B   $��2��6O   $��14(�6c   6q   5!      5"      