   M S B A M L   `   `   `  ����A  =JSShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:JSShopJSShop  5   	       JSShop.Register   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:JSShop     5   	     � Title$  Register��5   	   $	��800��6   $	��350��6'    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o   ��5	      �� 5
   
    �� ImageSource$. (C:\Users\PAVITHRA\Downloads\Regback2.jpg��6   6N   .��5      �� $	��300��6   $	��750��6    �� CornerRadius$ 28��6&    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6      ShadowDepth$ 12Q�6/   	   	Direction$		 -45Q�6@   6R   ��5   
   �� 5      $. (C:\Users\PAVITHRA\Downloads\Regback2.jpg��6   6R   ._�5   
   �� 
 �� Orientation$
 Vertical=�6   $��Center=�6,   $��20q�6I   .+�5   
   �� $��REGISTER��6   
�������$��20(�67   $��	ExtraBold"�6E   $��Center=�6\   6{   � 5       � RowDefinitions 5      �� 5      $��* �6$   61   �� 5      $��* �6$   61   �� 5      $��* �6$   61   �� 5      $��* �6$   61   �� 5      $��* �6$   61   �� 5      $��* �6$   61   �� 5      $��* �6$   61   �� 5      $��* �6$   61   �� 5      $��* �6$   61   �� 5       $��* �6$   61   �� 5!      $��* �6$   61   �� 5"      $��* �6$   61   �� 5#      $��* �6$   61   �� 5$      $��* �6$   61   .+�5&      �� 
�������$��14(�6/   $��	User Name��6=   $��0��6N   $
��0,15q�6[   6k   �� 5'      -   5         ��Name$ txtname��5'   5   $��Enter the User Name��6   $��1��6F   6U   �� 5(      
�������$��14(�6/   $��User ID��6=   $��2��6L   $
��0,15q�6Y   6i   �� 5)      -   5        $ 	txtuserId��5)   )   $��UserID��6   $��3��6<   6K   �� 5*      
�������$��14(�6/   $	��Age��6=   $��4��6H   $
��0,15q�6U   6e   �� 5+      -   5        $ txtage��5+   /   $��Enter the Age��6   $��5��6?   6N   �� 5,      
�������$��14(�6/   $��	Email ID:��6=   $��6��6N   $
��0,15q�6[   6k   �� 5-      -   5        $ txtemail��5-   5   $��Enter your Email ID��6   $��7��6H   6W   �� 5.      
�������$��14(�6/   $��	Phone No:��6=   $��8��6N   $
��0,15q�6[   6k   �� 5/      -   5        $ txtphone��5/   E   $��Enter your Phone no.��6    �� 	MaxLength$ 10��66   $��9��6X   6g   �� 50      
�������$��14(�6/   $��Enter the password��6=   $��10��6X   $
��0,15q�6f   6v   G� 51      -   5         G�Name$ pbpwd��51   <    G� Password$ Enter the password��6   $��11��6L   6\   �� 52      
�������$��14(�6/   $��Confirm the password��6=   $��12��6Z   $
��0,15q�6h   6x   G� 53      -   5        $ pbCpwd��53   ?   $ Confirm the password��6   $��13��6O   6_   54      �� 55      $
��0,20q�6   $
 
Horizontal=�6(   $��Center=�6A   .+�56      �� -   5         ��Name$ btnRegister��56      $��Register��6H   
���� ��$
��Bold"�6t   
�������$	��100��6�   $��0,0,30,0q�6�    � 	Resources 57       �� 
TargetType �� Property �� Value��%d   '��       �� 58      " ��6    .�59      ��  �@��CornerRadius$ 18��6=   6J   5:      5;      5<      �� 5=      -	   5        $ 	BtnCancel��5=   *   $��RegSQL��6   
���� ��$
��Bold"�6n   
�������$	��100��6�   $��50��6�    5>      ��%d   '��       �� 5?      " ��6    .�5@      ��  �@��CornerRadius$ 18��6=   6J   5A      5B      5C      5D      5F      5G      5H      