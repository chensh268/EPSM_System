   M S B A M L   `   `   `  ����  EPSM_System'    !EPSM_System.pages.pay.EditPayPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  用户信息修改��5   	   $	��300��6   $	��300��6$    � WindowStartupLocation$ CenterScreen=�61    � 
ResizeMode$ NoResize=�6V   .��5      � -   5        $��gridUser��5      $��0,0,10,0q�6    � RowDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5	      $
��100* �6   �� 5
      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6    � ColumnDefinitions 5   
   �� 5      $	��29* �6   �� 5      $	��67* �6   .+�5   
   �� -   5        $��lblNo��5   '   $y�Hidden=�64   ��6   �� *No+64   �� 5   
   -   5        $��lblIsDel��5   *   $y�Hidden=�6:   ��6   �� *IsDel+6P   �� 5   
   $��员工编号：��6   $��Center=�6    $��Right=�6;   $��2q�6W   $��0��6b   $��0��6o   �� 5   
   -   5        $��txtID��5      $��Center=�6   $��2q�6;    �� TextWrapping$
 Wrap=�6F   $��0��6o   $��1��6|   ��6Z   �� *ID+6|   �� 5   
   $��	姓名：��6   $��Center=�6   $��Right=�69   $��2q�6U   $��1��6`   $��0��6m   �� 5   
   -   5        $��txtName��5      $��Center=�6!   $��2q�6=   $
 Wrap=�6H   $��1��6s   $��2��6�   ��6\   �� *Name+6�   �� 5   
   $��基础工资：��6   $��Center=�6    $��Right=�6;   $��2q�6W   $��2��6c   $��0��6p   �� 5   
   -   5        $��
txtBasePay��5   R   $��2q�6   $��Center=�6   $��2��6e   $��1��6r   ��68   �� *	BasePay+6r   �� 5   
   $��实际工资：��6   $��Center=�6    $��Right=�6;   $��2q�6W   $��3��6c   $��0��6p   �� 5   
   -   5        $��
txtRealPay��5   e   $��2q�6   $��Center=�6   $
 Wrap=�68   $��3��6x   $��1��6�   ��6L   �� *	RealPay+6�   �� 5   
   $��5��6   $��0��6"   $��2��62    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   $��Center=�6|   .+�5      �� -	   5        $��btnOk��5   0   $��修改��6   $
��20,2q�6"   $��60��6Q   $��30��6\   �� 5      -
   5        $��	btnCancel��5   1   $��取消��6   $
��20,2q�6"   $��60��6B   $��30��6M   6Y   5       �� 5!   
   $��	奖金：��6   $��Center=�6   $��Right=�69   $��0,6,4,15q�6U   $��4��6h   $��0��6u   �� 5"   
   -   5         ��Name$ txtBonusInTotal��5"   r   $��	0,10,4,18q�6   $��Center=�6%   $
 Wrap=�6@   $��4��6�   $��1��6�   ��6T   �� *BonusInTotal+6�   5$      5%      