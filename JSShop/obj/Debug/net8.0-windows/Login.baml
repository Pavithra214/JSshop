   M S B A M L   `   `   `  ����A  =JSShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:JSShopJSShop  5   	       JSShop.Login   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:JSShop     5   	     � Title$  Login��5   	   $	��550��6   $	��350��6$    � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ NoResize=�6U    � WindowStyle$
 None=�6k   ��5	      �� 5
   
    �� ImageSource$A ;C:\Users\PAVITHRA\source\repos\Colors\Images\Background.jpg��6   6a   .��5      �� $	��500��6   $	��300��6    �� CornerRadius$ 18��6&   
�������$��3q�6L    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6      ShadowDepth$ 12Q�6/   	   	Direction$		 -90Q�6@   6R   ��5   
   �� 5      $A ;C:\Users\PAVITHRA\source\repos\Colors\Images\Background.jpg��6   6e   ._�5   
   �� $��Center=�6   
 �� Orientation$
 Vertical=�62   $��20q�6I   .+�5      �� $��24(�6   ���#FFF$��Center=�68   �� 5      $+��%C:\Users\PAVITHRA\Downloads\User4.jpg��6   $��80��6F   $��70��6Q   6_   5      � 5       � RowDefinitions 5      �� 5      $��* �6$   61   �� 5      $��* �6$   61   �� 5      $��* �6$   61   �� 5      $��* �6$   61   �� 5      $��* �6$   61   .+�5       �� 
�������$��14(�6/   $��	User Name��6=   $��0��6N   $
��0,15q�6[   6k   �� 5!      -   5         ��Name$ txtname��5!   5   $��Enter the User Name��6   $��1��6F   6U   �� 5"      
�������$��14(�6/   $��Enter the password��6=   $��2��6X   $
��0,15q�6e   6u   G� 5#      -   5         G�Name$ pbpwd��5#       G� Password$ Enter the password��6-   $��3��6M   6\   5%      �� 5&      -   5         ��Name$ 	btnforgot��5&   0   $��Forgot Password?��6   $	��150��6[   
���  ��$��12(�6x   $��
120,10,0,0q�6�   $��0 0 0 0q�6�   $��Right=�6�   
������ $��30��6�   6�   �� 5'      -   5        $ BtnLogin��5'   %   $��Login��6   $	��250��6N   $��35��6Z   
����  ����#FFF$
��0,25q�6�    � 	Resources 5(       �� 
TargetType �� Property �� Value��%d   '��       �� 5)      " ��6   .�5*      ��  �@��CornerRadius$ 20��69   6F   5+      5,      5-      �� 5.      -   5        $ 
BtnNewUser��5.   �   $��	New User?��6   
�������$��Bottom=�6<   $��Center=�6W   $	��0,5q�6t   
������ $��0,0,0,1q�6�   
�������6�   �� 5/      $��SIGNUP��6   $��Bottom=�6&   
�������$��Center=�6T   $	��0,5q�6q   6�   50      51      52      