   M S B A M L   `   `   `  ����D  @ROCit_P31, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ROCit_P31	ROCit_P31  5          ROCit_P31.AddWorkplace   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ROCit_P31     5      .��5	      � .+�5
   
   �� $��Dealer Toevoegen��6   $
��Left=�6+   $��	10,10,0,0q�6F   $	��Top=�6Y   $��Trebuchet MS)�6q   
�������6�   �� 5   
   $��Dealernaam:��6   $
��Left=�6&   $��	32,44,0,0q�6A   $	��Top=�6T   $��Trebuchet MS)�6l   
�������6�   �� 5   
   -   5          ��Name$  btnLijstOpslaan��5      $��Dealer Toevoegen��6*   $
��Left=�6E   $��
114,74,0,0q�6`   $	��Top=�6t   $	��125��6�   $��22��6�   $��Trebuchet MS)�6�   
����������	#FFFF8900
�������$��3q�6  �� 5   
   -   5         ��Name$ tbxDealerNaam��5      $
��Left=�6)   $��23��6D   $��
114,46,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dgDealers��5      $
��Left=�6&   $	��153��6A   $��
24,114,0,0q�6N   $	��Top=�6b   $	��302��6z      AutoGenerateColumns .  $��Trebuchet MS)�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Dealernummer��6e   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
dealerId+   ClipboardContentBinding 6B   Z� 6e     5      $ 
Dealernaam��6g    6%   �� *
dealerNaam+ 6D   Z� 6g   5      5      5      