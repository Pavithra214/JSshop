   M S B A M L   `   `   `  ����A  =JSShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:JSShopJSShop  5   	       JSShop.ForgotPwd   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:JSShop     5   	     � Title$  	ForgotPwd��5   	   
�������$	��400��62   $	��300��6?    � WindowStartupLocation$ CenterScreen=�6K    � 
ResizeMode$ NoResize=�6p    � WindowStyle$
 None=�6�   .��5	      �� $��Center=�6    �� Orientation$ Vertical=�6.   $��20q�6E   .+�5
   
   �� $��Change the Password��6   $��20(�6/   $��Center=�6=   5      � 5   
    � RowDefinitions 5      �� 5      $��* �6    6-   �� 5      $��* �6    6-   �� 5      $��* �6    6-   �� 5      $��* �6    6-   �� 5      $��* �6    6-   �� 5      $��* �6    6-   �� 5      $��* �6    6-   .+�5      �� $��14(�6   $��Old Password��6'   $��0��6;   $
��0,15q�6H   6X   G� 5      -   5         G�Name$ txtname��5   U   
������� G� PasswordChar$ *��6,    G� Password$ Old Password��6=   $��1��6f   6u   �� 5      $��14(�6   $��New Password��6'   $��2��6<   $
��0,15q�6I   6Y   G� 5      
�������$ *��6,   $ Old Password��6=   $��3��6W   6f   �� 5      $��14(�6   $��Confirm the new Password��6'   $��4��6H   $
��0,15q�6U   6e   G� 5      
�������$ *��6,   $ Old Password��6=   $��5��6W   6f   5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   .+�5   
   �� $��Change the Password��6   
���2͚�$
��0,20q�6H   $	��140��6V   $��40��6b   	 � 	Resources	 5       
 �� 
TargetType �� Property �� Value��%d   '��       �� 5!      "
 ��6   .�5"      ��  �@��CornerRadius$ 18��65   6B   5#      5$      5%      �� 5&      -   5         ��Name$ 	BtnCancel��5&   &   $��Cancel��6   
���2͚�$��20,20q�6k   $��80��6z   $��40��6�   	 5'      ��%d   '��       �� 5(      "
 ��6   .�5)      ��  �@��CornerRadius$ 18��69   6F   5*      5+      5,      5-      5.      5/      